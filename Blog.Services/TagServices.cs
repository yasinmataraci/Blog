using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Blog.DAL.Repositories;
using Blog.Entities.Entity;

namespace Blog.Services
{
    public class TagServices : BaseRepository<Tag>
    {
        private readonly TagRepository _repository;
        public IQueryable<Tag> GetTagWithArticles()
        {
            IQueryable<Tag> tagWithArticles = _repository.GetTagWithArticles();

            return tagWithArticles;
        }
    }
}
