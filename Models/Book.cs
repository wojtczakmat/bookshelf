using System;

namespace bookshelf.Models
{
    public class Book
    {
        public Guid BookId { get; set; }
        public string Title { get; set; }
        public Author Author { get; set; } 
        protected Book()  {}
        public static Book Create(string title, Author author)
        {
            return new Book()
            {
                BookId = Guid.NewGuid(),
                Title = title,
                Author = author
            };
        }
    }
}