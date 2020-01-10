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
            HasKey(f => f.SalesId);

            Property(f => f.SalesId).HasColumnName(@"SalesId").IsRequired().HasColumnType("uniqueidentifier");
            Property(f => f.OrderDate).HasColumnName(@"OrderDate").IsRequired().HasColumnType("datetime");
            Property(f => f.OrderQuantity).HasColumnName(@"OrderQuantity").IsRequired().HasColumnType("int");
            Property(f => f.OrderStatus).HasColumnName(@"OrderStatus").IsRequired().HasColumnType("varchar").HasMaxLength(20);


            HasRequired(f => f.TileData)
                .WithMany()
                .HasForeignKey(rc => rc.ISBN);
            HasRequired(f => f.CustomerData)
                .WithMany()
                //.Map(mc =>
                //{
                //    mc.ToTable("CustomerData");
                //});
                .HasForeignKey(cd => cd.CustomerNumber);


        }


    }
}
