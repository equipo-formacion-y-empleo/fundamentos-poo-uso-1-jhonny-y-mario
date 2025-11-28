namespace Domain;

/// <summary>
/// Representa un número único de pedido.
/// Value object inmutable.
/// </summary>
public class OrderNumber
{
    public string Value { get; }

    public OrderNumber(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
            throw new ArgumentException("OrderNumber cannot be empty", nameof(value));
        Value = value;
    }

    // Static factory
    public static OrderNumber Generate() => new OrderNumber($"ORD-{DateTime.UtcNow:yyyyMMdd}-{Guid.NewGuid().ToString().Substring(0, 8).ToUpper()}");

    public static OrderNumber Parse(string value) => new OrderNumber(value);

    // Equality
    public override bool Equals(object? obj)
    {
        if (obj is not OrderNumber other) return false;
        return Value == other.Value;
    }

    public override int GetHashCode() => Value.GetHashCode();

    public static bool operator ==(OrderNumber? left, OrderNumber? right)
    {
        if (left is null) return right is null;
        return left.Equals(right);
    }

    public static bool operator !=(OrderNumber? left, OrderNumber? right) => !(left == right);

    public override string ToString() => Value;
}
