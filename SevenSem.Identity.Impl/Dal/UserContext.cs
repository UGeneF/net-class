using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SevenSem.Identity.Abstract;

namespace SevenSem.Identity.Impl.Dal
{
    internal class UserContext : IdentityDbContext<IdentityUser>
    {
        public UserContext(DbContextOptions<UserContext> options) : base(options){}
    }
}