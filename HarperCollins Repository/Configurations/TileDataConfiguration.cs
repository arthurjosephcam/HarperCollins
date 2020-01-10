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
    internal class TileDataConfiguration : EntityTypeConfiguration<TileData>
    {
        public TileDataConfiguration()
        {
            ToTable("TileData","dbo");
            HasKey(f => f.ISBN);

            Property(f => f.ISBN).HasColumnName(@"ISBN").IsRequired().HasColumnType("nvarchar").HasMaxLength(20);
            Property(f => f.Title).HasColumnName(@"Title").IsRequired().HasColumnType("ntext");
            Property(f => f.Author).HasColumnName(@"Author").IsRequired().HasColumnType("nvarchar").HasMaxLength(250);
            Property(f => f.Format).HasColumnName(@"Format").IsRequired().HasColumnType("nvarchar").HasMaxLength(100);
            Property(f => f.ListPrice).HasColumnName(@"ListPrice").IsRequired().HasColumnType("money");

        }
    }
}
