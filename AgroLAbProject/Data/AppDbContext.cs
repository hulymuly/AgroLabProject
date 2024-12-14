using Microsoft.EntityFrameworkCore;
using AgrolabBackend.Models;

namespace AgrolabBackend.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<User> Users { get; set; }
    public DbSet<DocumentRequest> Documents { get; set; }
    public DbSet<Reagent> Reagents { get; set; }
    public DbSet<Equipment> Equipment { get; set; }
}
