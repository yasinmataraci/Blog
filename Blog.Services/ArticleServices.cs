using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Blog.DAL.Repositories;
using Blog.Entities.Entity;

namespace Blog.Services
{
    public class ArticleServices : BaseServices<Article>
    {
        private readonly ArticleRepository _repository;
        public IQueryable<Article> GetArticleWithTags()
        {
            IQueryable<Article> articleWithTags = _repository.GetArticleWithTags();

            return articleWithTags;
        }
    }
}
