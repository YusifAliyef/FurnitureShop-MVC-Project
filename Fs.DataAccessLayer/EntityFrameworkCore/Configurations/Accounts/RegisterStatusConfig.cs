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
    public class RegisterStatusConfig:BaseEntityConfig<RegisterStatus>
    {
        public override void Configure(EntityTypeBuilder<RegisterStatus> builder)
        {
            base.Configure(builder);
            builder.Property(x => x.Value)
                .HasMaxLength(25)
                .HasColumnName("Value")
                .HasComment("For Registered Statuses");
        }
    }
}
