namespace Budgeteer.Domain.Common;

public class CategoryType
{
    public string Name { get; private set; } = default!;
    public bool IsIncomeCategory { get; private set; }
    public bool IsExpense { get; private set; }
    public bool IsSaving { get; private set; }

    public CategoryType(string name, bool isIncome, bool isExpense, bool isSaving)
    {
        Name = Guard.Against.NullOrWhiteSpace(name, nameof(name));
        IsIncomeCategory = isIncome;
        IsExpense = isExpense;
        IsSaving = isSaving;
    }
}
