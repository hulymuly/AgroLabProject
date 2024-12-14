using AgrolabBackend.Models;
using AgrolabBackend.Data;

namespace AgrolabBackend.Repositories;

public class EquipmentRepository : IEquipmentRepository
{
    private readonly AppDbContext _context;

    public EquipmentRepository(AppDbContext context)
    {
        _context = context;
    }

    public IEnumerable<Equipment> GetAll()
    {
        return _context.Equipment.ToList();
    }

    public void Add(Equipment equipment)
    {
        _context.Equipment.Add(equipment);
    }

    public void SaveChanges()
    {
        _context.SaveChanges();
    }
}
