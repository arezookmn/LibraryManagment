using Entities;
using Microsoft.EntityFrameworkCore;
using ServiceContracts;
using ServiceContracts.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class LoansService : ILoansService
    {
        private readonly LibraryDbContext _dbContext;
        public LoansService(LibraryDbContext libraryDbContext)
        {
            _dbContext= libraryDbContext;
        }
        public Task<LoanResponse> BorrowBookAsync(int bookId, int borrowerId)
        {
            throw new NotImplementedException();
        }

        public Task<LoanResponse> ExtendLoanAsync(int loanId, int extensionDays)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<LoanResponse>> GetActiveLoansAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<LoanResponse> GetLoanByIdAsync(int loanId)
        {
            // Check if loanId is not null
            if (loanId == null)
                throw new ArgumentNullException(nameof(loanId));

            // Get matching loan from database
            Loan loan = await _dbContext.Loans.FirstOrDefaultAsync(l => l.ID == loanId);

            if (loan == null)
                return null;

            LoanResponse loanResponse = loan.ToLoanResponse();
            return loanResponse;
        }

        public Task<int> GetLoanDurationAsync(int loanId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<LoanResponse>> GetLoansByBookAsync(int bookId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<LoanResponse>> GetLoansByBorrowerAsync(int borrowerId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<LoanResponse>> GetOverdueLoansAsync()
        {
            throw new NotImplementedException();
        }

        public Task<int> GetTotalLoansCountAsync()
        {
            throw new NotImplementedException();
        }

        public Task<LoanResponse> ReturnBookAsync(int loanId)
        {
            throw new NotImplementedException();
        }
    }
}
