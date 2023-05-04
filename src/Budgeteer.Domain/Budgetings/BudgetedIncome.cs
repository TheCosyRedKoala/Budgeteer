using Budgeteer.Domain.Common;

namespace Budgeteer.Domain.Budgetings;

public class BudgetedIncome : Budgeting
{
    public BudgetedIncome(double amount, CategoryType categoryType, RecurrenceType recurrenceType, MonthType month) : base(amount, categoryType, recurrenceType, month)
    {
    }
}
