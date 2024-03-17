using DotNetAPI.Models;

namespace DotNetAPI.Data
{
    public interface IUserRepository
    {
        public void RemoveEntity<T>(T removeItem);
        public void AddEntity<T>(T addItem);

        public bool SaveChanges();

        public IEnumerable<User> GetUsers();
        public User GetSingleUser(int userId);
        public UserSalary GetSingleUserSalary(int userId);

        public UserJobInfo GetSingleUserJobInfo(int userId);
    }
}