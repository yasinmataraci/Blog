using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Blog.DAL.Database;
using Blog.Entities.Entity;

namespace Blog.DAL.Repositories
{
    public class BaseRepository<TEntity> where TEntity : BaseEntity, new()
    {
        protected readonly BlogContext _context;

        public BaseRepository()
        {
            _context = new BlogContext();
        }

        public TEntity Add(TEntity entity)
        {
            TEntity add = _context.Set<TEntity>().Add(entity);
            _context.SaveChanges();

            return add;
        }

        public List<TEntity> GetAll()
        {
            List<TEntity> getAll = _context.Set<TEntity>().ToList();

            return getAll;
        }

        public TEntity Find(object id)
        {
            TEntity find = _context.Set<TEntity>().Find(id);

            return find;
        }

        public TEntity First(Expression<Func<TEntity, bool>> predicate)
        {
            TEntity first = _context.Set<TEntity>().FirstOrDefault(predicate);

            return first;
        }

        public void Update(TEntity entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void Delete(TEntity entity)
        {
            _context.Set<TEntity>().Remove(entity);
            _context.SaveChanges();
        }
    }
}
