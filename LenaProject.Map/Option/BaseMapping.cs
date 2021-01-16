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
    public class BaseMapping<T> : IEntityTypeConfiguration<T> where T : BaseEntity
    {
        public virtual void Configure(EntityTypeBuilder<T> builder)
        {
            builder.HasKey(i => i.ID);
            builder.Property(i => i.AddDate).HasColumnName("AddDate").IsRequired();
            builder.Property(i => i.CreatedUser).HasColumnName("CreatedUser").IsRequired();
            builder.Property(i => i.Status).HasColumnName("Status").IsRequired();
        }
    }
}
