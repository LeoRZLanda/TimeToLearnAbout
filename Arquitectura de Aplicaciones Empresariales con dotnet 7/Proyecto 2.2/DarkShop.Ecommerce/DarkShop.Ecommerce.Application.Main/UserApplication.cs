using DarkShop.Ecommerce.Application.Interface;
using DarkShop.Ecommerce.Application.DTO;
using DarkShop.Ecommerce.Domain.Interface;
using DarkShop.Ecommerce.Transversal.Common;
using AutoMapper;
using System;

namespace DarkShop.Ecommerce.Application.Main
{
    public class UserApplication : IUserApplication
    {

        private readonly IUserDomain _userDomain;
        private readonly IMapper _mapper;

        public UserApplication(IUserDomain userDomain, IMapper IMapper)
        {
            _userDomain = userDomain;
            _mapper = IMapper;
        }

        public Response<UserDTO> Authenticate(string username, string password) {
            var response = new Response<UserDTO>();
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                response.Message = "Parámetros no pueden ser vacios.";
                return response;
            }
            try
            {
                var user = _userDomain.Authenticate(username, password);
                response.Data = _mapper.Map<UserDTO>(user);
                response.IsSuccess = true;
                response.Message = "Autenticación exitosa!!!";
            }
            catch (InvalidOperationException) {
                response.IsSuccess = true;
                response.Message = "Usuario no existe";
            }
            catch (Exception e)
            {
                response.Message = e.Message;
            }
            return response;
        }

    }
}
