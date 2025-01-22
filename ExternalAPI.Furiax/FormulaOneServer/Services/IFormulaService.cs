using FormulaOneServer.Models;

namespace FormulaOneServer.Services;

public interface IFormulaService
{
    public List<Driver> GetAllDrivers();
    public Driver? GetDriverById(int id);
    public Driver AddDriver(Driver driver);
    public Driver UpdateDriver(Driver driver);
    public string? DeleteDriver(int id);
}

