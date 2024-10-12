using Fs.DataAccessLayer.EntityFrameworkCore.Configurations.Commons;
using Fs.Entity.Accounts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fs.DataAccessLayer.EntityFrameworkCore.Configurations.Accounts
{
    public class RoleConfig:EditedBaseEntityConfig<Role>
    {
        public override void Configure(EntityTypeBuilder<Role> builder)
        {
            base.Configure(builder);
            builder.Property(x => x.Value)
               .HasColumnName("Value")
               .HasMaxLength(25);


            builder.HasData([
                new Role { Id = 1, Value = "Admin", CreatedId = 1, CreateDate = DateTime.UtcNow, UpdatedId = 1, UpdatedDate = DateTime.UtcNow }
                ]);

        }
    }
}
