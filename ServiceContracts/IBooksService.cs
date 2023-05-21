using ServiceContracts.DTO;
using ServiceContracts.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceContracts
{
    public interface IBooksService
    {
        /// <summary>
        /// Adds a new book to the library.
        /// </summary>
        /// <param name="bookRequest">The book details to add.</param>
        /// <returns>The added book details.</returns>
        BookResponse AddBook(BookAddRequest bookAddRequest);

        /// <summary>
        /// Retrieves a book by its ID.
        /// </summary>
        /// <param name="bookId">The ID of the book to retrieve.</param>
        /// <returns>The book details.</returns>
        BookResponse GetBookById(int bookId);

        /// <summary>
        /// Retrieves all books in the library.
        /// </summary>
        /// <returns>A collection of book details.</returns>
        IEnumerable<BookResponse> GetAllBooks();

        /// <summary>
        /// Deletes a book from the library.
        /// </summary>
        /// <param name="bookId">The ID of the book to delete.</param>
        BookResponse DeleteBook(int bookId);

        /// <summary>
        /// search for book ansed on field and then the fieldvalue
        /// </summary>
        /// <param name="field"></param>
        /// <param name="searchValue"></param>
        /// <returns></returns>
        BookResponse BookSearchBy(string field, string searchValue);
        List<BookResponse> GetSortedBook(List<BookResponse> allPersons, string sortBy, SortOrderOptions sortOrder);
        //UpdateBook(BookUpdateRequest bookUpdate)
        //GetBookByOtherFields  : for example GetBooksByAuthor(string authorName)

    }
}
