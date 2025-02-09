using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObjects
{
    public class AccountDAO
    {
        public static SystemAccount GetSystemAccountById(int accountId)
        {
            try
            {
                using var db = new FunewsManagementContext();
                return db.SystemAccounts.FirstOrDefault(a => a.AccountId == accountId);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return null;
            }
        }
    }
}
