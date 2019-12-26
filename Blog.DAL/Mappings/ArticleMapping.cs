using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Blog.Entities.Entity;

namespace Blog.DAL.Mappings
{
    public class ArticleMapping : EntityTypeConfiguration<Article>
    {
        public ArticleMapping()
        {
            HasKey(x => x.Id);
            Property(x => x.Title).HasMaxLength(100).IsRequired();
            Property(x => x.Content).HasColumnType("text").IsRequired();
            Property(x => x.ImagePath).HasMaxLength(100).IsRequired();
            Property(x => x.CreatedDate).IsRequired();
            Property(x => x.UpdatedDate).IsOptional();
            Property(x => x.IsValid).IsRequired();
            HasMany(x => x.Tags).WithMany(x => x.Articles).Map(m =>
            {
                m.ToTable("Article_Tag");
                m.MapLeftKey("ArticleId");
                m.MapRightKey("TagId");
            });
        }
    }
}
