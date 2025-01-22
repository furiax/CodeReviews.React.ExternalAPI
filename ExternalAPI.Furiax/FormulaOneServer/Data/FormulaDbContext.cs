using Microsoft.EntityFrameworkCore;

public class FormulaDbContext : DbContext
{
    public FormulaDbContext(DbContextOptions options) : base(options)
    {

    }
}
