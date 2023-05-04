using Budgeteer.Domain.Common;

namespace Budgeteer.Domain.Budgetings;

public class BudgetedSavings : BudgetedOutflow
{
    public BudgetedSavings(double amount, CategoryType categoryType, RecurrenceType recurrenceType, MonthType month) : base(amount, categoryType, recurrenceType, month)
    {
    }
}
