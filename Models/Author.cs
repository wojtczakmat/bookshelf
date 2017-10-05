using System;

namespace bookshelf.Models
{
    public class Author
    {
        public Guid AuthorId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        protected Author() {}
        public static Author Create(string name, string surname)
        {
            return new Author()
            {
                AuthorId =Guid.NewGuid(),
                Name = name,
                Surname = surname
            };
        }

        public override string ToString()
        {
            return Name + " " + Surname;
        }
    }
}