using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Blog.Entities.Entity;

namespace Blog.DAL.Repositories
{
    public class ArticleRepository : BaseRepository<Article>
    {
        public IQueryable<Article> GetArticleWithTags()
        {
            IQueryable<Article> articleWithTags = _context.Articles.Include(x => x.Tags);

            return articleWithTags;
        }
    }
}
