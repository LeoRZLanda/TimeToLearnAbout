using System;
using DarkShop.Ecommerce.Domain.Entity;
using DarkShop.Ecommerce.Domain.Interface;
using DarkShop.Ecommerce.Infrastructure.Interface;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace DarkShop.Ecommerce.Domain.Core
{
    public class CustomersDomain : ICustomersDomain
    {
        private readonly ICustomersRepository _customersRepository;

        public CustomersDomain(ICustomersRepository CustomersRepository)
        {

            _customersRepository = CustomersRepository;

        }

        #region Métodos Síncronos

        public bool Insert(Customer customer){
            return _customersRepository.Insert(customer);
        }

        public bool Update(Customer customer)
        {
            return _customersRepository.Update(customer);
        }

        public bool Delete(string customerId)
        {
            return _customersRepository.Delete(customerId);
        }

        public Customer Get(string customerId)
        {
            return _customersRepository.Get(customerId);
        }

        public IEnumerable<Customer> GetAll()
        {
            return _customersRepository.GetAll();
        }


        #endregion

        #region Métodos Asincronos

        public async Task<bool> InsertAsync(Customer customer)
        {
            return await  _customersRepository.InsertAsync(customer);
        }

        public async Task<bool> UpdateAsync(Customer customer)
        {
            return await _customersRepository.UpdateAsync(customer);
        }

        public async Task<bool> DeleteAsync(string customerId)
        {
            return await _customersRepository.DeleteAsync(customerId);
        }

        public async Task<Customer> GetAsync(string customerId)
        {
            return await _customersRepository.GetAsync(customerId);
        }

        public async Task<IEnumerable<Customer>> GetAllAsync()
        {
            return await _customersRepository.GetAllAsync();
        }

        #endregion
    }
}
