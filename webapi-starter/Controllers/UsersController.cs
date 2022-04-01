
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using webapi_starter.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace webapi_starter.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsersController : ControllerBase
    {
        private static List<User> Users = new List<User>()
        {
            new User(0, "Jorn"),
            new User(3, "Markus"),
            new User(2, "Andrew"),
            new User(4, "Ori"),
            new User(1, "Mike")
        };

        [HttpGet]
        public IEnumerable<User> GetUsers()
        {
            return Users;
        }
    }
}
