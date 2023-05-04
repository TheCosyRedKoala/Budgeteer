using Budgeteer.Domain.Common;

namespace Budgeteer.Domain.Budgetings;

public class Budgeting
{
    public double Amount { get; private set; }
    public CategoryType Category { get; private set; }
    public RecurrenceType RecurrenceType { get; private set; }
    public MonthType Month { get; private set; }

    public Budgeting(double amount, CategoryType categoryType, RecurrenceType recurrenceType, MonthType month)
    {
        Amount = Guard.Against.Negative(amount, nameof(amount));
        Category = Guard.Against.Null(categoryType, nameof(categoryType));
        RecurrenceType = Guard.Against.EnumOutOfRange(recurrenceType, nameof(recurrenceType));
        Month = Guard.Against.EnumOutOfRange(month, nameof(month));
    }
}
