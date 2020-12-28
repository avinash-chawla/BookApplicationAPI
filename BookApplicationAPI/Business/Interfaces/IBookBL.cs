using BookApplicationAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookApplicationAPI.Business.Interfaces
{
    public interface IBookBL
    {
        public List<Book> GetBooks();
        public Book GetBookByID(int id);
        public void InsertBook(Book book);
        public void UpdateBook(Book book, int id);
        public void DeleteBook(int id);
    }
}
