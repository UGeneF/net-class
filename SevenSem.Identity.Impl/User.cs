using Microsoft.AspNetCore.Identity;

namespace SevenSem.Identity.Abstract
{
    internal class User : IdentityUser
    {
        public string Login { get; set; }
    }
}