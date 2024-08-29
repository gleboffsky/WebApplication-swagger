using AuthService.Models;
using System.Runtime.CompilerServices;

namespace AuthService.Services
{
    public interface IUserService
    {
        public List<User> GetUsers();
        public void CreateUser(User user);
        public void DeleteUser(int id);
        public void UpdateUser(User user);
    }
    public class UserService : IUserService
    {
        private List<User> _users;
        public UserService() 
        {
            _users = new List<User>
            {
                new User { Id = 1, Age = 23, Name = "Gleb1"},
                new User { Id = 2, Age = 23, Name = "Gleb2"},
                new User { Id = 3, Age = 23, Name = "Gleb3"}
            };
        }
        public void CreateUser(User user)
        {
            _users.Add(user);
        }

        public void DeleteUser(int id)
        {
            var user = _users.FirstOrDefault(x => x.Id == id);
            _users.Remove(user);
        }

        public List<User> GetUsers()
        {
            return _users;
        }

        public void UpdateUser(User user)
        {
            var userData = _users.FirstOrDefault(x => x.Id == user.Id);
            userData.Age = user.Age;
            userData.Name = user.Name;
        }
    }
}









