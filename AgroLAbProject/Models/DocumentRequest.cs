using System.ComponentModel.DataAnnotations;

namespace AgrolabBackend.Models;

public class DocumentRequest
{
    [Key]
    public int Id { get; set; }
    public string CustomerName { get; set; }
    public string SampleName { get; set; }
    public DateTime TestDate { get; set; }
    public string Result { get; set; }
}
