using AgrolabBackend.Models;

namespace AgrolabBackend.Repositories;

public interface IUserRepository
{
    IEnumerable<User> GetAll();
    User GetByUsername(string username);
    void Add(User user);
    void SaveChanges();
}
