using AgrolabBackend.Models;

namespace AgrolabBackend.Repositories;

public interface IEquipmentRepository
{
    IEnumerable<Equipment> GetAll();
    void Add(Equipment equipment);
    void SaveChanges();
}
