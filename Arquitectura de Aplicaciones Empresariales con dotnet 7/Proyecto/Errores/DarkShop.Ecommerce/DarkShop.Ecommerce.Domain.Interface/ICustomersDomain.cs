﻿using System;
using System.Collections.Generic;
using System.Text;
using DarkShop.Ecommerce.Domain.Entity;
using System.Threading.Tasks;

namespace DarkShop.Ecommerce.Domain.Interface
{
    public interface ICustomersDomain
    {
        #region Métodos Sincronos
        bool Insert(Customer customer);
        bool Update(Customer customer);
        bool Delete(string customerId);
        Customer Get(string customerId);
        IEnumerable<Customer> GetAll();
        #endregion

        #region Métodos Asincronos
        Task<bool> InsertAsync(Customer customer);
        Task<bool> UpdateAsync(Customer customer);
        Task<bool> DeleteAsync(string customerId);
        Task<Customer> GetAsync(string customerId);
        Task<IEnumerable<Customer>> GetAllAsync();
        #endregion
    }
}
