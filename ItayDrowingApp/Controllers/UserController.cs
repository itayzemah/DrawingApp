using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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

        // GET api/<UserController>/create
        [HttpPost("create")]
        public UserBoundary CreateUser([FromBody] NewUserBoundaey userRegister)
        {
            return _userService.CreateUser(userRegister);
        }

        // GET: api/<UserController>
        [HttpGet("{userEmail}")]
        public UserBoundary Login([FromRoute] string userEmail)
        {
            return _userService.Login(userEmail);
        }


        // GET api/<UserController>/unsubsribe
        [HttpPost("unsubsribe")]
        public UserBoundary RemoveUser([FromRoute] string userEmail)
        {
            return _userService.Unsubscribe(userEmail);
        }


    }
}
