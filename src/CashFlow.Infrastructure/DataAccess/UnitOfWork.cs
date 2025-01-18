using CashFlow.Domain.Repositories;

namespace CashFlow.Infrastructure.DataAccess;
internal class UnitOfWork : IUnitOfWork
{
    private readonly CashFlowDbContext _dbContext;
    public UnitOfWork(CashFlowDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task Commit()
    {
        /*try
        {

            await _dbContext.SaveChangesAsync();
        }
        catch (Exception ex) {
            Console.WriteLine($"Erro ao salvar no banco: {ex.Message}");
            throw;
        }*/
        await _dbContext.SaveChangesAsync();
    }
}
