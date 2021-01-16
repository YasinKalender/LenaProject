using LenaProject.Entites.ORM.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LenaProject.Map.Option
{
    public class AppUserMapping : IEntityTypeConfiguration<AppUser>
    {
        public void Configure(EntityTypeBuilder<AppUser> builder)
        {
            builder.HasKey(i => i.Id);
         

            builder.HasMany(i => i.Forms).WithOne(i => i.AppUser).HasForeignKey(i => i.AppUserId);

        }
    }
}
