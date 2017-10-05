using System;
using bookshelf.Services;
using bookshelf.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace bookshelf.Controllers
{
    public class BookController : Controller
    {
        private readonly IBookService bookService;

        public BookController(IBookService bookService)
        {
            this.bookService = bookService;
        }
        public IActionResult Index()
        {
            List<Book> books = bookService.GetAllBooks();
            return View(books);
        }

        [HttpGet]
        public IActionResult AddBook()
        {
            return View();
        }

        [HttpPost]
        public RedirectToActionResult AddBook(string title, string authorName, string authorSurname)
        {
            Author author = Author.Create(authorName, authorSurname);
            Book book = Book.Create(title, author);
            bookService.Add(book);
            return RedirectToAction("Index");
        }

        
    }
}