using DarkShop.Ecommerce.Application.DTO;
using DarkShop.Ecommerce.Transversal.Common;

namespace DarkShop.Ecommerce.Application.Interface
{
    public interface IUserApplication
    {
        Response<UserDTO> Authenticate(string username, string password);
    }
}
