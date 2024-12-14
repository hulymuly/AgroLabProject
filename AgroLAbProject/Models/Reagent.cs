namespace AgrolabBackend.Models;

public class Reagent
{
    public int Id { get; set; }
    public string Name { get; set; }
    public DateTime ExpirationDate { get; set; }
    public int Quantity { get; set; }
    public int MinQuantity { get; set; }
}
