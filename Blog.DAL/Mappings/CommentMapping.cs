using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Blog.Entities.Entity;

namespace Blog.DAL.Mappings
{
    public class CommentMapping : EntityTypeConfiguration<Comment>
    {
        public CommentMapping()
        {
            HasKey(x => x.Id);
            Property(x => x.Description).HasMaxLength(500).IsRequired();
            Property(x => x.FullName).HasMaxLength(100).IsRequired();
            Property(x => x.Email).HasMaxLength(50).IsOptional();
            Property(x => x.CreatedDate).IsRequired();
            Property(x => x.UpdatedDate).IsOptional();
            Property(x => x.IsValid).IsRequired();
        }
    }
}
