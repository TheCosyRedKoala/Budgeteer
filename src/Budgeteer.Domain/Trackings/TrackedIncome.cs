using Budgeteer.Domain.Common;

namespace Budgeteer.Domain.Trackings;

public class TrackedIncome : Tracking
{
    public TrackedIncome(double amount, DateTime trackingDate, string description, CategoryType categoryType, RecurrenceType recurrenceType) : base(amount, trackingDate, description, categoryType, recurrenceType)
    {
    }
}
