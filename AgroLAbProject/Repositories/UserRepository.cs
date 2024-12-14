using AgrolabBackend.Models;

namespace AgrolabBackend.Repositories;

public class UserRepository : IUserRepository
{
    private readonly AppDbContext _context;

    public UserRepository(AppDbContext context)
    {
        _context = context;
    }

    public IEnumerable<User> GetAll()
    {
        return _context.Users.ToList();
    }

    public User GetByUsername(string username)
    {
        return _context.Users.FirstOrDefault(u => u.Username == username);
    }

    public void Add(User user)
    {
        _context.Users.Add(user);
    }

    public void SaveChanges()
    {
        _context.SaveChanges();
    }
}
