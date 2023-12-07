using System;
using DarkShop.Ecommerce.Domain.Entity;
using DarkShop.Ecommerce.Infrastructure.Interface;
using DarkShop.Ecommerce.Transversal.Common;
using Dapper;
using System.Data;
using System.Threading.Tasks;

namespace DarkShop.Ecommerce.Infrastructure.Repository
{
    public class CustomersRepository : ICostumersRepository
    {
        private readonly IConnectionFactory _connectionFactory;
        public CustomersRepository(IConnectionFactory connectionFactory) {
            _connectionFactory = connectionFactory;
        }

        #region Métodos Síncronos

        public bool Insert(Customers customers) {
            using (var connection = _connectionFactory.GetConnection) {
                var query = "CustomersInsert";
                var parameters = new DynamicParameters();
                parameters.Add("CustomerID", customers.CustomerId);
                parameters.Add("CompanyName", customers.CompanyName);
                parameters.Add("ContactName", customers.ContactName);
                parameters.Add("ContactTitle", customers.ContactTitle);
                parameters.Add("Address",customers.Address);
                parameters.Add("City",customers.City);
                parameters.Add("PostalCode", customers.PostalCode);
                parameters.Add("Country", customers.Country);
                parameters.Add("Phone", customers.Country);
                parameters.Add("Fax", customers.Country);
            }
        }
    }
}
