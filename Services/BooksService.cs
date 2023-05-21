using ServiceContracts;
using ServiceContracts.DTO;
using ServiceContracts.Enums;

namespace Services
{
    public class BooksService : IBooksService
    {
        public BookResponse AddBook(BookAddRequest bookAddRequest)
        {
            throw new NotImplementedException();
        }

        BookResponse IBooksService.BookSearchBy(string field, string searchValue)
        {
            throw new NotImplementedException();
        }

        BookResponse IBooksService.DeleteBook(int bookId)
        {
            throw new NotImplementedException();
        }

        IEnumerable<BookResponse> IBooksService.GetAllBooks()
        {
            throw new NotImplementedException();
        }

        BookResponse IBooksService.GetBookById(int bookId)
        {
            throw new NotImplementedException();
        }

        List<BookResponse> IBooksService.GetSortedBook(List<BookResponse> allPersons, string sortBy, SortOrderOptions sortOrder)
        {
            throw new NotImplementedException();
        }
    }
}