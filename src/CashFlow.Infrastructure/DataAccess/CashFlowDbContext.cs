using CashFlow.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CashFlow.Infrastructure.DataAccess;
public class CashFlowDbContext : DbContext
{
    public DbSet<Expense> Expenses { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var connectionString = "server=localhost;port=5000;database=cashflowdb;user=giga;password=123;";
        var serverVersion = new MySqlServerVersion(new Version(8, 4, 3));

        optionsBuilder.UseMySql(connectionString, serverVersion);
    }
}
