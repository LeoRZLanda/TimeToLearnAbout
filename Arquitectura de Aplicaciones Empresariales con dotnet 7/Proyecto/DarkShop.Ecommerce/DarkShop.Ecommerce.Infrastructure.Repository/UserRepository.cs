using Dapper;
using DarkShop.Ecommerce.Domain.Entity;
using DarkShop.Ecommerce.Infrastructure.Interface;
using DarkShop.Ecommerce.Transversal.Common;

namespace DarkShop.Ecommerce.Infrastructure.Repository
{
    public class UserRepository : IUserRepository
    {

        private readonly IConnectionFactory _connectionFactory;

        public UserRepository(IConnectionFactory connectionFactory) {
            _connectionFactory = connectionFactory;
        }

        public User Authenticate(string UserName, string password) {
            using (var connection = _connectionFactory.GetConnection) {
                var query = "UsersGetByUserAndPassword";
                var parameters = new DynamicParameters();
                parameters.Add("UserName", UserName);
                parameters.Add("Password", password);

                var user = connection.QuerySingle<User>(query, param: parameters, commandType: System.Data.CommandType.StoredProcedure);
                return user;
            }
        }
    }
}
