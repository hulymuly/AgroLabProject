using AgrolabBackend.Models;
using AgrolabBackend.Data;

namespace AgrolabBackend.Repositories;

public class ReagentRepository : IReagentRepository
{
    private readonly AppDbContext _context;

    public ReagentRepository(AppDbContext context)
    {
        _context = context;
    }

    public IEnumerable<Reagent> GetAll()
    {
        return _context.Reagents.ToList();
    }

    public void Add(Reagent reagent)
    {
        _context.Reagents.Add(reagent);
    }

    public void SaveChanges()
    {
        _context.SaveChanges();
    }
}
