using Budgeteer.Domain.Common;

namespace Budgeteer.Domain.Budgetings;

public class BudgetedExpense : BudgetedOutflow
{
    public BudgetedExpense(double amount, CategoryType categoryType, RecurrenceType recurrenceType, MonthType month) : base(amount, categoryType, recurrenceType, month)
    {
    }
}
