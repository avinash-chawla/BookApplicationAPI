using BookApplicationAPI.Data;
using BookApplicationAPI.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookApplicationAPI.Repositories.Managers
{
    public class GenericRepository : IGenericRepository
    {
        private DataContext _context;
        public void Init(DataContext context)
        {
            this._context = context;
        }

        public List<T> GetAll<T>() where T : class
        {
            return _context.Set<T>().ToList();
        }

        public IQueryable<T> GetAllQueryable<T>() where T : class
        {
            return _context.Set<T>();
        }

        public T GetById<T>(int id) where T : class
        {
            return _context.Find<T>(id);
        }

        public void Insert<T>(T entity) where T : class
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            _context.Add(entity);
            _context.SaveChanges();
        }
        public void Update<T>(T entity) where T : class
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            _context.SaveChanges();
        }
        public void Delete<T>(T entity) where T : class
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            _context.Remove(entity);
            _context.SaveChanges();
        }
    }
}
