using System;
using bookshelf.Models;
using bookshelf.Database;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace bookshelf.Services
{
    public class BookService : IBookService
    {
        private readonly BookshelfContext dbContext;
        public BookService(BookshelfContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public void Add(Book book)
        {
            dbContext.Add(book);
            dbContext.SaveChanges();
        }
        public List<Book> GetAllBooks()
        {
            List<Book> books = new List<Book>();
            foreach(Book book in dbContext.Books)
                books.Add(book);
            return books;
        }
        
    }
}