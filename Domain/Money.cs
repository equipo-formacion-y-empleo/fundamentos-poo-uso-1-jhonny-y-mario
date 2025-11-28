namespace Domain;

/// <summary>
/// Representa un importe monetario con moneda.
/// Value object inmutable.
/// </summary>
public class Money
{
    public decimal Amount { get; }
    public string Currency { get; }

    public Money(decimal amount, string currency)
    {
        if (string.IsNullOrWhiteSpace(currency))
            throw new ArgumentException("Currency cannot be empty", nameof(currency));

        Amount = amount;
        Currency = currency.ToUpperInvariant();
    }

    // Factory methods
    public static Money Euros(decimal amount) => new Money(amount, "EUR");
    public static Money Dollars(decimal amount) => new Money(amount, "USD");
    public static Money Pounds(decimal amount) => new Money(amount, "GBP");

    // Operations
    public Money Add(Money other)
    {
        if (Currency != other.Currency)
            throw new InvalidOperationException($"Cannot add {other.Currency} to {Currency}");
        return new Money(Amount + other.Amount, Currency);
    }

    public Money Subtract(Money other)
    {
        if (Currency != other.Currency)
            throw new InvalidOperationException($"Cannot subtract {other.Currency} from {Currency}");
        return new Money(Amount - other.Amount, Currency);
    }

    public Money Multiply(decimal factor) => new Money(Amount * factor, Currency);

    public Money AddTax(decimal taxRate) => Multiply(1 + taxRate);

    // Static utility methods
    public static Money Convert(Money source, string targetCurrency, decimal exchangeRate)
    {
        return new Money(source.Amount * exchangeRate, targetCurrency);
    }

    public static decimal Compare(Money first, Money second)
    {
        if (first.Currency != second.Currency)
            throw new InvalidOperationException($"Cannot compare {first.Currency} with {second.Currency}");
        return first.Amount - second.Amount;
    }

    public static Money Max(Money first, Money second)
    {
        if (first.Currency != second.Currency)
            throw new InvalidOperationException($"Cannot compare {first.Currency} with {second.Currency}");
        return first.Amount >= second.Amount ? first : second;
    }

    public static Money CalculateDiscount(Money original, decimal percentage)
    {
        if (percentage < 0 || percentage > 100)
            throw new ArgumentException("Percentage must be between 0 and 100");
        var discount = original.Amount * (percentage / 100m);
        return new Money(original.Amount - discount, original.Currency);
    }

    // Equality
    public override bool Equals(object? obj)
    {
        if (obj is not Money other) return false;
        return Amount == other.Amount && Currency == other.Currency;
    }

    public override int GetHashCode() => HashCode.Combine(Amount, Currency);

    public static bool operator ==(Money? left, Money? right)
    {
        if (left is null) return right is null;
        return left.Equals(right);
    }

    public static bool operator !=(Money? left, Money? right) => !(left == right);

    public override string ToString() => $"{Amount:F2} {Currency}";
}
