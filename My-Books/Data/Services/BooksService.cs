using My_Books.Data.ViewsModels;
using My_Books.Data.Models;
using My_Books;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace My_Books.Data.Services
{
    public class BooksService
    {
        private AppDbContext _Context;
        public BooksService(AppDbContext context)
        {
            _Context = context;
        }


        public void AddBook(BookVM book)
        {
            var _book = new Book()
            {
                Title = book.Title,
                Description = book.Description,
                IsRead = book.IsRead,
                DateRead = book.IsRead ? book.DateRead.Value : null,
                Rate = book.IsRead ? book.Rate.Value : null,
                Genre = book.Genre,
                Author = book.Author,
                CoverUrl = book.CoverUrl,
                DateAdded = DateTime.Now
            };
           _Context.Books.Add(_book);
            _Context.SaveChanges();
        }
    }
}
