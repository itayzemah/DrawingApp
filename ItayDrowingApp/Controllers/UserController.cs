using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EntityAndBoundary.Boundary;
using ItayDrowingApp.Logic.ServicesContracts;
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
        // GET: api/<UserController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<UserController>/5
        [HttpPost("create")]
        public UserBoundary CreateUser([FromBody] NewUserBoundaey userRegister)
        {
            return _userService.CreateUser(userRegister);
        }

        // POST api/<UserController>
        [HttpPost]
        public UserBoundary Login([FromRoute] string userEmail)
        {
            return _userService.Login(userEmail);
        }

        // PUT api/<UserController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<UserController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
