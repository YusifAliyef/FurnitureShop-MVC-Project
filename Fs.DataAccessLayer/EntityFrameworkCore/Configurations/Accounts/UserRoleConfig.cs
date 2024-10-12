﻿using Fs.Entity.Accounts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fs.DataAccessLayer.EntityFrameworkCore.Configurations.Accounts
{
    public class UserRoleConfig : IEntityTypeConfiguration<UserRole>
    {
        public void Configure(EntityTypeBuilder<UserRole> builder)
        {

            builder.HasKey(x => new { x.RoleId, x.UserId });

            builder.Ignore(x => x.Id);
        }
    }
}
