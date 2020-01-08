using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;
using HarperCollins.Repository.Models;

namespace HarperCollins.Repository.Configurations
{
    internal class CustomerDataConfiguration : EntityTypeConfiguration<CustomerData>
    {
        public CustomerDataConfiguration()
        {
            ToTable("CustomerData");
            HasKey(f => f.CustomerNumber);

            Property(f => f.CustomerNumber).HasColumnName(@"CustomerNumber").IsRequired().HasColumnType("int");//.HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(f => f.CustomerName).HasColumnName(@"CustomerName").IsRequired().HasColumnType("nvarchar").HasMaxLength(250);
            Property(f => f.AddressLine1).HasColumnName(@"AddressLine1").IsRequired().HasColumnType("ntext");
            Property(f => f.AddressLine2).HasColumnName(@"AddressLine2").HasColumnType("ntext");
            Property(f => f.AddressLine3).HasColumnName(@"AddressLine3").HasColumnType("ntext");

        }
    }
}
