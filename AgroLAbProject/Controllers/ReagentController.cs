using Microsoft.AspNetCore.Mvc;
using AgrolabBackend.Models;
using AgrolabBackend.Repositories;

namespace AgrolabBackend.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ReagentsController : ControllerBase
{
    private readonly IReagentRepository _reagentRepository;

    public ReagentsController(IReagentRepository reagentRepository)
    {
        _reagentRepository = reagentRepository;
    }

    [HttpGet]
    public IActionResult GetAll()
    {
        return Ok(_reagentRepository.GetAll());
    }

    [HttpPost]
    public IActionResult Add([FromBody] Reagent reagent)
    {
        _reagentRepository.Add(reagent);
        _reagentRepository.SaveChanges();
        return Ok(reagent);
    }
}
