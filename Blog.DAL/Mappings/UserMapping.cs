using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Blog.Entities.Entity;

namespace Blog.DAL.Mappings
{
    public class UserMapping : EntityTypeConfiguration<User>
    {
        public UserMapping()
        {
            HasKey(x => x.Id);
            Property(x => x.UserName).HasMaxLength(30).IsRequired();
            Property(x => x.Password).HasMaxLength(16).IsRequired();
            Property(x => x.CreatedDate).IsRequired();
            Property(x => x.UpdatedDate).IsOptional();
            Property(x => x.IsValid).IsRequired();
        }
    }
}
