using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Blog.Entities.Entity;

namespace Blog.DAL.Mappings
{
    public class CategoryMapping :EntityTypeConfiguration<Category>
    {
        public CategoryMapping()
        {
            HasKey(x => x.Id);
            Property(x => x.Name).HasMaxLength(50).HasColumnType("nvarchar").IsRequired();
            Property(x => x.Description).HasMaxLength(250).IsRequired();
            Property(x => x.CreatedDate).IsRequired();
            Property(x => x.UpdatedDate).IsOptional();
            Property(x => x.IsValid).IsRequired();
        }
    }
}
