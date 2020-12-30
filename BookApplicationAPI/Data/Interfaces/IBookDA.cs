using BookApplicationAPI.Models;
using BookApplicationAPI.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookApplicationAPI.Data.Interfaces
{
    public interface IBookDA : IGenericRepository
    {
        public List<Book> GetBooks();
    }
}
