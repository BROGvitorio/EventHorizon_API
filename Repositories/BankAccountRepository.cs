using EventHorizon_API.Models;
using EventHorizon_API.Data;
using EventHorizon_API.Models.BankAccounts;
using Microsoft.EntityFrameworkCore;

namespace EventHorizon_API.Repositories
{
    //conexão

    public class BankAccountRepository : IBankAccountRepository
    {
        private readonly AppDbContext _context;

        public BankAccountRepository (AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<BankAccount>> ListBankAccounts ()
        {
            return await _context.BankAccounts.ToListAsync();
        }

        public async Task AddAccount (BankAccount newAccount)
        {
            await _context.BankAccounts.AddAsync(newAccount);
            await _context.SaveChangesAsync();
        }
    }
}
