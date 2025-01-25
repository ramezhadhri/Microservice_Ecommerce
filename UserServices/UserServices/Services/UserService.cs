using Microsoft.EntityFrameworkCore;
using UserServices.Data;
using UserServices.Models;

namespace UserServices.Services
{
    public class UserService : IUserService
    {
        private readonly DbContextClasss _dbContext;
        public UserService(DbContextClasss dbContext)
        {
            _dbContext = dbContext;
        }
        public IEnumerable<User> GetUserList()
        {
            return _dbContext.Users.ToList();
        }
        public User GetUserById(int id)
        {
            return _dbContext.Users.Where(x => x.UserId == id).FirstOrDefault();
            //FirstOrDefault return null si where ne trouve pas aucun id 
        }
        public User GetUserByName(string name)
        {
            return _dbContext.Users.Where(x => x.UserName == name).FirstOrDefault();
            //FirstOrDefault return null si where ne trouve pas aucun id 
        }
        public User AddUser(User user) {
           var res= _dbContext.Users.Add(user);
            _dbContext.SaveChanges();
            return res.Entity;

        }
        public User UpdateUser(User user) {
            var res = _dbContext.Users.Update(user);
            _dbContext.SaveChanges();
            return res.Entity;
        }
        public bool DeleteUser(int id)
        {
            var  Res= _dbContext.Users.Where(x => x.UserId == id).FirstOrDefault();
            _dbContext.Users.Remove(Res);
            _dbContext.SaveChanges();
            return Res != null? true: false;

        }



    }
}
