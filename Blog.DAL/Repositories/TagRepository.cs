using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Blog.Entities.Entity;

namespace Blog.DAL.Repositories
{
    public class TagRepository : BaseRepository<Tag>
    {
        public IQueryable<Tag> GetTagWithArticles()
        {
            IQueryable<Tag> tagWithArticles = _context.Tags.Include(x => x.Articles);

            return tagWithArticles;
        }
    }
}
