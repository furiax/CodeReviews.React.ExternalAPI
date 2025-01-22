using FormulaOneServer.Models;
using FormulaOneServer.Services;
using Microsoft.AspNetCore.Mvc;

namespace FormulaOneServer.Controllers;

[ApiController]
[Route("api/[controller]")]
public class FormulaController : ControllerBase
{
    private readonly IFormulaService _service;

    public FormulaController(IFormulaService service)
    {
        _service = service;
    }
    [HttpGet]
    public ActionResult<List<Driver>> GetAllDrivers()
    {
        return Ok(_service.GetAllDrivers());
    }
    [HttpGet("{id}")]
    public ActionResult<Driver> GetDriver(int id)
    {
        var result = _service.GetDriverById(id);
        if (result == null)
        {
            return NotFound();
        }

        return Ok(result);
    }
    [HttpPost]
    public ActionResult<Driver> AddDriver(Driver driver)
    {
        return Ok(_service.AddDriver(driver));
    }
    [HttpPut]
    public ActionResult<Driver> UpdateDriver(Driver driver) 
    {
        var result = (_service.UpdateDriver(driver));
        if (result == null)
        {
            return NotFound();
        }
        return Ok(result);
    }
    [HttpDelete("{id}")]
    public ActionResult DeleteDriver(int id)
    {
        var result = _service.DeleteDriver(id);
        if (result == null)
        {
            return NotFound();
        }
        return Ok(result);
    }
}
