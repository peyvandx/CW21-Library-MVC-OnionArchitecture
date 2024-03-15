using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookEntities = App.Domain.Core.Book.Entities;

namespace App.Domain.Core.Book.Services
{
    public interface IBookService
    {
        public void CreateBook(BookEntities.Book book);
        public List<BookEntities.Book> GetBooks();
        public BookEntities.Book GetBookById(int bookId);
        public BookEntities.Book GetBookByCategoryId(int categoryId);
        public void UpdateBook(BookEntities.Book updatedBook);
        public void SoftDeleteBook(int id);
        public void HardDeleteBook(int id);
    }
}
