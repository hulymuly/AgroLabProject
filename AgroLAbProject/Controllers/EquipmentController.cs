using Microsoft.AspNetCore.Mvc;
using AgrolabBackend.Models;
using AgrolabBackend.Repositories;

namespace AgrolabBackend.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EquipmentController : ControllerBase
{
    private readonly IEquipmentRepository _equipmentRepository;

    public EquipmentController(IEquipmentRepository equipmentRepository)
    {
        _equipmentRepository = equipmentRepository;
    }

    [HttpGet]
    public IActionResult GetAll()
    {
        return Ok(_equipmentRepository.GetAll());
    }

    [HttpPost]
    public IActionResult Add([FromBody] Equipment equipment)
    {
        _equipmentRepository.Add(equipment);
        _equipmentRepository.SaveChanges();
        return Ok(equipment);
    }
}
