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
    class SalesDataConfiguration : EntityTypeConfiguration<SalesData>
    {
        public SalesDataConfiguration()
        {
            ToTable("SalesData", "dbo");
            HasKey(f => f.ActualSalesId);

            Property(f => f.ActualSalesId).HasColumnName(@"ActualSalesId").IsRequired().HasColumnType("int");
            Property(f => f.SalesId).HasColumnName(@"SalesId").IsRequired().HasColumnType("uniqueidentifier");
            Property(f => f.OrderDate).HasColumnName(@"OrderDate").IsRequired().HasColumnType("datetime");
            Property(f => f.OrderQuantity).HasColumnName(@"OrderQuantity").IsRequired().HasColumnType("int");
            Property(f => f.OrderStatus).HasColumnName(@"OrderStatus").IsRequired().HasColumnType("varchar").HasMaxLength(20);


            HasRequired(f => f.TileData)
                .WithMany(f=> f.Sales)
                .HasForeignKey(f => f.ISBN);
            HasRequired(f => f.CustomerData)
                .WithMany(f=> f.Sales)
                .HasForeignKey(cd => cd.CustomerNumber);


        }


    }
}
