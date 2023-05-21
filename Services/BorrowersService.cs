using ServiceContracts;
using ServiceContracts.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class BorrowersService : IBorrowersService
    {
        BorrowerResponse IBorrowersService.AddBorrower(BorrowerAddRequest borrowerRequest)
        {
            throw new NotImplementedException();
        }

        BorrowerResponse IBorrowersService.BorrowerSearchBy(string field, string searchValue)
        {
            throw new NotImplementedException();
        }

        BorrowerResponse IBorrowersService.DeleteBorrower(int borrowerId)
        {
            throw new NotImplementedException();
        }

        IEnumerable<BorrowerResponse> IBorrowersService.GetAllBorrowers()
        {
            throw new NotImplementedException();
        }

        IEnumerable<BorrowerResponse> IBorrowersService.GetBorrowedBooks(int borrowerId)
        {
            throw new NotImplementedException();
        }

        BorrowerResponse IBorrowersService.GetBorrowerById(int borrowerId)
        {
            throw new NotImplementedException();
        }
    }
}
