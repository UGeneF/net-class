using System.Threading.Tasks;

namespace SevenSem.Identity.Abstract
{
    public interface IIdentityService
    {
        Task CreateAsync(Creds creds, Role[] roles);
        Task<LoginResult> SingInAsync(Creds creds);
    }
}