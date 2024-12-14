using AgrolabBackend.Models;

namespace AgrolabBackend.Repositories;

public interface IReagentRepository
{
    IEnumerable<Reagent> GetAll();
    void Add(Reagent reagent);
    void SaveChanges();
}
