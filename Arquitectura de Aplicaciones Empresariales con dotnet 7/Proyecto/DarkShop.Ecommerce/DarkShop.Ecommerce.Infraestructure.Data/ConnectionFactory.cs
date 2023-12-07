using System;
using DarkShop.Ecommerce.Transversal.Common;
using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace DarkShop.Ecommerce.Infraestructure.Data
{
    public class ConnectionFactory :IConnectionFactory
    {
        private readonly IConfiguration _configuration;

        public ConnectionFactory(IConfiguration configuration) {
            _configuration = configuration;
        }

        public IDbConnection GetConnection{
            get {
                var SqlConnection = new SqlConnection();
                if (SqlConnection == null) return null;

                SqlConnection.ConnectionString = _configuration.GetConnectionString("NorthwindConnection");
                SqlConnection.Open();
                return SqlConnection;
            }
        }

    }
}
