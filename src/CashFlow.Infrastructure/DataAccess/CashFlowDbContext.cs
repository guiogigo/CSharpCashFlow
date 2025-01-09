using CashFlow.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CashFlow.Infrastructure.DataAccess;
public class CashFlowDbContext : DbContext
{
    public DbSet<Expense> Expenses { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var connectionString = "Server=localhost;Port=3306;Database=cashflowdb;Uid=giga;Pwd=root;";
        var serverVersion = new MySqlServerVersion(new Version(8, 4, 3));

        optionsBuilder.UseMySql(connectionString, serverVersion);
    }
}
