using System;
using System.Collections.Generic;
using System.Text;
using DarkShop.Ecommerce.Domain.Entity;

namespace DarkShop.Ecommerce.Infrastructure.Interface
{
    public interface IUserRepository
    {
        User Authenticate(string username, string password);
    }
}
