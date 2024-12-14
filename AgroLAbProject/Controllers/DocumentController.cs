using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.IO;

[ApiController]
[Route("api/[controller]")]
public class DocumentController : ControllerBase
{
    private readonly WordTemplateService _wordTemplateService;

    public DocumentController(WordTemplateService wordTemplateService)
    {
        _wordTemplateService = wordTemplateService;
    }

    [HttpPost("generate")]
    public IActionResult GenerateDocument([FromBody] DocumentRequest request)
    {
        var templatePath = Path.Combine(Directory.GetCurrentDirectory(), "Templates", "protocol_template.docx");

        if (!System.IO.File.Exists(templatePath))
            return NotFound("Шаблон не найден");

        var placeholders = new Dictionary<string, string>
        {
            { "CustomerName", request.CustomerName },
            { "SampleName", request.SampleName },
            { "TestDate", request.TestDate.ToString("dd.MM.yyyy") },
            { "Result", request.Result }
        };

        var documentBytes = _wordTemplateService.GenerateDocument(templatePath, placeholders);
        return File(documentBytes, "application/vnd.openxmlformats-officedocument.wordprocessingml.document", "Protocol.docx");
    }
}
