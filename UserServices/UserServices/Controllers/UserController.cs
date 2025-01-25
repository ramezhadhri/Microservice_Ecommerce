using Microsoft.AspNetCore.Mvc;
using UserServices.Services;
using UserServices.Models;

namespace UserServices.Controllers
{
    [Route("Api/[Controller]")]
    [ApiController]
    public class UserController:ControllerBase
    {
        private readonly IUserService UserService;
        public UserController(IUserService UserService)
        {
            this.UserService = UserService;
        }
        [HttpGet("GET_ALL")]
        public IEnumerable<User> GETALL()
        {
            var UserList = UserService.GetUserList();
            return UserList;
        }
        [HttpGet("GET_USER")]
        public User GET_USER(int id) { 
            return UserService.GetUserById(id);
        }
        [HttpGet("GET_UserName")]
        public User GET_UserName(string name)
        {
            return UserService.GetUserByName(name);
        }

        [HttpPost("AddUser")]
        public User AddUser(User user) { 
            return UserService.AddUser(user);
        }
        [HttpPut("UpdateUser")]
        public User UpdateUser(User user) {
           return UserService.UpdateUser(user);
        }
        [HttpDelete("DeleteUser")]
        public bool DeleteUser(int id) {
        return UserService.DeleteUser(id);
                }

    }
}
