using ServiceContracts.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceContracts
{
    public interface IBorrowersService
    {
        /// <summary>
        /// Adds a new borrower to the library.
        /// </summary>
        /// <param name="borrowerRequest">The borrower details to add.</param>
        /// <returns>The added borrower details.</returns>
        BorrowerResponse AddBorrower(BorrowerAddRequest borrowerRequest);
        /// <summary>
        /// Retrieves a borrower by their ID.
        /// </summary>
        /// <param name="borrowerId">The ID of the borrower to retrieve.</param>
        /// <returns>The borrower details.</returns>
        BorrowerResponse GetBorrowerById(int borrowerId);
        /// <summary>
        /// Retrieves all borrowers in the library.
        /// </summary>
        /// <returns>A collection of borrower details.</returns>
        IEnumerable<BorrowerResponse> GetAllBorrowers();
        //BorrowerResponse UpdateBorrower(int borrowerId, BorrowerUpdateRequest borrowerRequest);


        /// <summary>
        /// Deletes a borrower from the library.
        /// </summary>
        /// <param name="borrowerId">The ID of the borrower to delete.</param>
        BorrowerResponse DeleteBorrower(int borrowerId);

        BorrowerResponse BorrowerSearchBy(string field, string searchValue);

        /// <summary>
        /// Retrieves all books currently borrowed by a specific borrower.
        /// </summary>
        /// <param name="borrowerId">The ID of the borrower.</param>
        /// <returns>A collection of borrowed books.</returns>
        IEnumerable<BorrowerResponse> GetBorrowedBooks(int borrowerId);
    }
}
