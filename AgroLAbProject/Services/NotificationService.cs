using System;
using System.Linq;
using AgrolabBackend.Data;

namespace AgrolabBackend.Services;

public class NotificationService
{
    private readonly AppDbContext _context;

    public NotificationService(AppDbContext context)
    {
        _context = context;
    }

    public void CheckReagentExpiration()
    {
        var expiredReagents = _context.Reagents
            .Where(r => r.ExpirationDate <= DateTime.Now)
            .ToList();

        foreach (var reagent in expiredReagents)
        {
            Console.WriteLine($"Уведомление: Реактив '{reagent.Name}' истёк.");
        }
    }

    public void CheckReagentStock()
    {
        var lowStockReagents = _context.Reagents
            .Where(r => r.Quantity <= r.MinQuantity)
            .ToList();

        foreach (var reagent in lowStockReagents)
        {
            Console.WriteLine($"Уведомление: Реактив '{reagent.Name}' заканчивается.");
        }
    }
}
