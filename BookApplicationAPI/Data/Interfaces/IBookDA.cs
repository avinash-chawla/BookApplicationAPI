using BookApplicationAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookApplicationAPI.Data.Interfaces
{
    public interface IBookDA
    {
        public List<Book> GetBooks();
    }
}
