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
    public class CustomerConfig:EditedBaseEntityConfig<Customer>
    {
        public override void Configure(EntityTypeBuilder<Customer> builder)
        {
            base.Configure(builder);
            builder.Property(x => x.FirstName)
               .HasColumnType("nvarchar(30)")
               .IsRequired();
            builder.Property(x => x.LastName)
                .HasColumnType("nvarchar(50)")
                .IsRequired();
            builder.Property(x => x.Address)
                .HasColumnType("nvarchar(250)")
                .IsRequired();
            builder.Property(x => x.PhoneNumber)
                .IsRequired();
        }
    }
}
