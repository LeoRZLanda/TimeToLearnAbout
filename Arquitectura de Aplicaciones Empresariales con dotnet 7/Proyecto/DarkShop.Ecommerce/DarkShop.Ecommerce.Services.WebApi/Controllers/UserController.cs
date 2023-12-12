using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DarkShop.Ecommerce.Application.DTO;
using DarkShop.Ecommerce.Application.Interface;
using DarkShop.Ecommerce.Services.WebApi.Helpers;
using DarkShop.Ecommerce.Transversal.Common;
using Microsoft.Extensions.Options;

namespace DarkShop.Ecommerce.Services.WebApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserApplication _userApplication;
        private readonly AppSettings _appSettings;

        public UserController(IUserApplication userApplication, IOptions<AppSettings> appSettings) {
            _userApplication = userApplication;
            _appSettings = appSettings.Value;
        }

        [HttpPost]
        public IActionResult Authenticate([FromBody]UserDTO authDTO)
    }
}
