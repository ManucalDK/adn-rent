using AdnRenting.Application.Interfaces;
using AdnRenting.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdnRenting.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private IUserService userService;

        public UserController(IUserService userService)
        {
            this.userService = userService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<User>>> GetUserListAsync()
        {
            var items = await userService.GetUserList();
            return Ok(items);
        }
        [HttpPost]
        public async Task<ActionResult<User>> PostUser(string name)
        {
            var user = await userService.PostUser(name);
            return Ok(user);
        }
    }
}
