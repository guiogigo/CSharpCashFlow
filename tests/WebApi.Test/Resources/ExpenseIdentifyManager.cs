using CashFlow.Domain.Entities;

namespace WebApi.Test.Resources;
public class ExpenseIdentifyManager
{
    private readonly Expense _expense;

    public ExpenseIdentifyManager(Expense expense)
    {

        _expense = expense;
    }

    public long GetExpenseId() => _expense.Id;
}
