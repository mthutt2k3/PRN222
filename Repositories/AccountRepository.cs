using BusinessObjects;
using DataAccessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class AccountRepository : IAccountRepository
    {
        public SystemAccount GetSystemAccountById(int accountId) => AccountDAO.GetSystemAccountById(accountId);
    }
}
