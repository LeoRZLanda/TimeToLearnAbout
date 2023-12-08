using System;
using System.Collections.Generic;
using System.Text;
using DarkShop.Ecommerce.Aplication.DTO;
using DarkShop.Ecommerce.Transversal.Common;
using System.Threading.Tasks;

namespace DarkShop.Ecommerce.Aplication.Interface
{
    public interface ICustomersApplication
    {
        #region Métodos Sincronos
        Response<bool> Insert(CustomerDTO customerDTO);
        Response<bool> Update(CustomerDTO customerDTO);
        Response<bool> Delete(string customerId);
        Response<CustomerDTO> Get(string customerId);
        Response<IEnumerable<CustomerDTO>> GetAll();
        #endregion

        #region Métodos Asincronos
        Task<Response<bool>> InsertAsync(CustomerDTO customerDTO);
        Task<Response<bool>> UpdateAsync(CustomerDTO customerDTO);
        Task<Response<bool>> DeleteAsync(string customerId);
        Task<Response<CustomerDTO>> GetAsync(string customerId);
        Task<Response<IEnumerable<CustomerDTO>>> GetAllAsync();
        #endregion
    }
}
