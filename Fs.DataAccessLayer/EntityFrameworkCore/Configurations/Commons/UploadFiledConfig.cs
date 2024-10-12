using Fs.Entity.Commons;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fs.DataAccessLayer.EntityFrameworkCore.Configurations.Commons
{
    public class UploadFiledConfig:EditedBaseEntityConfig<UploadedFile>
    {
        public override void Configure(EntityTypeBuilder<UploadedFile> builder)
        {
            base.Configure(builder);

            builder.Property(x => x.ContentType).HasMaxLength(50);
            builder.Property(x => x.RelativePath).HasMaxLength(200);
            builder.Property(x => x.FileName).HasMaxLength(50);

        }
    }
}
