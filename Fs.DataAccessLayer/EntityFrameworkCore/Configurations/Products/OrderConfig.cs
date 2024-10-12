using Fs.DataAccessLayer.EntityFrameworkCore.Configurations.Commons;
using Fs.Entity.Products;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fs.DataAccessLayer.EntityFrameworkCore.Configurations.Products
{
    public  class OrderConfig:BaseEntityConfig<Order>
    {
        public override void Configure(EntityTypeBuilder<Order> builder)
        {
            base.Configure(builder);
            builder.Property(x => x.TotalPrice)
               .IsRequired();
            builder.Property(x => x.Quantity)
                .IsRequired();
            builder.HasOne(x => x.Customer)
                .WithMany(x => x.Orders)
                .HasForeignKey(x => x.CustomerId);
            builder.HasMany(x => x.ProductOrders)
              .WithOne(x => x.Order)
              .HasForeignKey(x => x.OrderId);
        }
    }
}
