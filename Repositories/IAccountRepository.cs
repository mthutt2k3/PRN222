using BusinessObjects;

namespace Repositories
{
    public interface IAccountRepository
    {
        SystemAccount GetSystemAccountById(int accountId);

        SystemAccount GetSystemAccountByEmail(String email);
    }
}
