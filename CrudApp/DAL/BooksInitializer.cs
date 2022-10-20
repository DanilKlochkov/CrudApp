using CrudApp.Models;
using System.Collections.Generic;

namespace CrudApp.DAL
{
    public class BooksInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<BooksContext>
    {
        protected override void Seed(BooksContext context)
        {
            var authors = new List<Author>
            {
                new Author{Name="Jorj Oruel", Country="UK"},
                new Author{Name="Fyodor Dostoevsky", Country="Russia"},
                new Author{Name="German Gesse", Country="Germany"}
            };

            authors.ForEach(a => context.Authors.Add(a));
            context.SaveChanges();

            var books = new List<Book>
            {
                new Book{Title="1984", Year=1949, AuthorID=1},
                new Book{Title="Сrime and punishment", Year=1866, AuthorID=2},
                new Book{Title="Demons", Year=1871, AuthorID=2},
                new Book{Title="Siddhartha", Year=1922, AuthorID=3},
                new Book{Title="Demian", Year=1919, AuthorID=3},
            };

            books.ForEach(b => context.Books.Add(b));
            context.SaveChanges();
        }
    }
}