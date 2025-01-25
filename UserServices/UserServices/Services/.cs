using UserServices.Models;

namespace UserServices.Services
{
    public interface IUserService
    {
        public IEnumerable<User> GetUserList();
        public User GetUserByName(string name);
        public User GetUserById(int id);
        public User AddUser(User user);
        public User UpdateUser(User user);
        public bool DeleteUser(int id);
    }
}
