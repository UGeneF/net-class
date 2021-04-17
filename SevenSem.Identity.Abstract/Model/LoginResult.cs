namespace SevenSem.Identity.Abstract
{
    public class LoginResult
    {
        public bool Succeeded { get; set; }
        public Role[] Roles { get; set; }
    }
}