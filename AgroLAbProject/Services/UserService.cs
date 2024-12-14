using BCrypt.Net;
using AgrolabBackend.Models;
using AgrolabBackend.Repositories;

namespace AgrolabBackend.Services;

public class UserService : IUserService
{
    private readonly IUserRepository _userRepository;

    public UserService(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    public User Authenticate(string username, string password)
    {
        var user = _userRepository.GetByUsername(username);
        if (user == null || !BCrypt.Net.BCrypt.Verify(password, user.PasswordHash))
        {
            return null;
        }
        return user;
    }

    public User Register(string username, string password, string role)
    {
        var user = new User
        {
            Username = username,
            PasswordHash = BCrypt.Net.BCrypt.HashPassword(password),
            Role = role
        };
        _userRepository.Add(user);
        _userRepository.SaveChanges();
        return user;
    }

    public IEnumerable<User> GetAllUsers()
    {
        return _userRepository.GetAll();
    }
}
