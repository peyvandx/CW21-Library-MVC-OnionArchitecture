using App.Domain.Core.Book.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Services.Book
{
    public class BookService : IBookService
    {
        public void CreateBook(Core.Book.Entities.Book book)
        {
            throw new NotImplementedException();
        }

        public Core.Book.Entities.Book GetBookByCategoryId(int categoryId)
        {
            throw new NotImplementedException();
        }

        public Core.Book.Entities.Book GetBookById(int bookId)
        {
            throw new NotImplementedException();
        }

        public List<Core.Book.Entities.Book> GetBooks()
        {
            throw new NotImplementedException();
        }

        public void HardDeleteBook(int id)
        {
            throw new NotImplementedException();
        }

        public void SoftDeleteBook(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateBook(Core.Book.Entities.Book updatedBook)
        {
            throw new NotImplementedException();
        }
    }
}
