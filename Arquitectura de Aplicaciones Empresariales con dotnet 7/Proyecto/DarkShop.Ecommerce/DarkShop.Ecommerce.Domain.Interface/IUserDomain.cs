using DarkShop.Ecommerce.Domain.Entity;

namespace DarkShop.Ecommerce.Domain.Interface
{
    public interface IUserDomain
    {
        User Authenticate(string username, string password);
    }
}
