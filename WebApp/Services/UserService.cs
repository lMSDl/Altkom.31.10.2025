using WebApp.Models;

namespace WebApp.Services
{
    public class UserService
    {
        private List<User> _users = new List<User>();

        public void AddUser(User user)
        {
            _users.Add(user);
            Console.WriteLine($"User added: {user.Name}");
        }

        public bool RemoveUser(string name)
        {
            var user = _users.FirstOrDefault(u => u.Name == name);
            if (user != null)
            {
                _users.Remove(user);
                Console.WriteLine($"User removed: {name}");
                return true;
            }
            return false;
        }

        public User GetUserByIndex(int index)
        {
            return _users[index];
        }

        public void PrintAllUsers()
        {
            foreach (var user in _users)
            {
                Console.WriteLine(user.Name);
            }
        }

        public List<User> GetAllUsers()
        {
            return _users;
        }
    }
}
