using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AppContracts;
using AppContracts.DTO.Login;
using AppContracts.DTO.Register;
using EntityAndBoundary.Boundary;
using ItayDrowingApp.AppContracts;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ItayDrowingApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        // GET api/User/create
        [HttpPost("create")]
        public Response CreateUser([FromBody] RegisterRequest request)
        {
            return _userService.CreateUser(request);
        }

        // GET: api/User/login
        [HttpPost("login")]
        public Response Login([FromBody] LoginRequest request)
        {
            return _userService.Login(request);
        }


        // GET api/<UserController>/unsubsribe
        [HttpPost("unsubsribe")]
        public UserBoundary RemoveUser([FromRoute] string userEmail)
        {
            return _userService.Unsubscribe(userEmail);
        }


    }
}
