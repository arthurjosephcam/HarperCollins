using HarperCollins.Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

namespace HarperCollins.Repository.Configurations
{
    class SalesTileConfiguration : EntityTypeConfiguration<SalesTile>
    {
        public SalesTileConfiguration()
        {
            ToTable("SalesTile", "dbo");
            HasKey(f => f.SalesTileId);

            
            Property(f => f.SalesTileId).HasColumnName(@"SalesTileId").IsRequired().HasColumnType("int");
            Property(f => f.SalesId).HasColumnName(@"SalesId").IsRequired().HasColumnType("uniqueidentifier");
            Property(f => f.OrderQuantity).HasColumnName(@"OrderQuantity").IsRequired().HasColumnType("int");


            HasRequired(f => f.SalesData)
                .WithMany(f=> f.SalesTiles)
                .HasForeignKey(f => f.ISBN);
           


        }


    }
}
