using System.Data;
using jellybeans.Models;
using Dapper;

namespace jellybeans.Repositories
{
    public class AccountsRepository
    {
        private readonly IDbConnection _db;

        public AccountsRepository(IDbConnection db)
        {
            _db = db;
        }

        
    }
}
