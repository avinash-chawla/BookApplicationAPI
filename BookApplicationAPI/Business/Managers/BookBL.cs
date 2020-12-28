using BookApplicationAPI.Business.Interfaces;
using BookApplicationAPI.Data.Interfaces;
using BookApplicationAPI.Models;
using BookApplicationAPI.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookApplicationAPI.Business.Managers
{
    public class BookBL : IBookBL
    {
        private readonly IBookDA bookDA;

        public BookBL(IBookDA bookDA)
        {
            this.bookDA = bookDA;
        }
        public List<Book> GetBooks()
        {
            return this.bookDA.GetBooks();
        }
        public Book GetBookByID(int id)
        {
            throw new NotImplementedException();
        }
        public void InsertBook(Book book)
        {
            throw new NotImplementedException();
        }

        public void UpdateBook(Book book, int id)
        {
            throw new NotImplementedException();
        }
        public void DeleteBook(int id)
        {
            throw new NotImplementedException();
        }
    }
}
