using System.Data;

namespace DarkShop.Ecommerce.Transversal.Common
{
    public interface IConnectionFactory
    {
        IDbConnection GetConnection { get; }
    }
}
