using System;
using stockExchange.API.Models;
namespace stockExchange.API.Interfaces
{
    public interface ITokenService
    {
        string CreateToken(User user);

    }
}

