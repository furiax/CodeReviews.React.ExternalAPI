using FormulaOneServer.Data;
using FormulaOneServer.Models;

namespace FormulaOneServer.Services
{
    public class FormulaService : IFormulaService
    {
        private readonly FormulaDbContext _dbContext;

        public FormulaService(FormulaDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Driver AddDriver(Driver driver)
        {
            var newDriver = _dbContext.Drivers.Add(driver);
            _dbContext.SaveChanges();
            return newDriver.Entity;
        }

        public string? DeleteDriver(int id)
        {
            Driver deletedDriver = _dbContext.Drivers.Find(id);
            if (deletedDriver == null)
            {
                return null;
            }
            _dbContext.Drivers.Remove(deletedDriver);
            return $"Successfully deleted driver with id: {id}";
        }

        public List<Driver> GetAllDrivers()
        {
           return _dbContext.Drivers.ToList();
        }

        public Driver? GetDriverByNumber(int id)
        {
            Driver getDriver = _dbContext.Drivers.Find(id);
            return getDriver == null ? null : getDriver;
        }

        public Driver UpdateDriver(Driver driver)
        {
            Driver updatedDriver = _dbContext.Drivers.Find(driver.Id);
            if (updatedDriver == null)
            {
                return null;
            }
            _dbContext.Entry(updatedDriver).CurrentValues.SetValues(driver);
            _dbContext.SaveChanges() ;
            return updatedDriver;
        }
    }
}
