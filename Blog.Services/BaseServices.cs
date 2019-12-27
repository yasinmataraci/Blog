using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Blog.DAL.Repositories;
using Blog.Entities.Entity;

namespace Blog.Services
{
    public class BaseServices<TEntity> where TEntity : BaseEntity, new()
    {
        private readonly BaseRepository<TEntity> _repository;

        public BaseServices()
        {
            _repository = new BaseRepository<TEntity>();
        }

        public void Add(TEntity entity)
        {
            _repository.Add(entity);
        }

        public List<TEntity> GetAll()
        {
            List<TEntity> list = _repository.GetAll();

            return list;
        }

        public TEntity Find(object id)
        {
            TEntity find = _repository.Find(id);

            return find;
        }

        public TEntity First(Expression<Func<TEntity, bool>> predicate)
        {
           TEntity first = _repository.First(predicate);

           return first;
        }

        public void Update(TEntity entity)
        {
            _repository.Update(entity);
        }

        public void Delete(TEntity entity)
        {
            _repository.Delete(entity);
        }
    }
}
