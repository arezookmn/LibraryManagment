using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceContracts.DTO
{
    /// <summary>
    /// DTO class that is used as return type for most of BooksService method
    /// </summary>
    public class BookResponse
    {
        public int ID { get; set; }

        [Display(Name = "Title")]
        public string Title { get; set; }

        [Display(Name = "Author")]
        public int AuthorID { get; set; }

        [Display(Name = "ISBN")]
        public string ISBN { get; set; }

        [Display(Name = "Publication Date")]
        public DateTime PublicationDate { get; set; }

        [Display(Name = "Number of Pages")]
        public int NumberOfPages { get; set; }

        [Display(Name = "Quantity")]
        public int Quantity { get; set; }
    }

    public static class BookExtentions
    {
        public static BookResponse BookToBookResponse(this Book book)
        {
            return new BookResponse
            {
                ID = book.ID,
                Title = book.Title,
                AuthorID = book.AuthorID,
                ISBN = book.ISBN,
                PublicationDate = (DateTime)book.PublicationDate,
                NumberOfPages = book.NumberOfPages,
                Quantity = book.Quantity,

            };
        }
    }
}
