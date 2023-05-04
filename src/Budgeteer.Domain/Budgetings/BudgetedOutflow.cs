using Budgeteer.Domain.Common;

namespace Budgeteer.Domain.Budgetings;

public class BudgetedOutflow : Budgeting
{
    public BudgetedOutflow(double amount, CategoryType categoryType, RecurrenceType recurrenceType, MonthType month) : base(amount, categoryType, recurrenceType, month)
    {
    }
}
