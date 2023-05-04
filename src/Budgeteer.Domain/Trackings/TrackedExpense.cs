using Budgeteer.Domain.Common;

namespace Budgeteer.Domain.Trackings;

public class TrackedExpense : TrackedOutflow
{
    public TrackedExpense(double amount, DateTime trackingDate, string description, CategoryType categoryType, RecurrenceType recurrenceType) : base(amount, trackingDate, description, categoryType, recurrenceType)
    {
    }
}
