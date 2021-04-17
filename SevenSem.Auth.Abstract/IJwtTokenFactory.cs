using System;
using Microsoft.IdentityModel.Tokens;

namespace SevenSem.Auth.Impl
{
    public interface IJwtTokenFactory
    {
        string Get(string[] roles, TimeSpan expiry, TokenValidationParameters tokenParams);
    }
}