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
            return this.bookDA.GetAll<Book>().ToList();
        }
        public Book GetBookByID(int id)
        {
            return this.bookDA.GetById<Book>(id);
        }
        public void InsertBook(Book book)
        {
            this.bookDA.Insert<Book>(book);
        }

        public void UpdateBook(Book book, int id)
        {
            book.ID = id;
            this.bookDA.Update<Book>(book);
        }
        public void DeleteBook(int id)
        {
            var book = this.bookDA.GetById<Book>(id);
            this.bookDA.Delete<Book>(book);
        }
    }
}
