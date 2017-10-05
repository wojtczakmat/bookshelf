using System;
using bookshelf.Models;
using System.Collections.Generic;

namespace bookshelf.Services
{
    public interface IBookService
    {
        void Add(Book book);
        List<Book> GetAllBooks();
    }
}
