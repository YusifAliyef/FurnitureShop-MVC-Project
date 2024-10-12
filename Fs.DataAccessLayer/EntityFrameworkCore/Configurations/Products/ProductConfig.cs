using Fs.DataAccessLayer.EntityFrameworkCore.Configurations.Commons;
using Fs.Entity.Products;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fs.DataAccessLayer.EntityFrameworkCore.Configurations.Products
{
    public class ProductConfig:EditedBaseEntityConfig<Product>
    {
        public override void Configure(EntityTypeBuilder<Product> builder)
        {
            base.Configure(builder);
            builder.Property(x => x.ProductName)
                .HasColumnType("nvarchar(50)")
                .IsRequired();
            builder.Property(x => x.Price)
                .IsRequired();
            builder.HasOne(x => x.Category)
                .WithMany()
                .HasForeignKey(x => x.CategoryId);
            builder.HasMany(x => x.ProductOrders)
                .WithOne(x => x.Product)
                .HasForeignKey(x => x.ProductId);
            builder.HasMany(x => x.UploadedFiles)
                .WithOne()
                .HasForeignKey(x => x.ProductId);

        }
    }
}
