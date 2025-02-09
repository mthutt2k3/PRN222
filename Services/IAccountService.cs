using BusinessObjects;

namespace Services
{
    public interface IAccountService
    {
        SystemAccount GetSystemAccountById(int accountId);
    }
}
