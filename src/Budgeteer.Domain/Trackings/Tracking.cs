using Budgeteer.Domain.Common;

namespace Budgeteer.Domain.Trackings;

public class Tracking
{
    public double Amount { get; private set; }
    public DateTime TrackingDate { get; private set; }
    public string Description { get; private set; } = default!;
    public CategoryType Category { get; private set; }
    public RecurrenceType RecurrenceType { get; private set; }

    public Tracking(double amount, DateTime trackingDate, string description, CategoryType categoryType, RecurrenceType recurrenceType)
    {
        Amount = Guard.Against.Negative(amount, nameof(amount));
        TrackingDate = Guard.Against.OutOfSQLDateRange(trackingDate, nameof(trackingDate));
        Description = Guard.Against.NullOrWhiteSpace(description, nameof(description));
        Category = Guard.Against.Null(categoryType, nameof(categoryType));
        RecurrenceType = Guard.Against.EnumOutOfRange(recurrenceType, nameof(recurrenceType));
    }
}
