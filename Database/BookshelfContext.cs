using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using bookshelf.Models;

namespace bookshelf.Database
{
    public class BookshelfContext : DbContext
    {
        public BookshelfContext(DbContextOptions<BookshelfContext> options) : base(options)
        {}
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }


    }
}