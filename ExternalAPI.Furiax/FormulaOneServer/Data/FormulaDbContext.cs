using FormulaOneServer.Models;
using Microsoft.EntityFrameworkCore;

namespace FormulaOneServer.Data;
public class FormulaDbContext : DbContext
{
    public FormulaDbContext(DbContextOptions options) : base(options)
    {

    }
    public DbSet<Driver> Drivers { get; set; } 
}
