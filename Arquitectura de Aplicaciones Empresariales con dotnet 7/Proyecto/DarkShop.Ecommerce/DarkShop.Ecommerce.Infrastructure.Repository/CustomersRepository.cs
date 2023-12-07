using System;
using DarkShop.Ecommerce.Domain.Entity;
using DarkShop.Ecommerce.Infrastructure.Interface;
using DarkShop.Ecommerce.Transversal.Common;
using Dapper;
using System.Data;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace DarkShop.Ecommerce.Infrastructure.Repository
{
    public class CustomersRepository : ICostumersRepository
    {
        private readonly IConnectionFactory _connectionFactory;
        public CustomersRepository(IConnectionFactory connectionFactory) {
            _connectionFactory = connectionFactory;
        }

        #region Métodos Síncronos

        public bool Insert(Customer customer) {
            using (var connection = _connectionFactory.GetConnection) {
                var query = "CustomersInsert";
                var parameters = new DynamicParameters();
                parameters.Add("CustomerID", customer.CustomerId);
                parameters.Add("CompanyName", customer.CompanyName);
                parameters.Add("ContactName", customer.ContactName);
                parameters.Add("ContactTitle", customer.ContactTitle);
                parameters.Add("Address",customer.Address);
                parameters.Add("City",customer.City);
                parameters.Add("PostalCode", customer.PostalCode);
                parameters.Add("Country", customer.Country);
                parameters.Add("Phone", customer.Phone);
                parameters.Add("Fax", customer.Fax);

                var result = connection.Execute(query, param: parameters, commandType: CommandType.StoredProcedure);

                return result > 0;
            } 
        }

        public bool Update(Customer customer)
        {
            using (var connection = _connectionFactory.GetConnection)
            {
                var query = "CustomersUpdate";
                var parameters = new DynamicParameters();
                parameters.Add("CustomerID", customer.CustomerId);
                parameters.Add("CompanyName", customer.CompanyName);
                parameters.Add("ContactName", customer.ContactName);
                parameters.Add("ContactTitle", customer.ContactTitle);
                parameters.Add("Address", customer.Address);
                parameters.Add("City", customer.City);
                parameters.Add("PostalCode", customer.PostalCode);
                parameters.Add("Country", customer.Country);
                parameters.Add("Phone", customer.Phone);
                parameters.Add("Fax", customer.Fax);

                var result = connection.Execute(query, param: parameters, commandType: CommandType.StoredProcedure);

                return result > 0;
            }
        }

        public bool Delete(string CustomerId)
        {
            using (var connection = _connectionFactory.GetConnection)
            {
                var query = "CustomersDelete";
                var parameters = new DynamicParameters();
                parameters.Add("CustomerID", CustomerId);

                var result = connection.Execute(query, param: parameters, commandType: CommandType.StoredProcedure);

                return result > 0;
            }
        }

        public Customer Get(string CustomerId)
        {
            using (var connection = _connectionFactory.GetConnection)
            {
                var query = "CustomersGetById";
                var parameters = new DynamicParameters();
                parameters.Add("CustomerID", CustomerId);

                var customer = connection.QuerySingle<Customer>(query, param: parameters, commandType: CommandType.StoredProcedure);

                return customer;
            }
        }

        public IEnumerable<Customer> GetAll()
        {
            using (var connection = _connectionFactory.GetConnection)
            {
                var query = "CustomersGetById";

                var customers = connection.Query<Customer>(query, commandType: CommandType.StoredProcedure);

                return customers;
            }
        }

        #endregion

        #region Métodos Asincronos

        public async Task<bool> InsertAsync(Customer customer)
        {
            using (var connection = _connectionFactory.GetConnection)
            {
                var query = "CustomersInsert";
                var parameters = new DynamicParameters();
                parameters.Add("CustomerID", customer.CustomerId);
                parameters.Add("CompanyName", customer.CompanyName);
                parameters.Add("ContactName", customer.ContactName);
                parameters.Add("ContactTitle", customer.ContactTitle);
                parameters.Add("Address", customer.Address);
                parameters.Add("City", customer.City);
                parameters.Add("PostalCode", customer.PostalCode);
                parameters.Add("Country", customer.Country);
                parameters.Add("Phone", customer.Phone);
                parameters.Add("Fax", customer.Fax);

                var result = await connection.ExecuteAsync(query, param: parameters, commandType: CommandType.StoredProcedure);

                return result > 0;
            }
        }

        public async Task<bool> UpdateAsync(Customer customer)
        {
            using (var connection = _connectionFactory.GetConnection)
            {
                var query = "CustomersUpdate";
                var parameters = new DynamicParameters();
                parameters.Add("CustomerID", customer.CustomerId);
                parameters.Add("CompanyName", customer.CompanyName);
                parameters.Add("ContactName", customer.ContactName);
                parameters.Add("ContactTitle", customer.ContactTitle);
                parameters.Add("Address", customer.Address);
                parameters.Add("City", customer.City);
                parameters.Add("PostalCode", customer.PostalCode);
                parameters.Add("Country", customer.Country);
                parameters.Add("Phone", customer.Phone);
                parameters.Add("Fax", customer.Fax);

                var result = await connection.ExecuteAsync(query, param: parameters, commandType: CommandType.StoredProcedure);

                return result > 0;
            }
        }

        public async Task<bool> DeleteAsync(string CustomerId)
        {
            using (var connection = _connectionFactory.GetConnection)
            {
                var query = "CustomersDelete";
                var parameters = new DynamicParameters();
                parameters.Add("CustomerID", CustomerId);

                var result = await connection.ExecuteAsync (query, param: parameters, commandType: CommandType.StoredProcedure);

                return result > 0;
            }
        }

        public async Task<Customer> GetAsync(string CustomerId)
        {
            using (var connection = _connectionFactory.GetConnection)
            {
                var query = "CustomersGetById";
                var parameters = new DynamicParameters();
                parameters.Add("CustomerID", CustomerId);

                var customer = await connection.QuerySingleAsync<Customer>(query, param: parameters, commandType: CommandType.StoredProcedure);

                return customer;
            }
        }

        public async Task<IEnumerable<Customer>> GetAllAsync()
        {
            using (var connection = _connectionFactory.GetConnection)
            {
                var query = "CustomersGetById";

                var customers = await connection.QueryAsync<Customer>(query, commandType: CommandType.StoredProcedure);

                return customers;
            }
        }

        #endregion
    }
}
