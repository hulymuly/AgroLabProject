using Xceed.Words.NET;
using System.IO;

public class WordTemplateService
{
    public byte[] GenerateDocument(string templatePath, Dictionary<string, string> placeholders)
    {
        using (var document = DocX.Load(templatePath))
        {
            foreach (var placeholder in placeholders)
            {
                document.ReplaceText($"{{{{{placeholder.Key}}}}}", placeholder.Value);
            }

            using (var memoryStream = new MemoryStream())
            {
                document.SaveAs(memoryStream);
                return memoryStream.ToArray();
            }
        }
    }
}
