using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookApplicationAPI.Repositories.Interfaces
{
    public interface IGenericRepository
    {
        List<T> GetAll<T>() where T : class;
        IQueryable<T> GetAllQueryable<T>() where T : class;
        T GetById<T>(int id) where T : class;
        void Insert<T>(T entity) where T : class;
        void Update<T>(T entity) where T : class;
        void Delete<T>(T entity) where T : class;
    }
}
