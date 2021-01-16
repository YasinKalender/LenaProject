using LenaProject.Entites.ORM.Entities.Concrete;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LenaProject.Map.Option
{
    public class FormsMapping:BaseMapping<Forms>
    {

        public override void Configure(EntityTypeBuilder<Forms> builder)
        {

            builder.Property(i => i.FormName).IsRequired();
            builder.Property(i => i.FormDescription).IsRequired();

            builder.HasOne(i => i.AppUser).WithMany(i => i.Forms).HasForeignKey(i => i.AppUserId);
            base.Configure(builder);
        }
    }
}
