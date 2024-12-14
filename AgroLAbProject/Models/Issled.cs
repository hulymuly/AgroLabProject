namespace AgroBackend.Models
{
    public class Issled
    {
        public int Id { get; set; }
        public int ZakazchikId { get; set; }
        public Zakazchik Zakazchik { get; set; }
        public string Name { get; set; }
        // Добавьте другие поля, если они есть в схеме
    }
}