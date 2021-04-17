using SevenSem.Identity.Abstract;

namespace SevenSem.Rest.Service
{
    public interface IJwtService
    {
        string GetToken(Role[] roles);
    }
}