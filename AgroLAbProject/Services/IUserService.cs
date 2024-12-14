using AgrolabBackend.Models;

namespace AgrolabBackend.Services;

public interface IUserService
{
    User Authenticate(string username, string password);
    User Register(string username, string password, string role);
    IEnumerable<User> GetAllUsers();
}
