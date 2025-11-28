namespace Domain;

/// <summary>
/// Representa un producto con SKU, descripción y precio.
/// </summary>
public class Product
{
    public string Sku { get; set; }
    public string Description { get; set; }
    public Money Price { get; set; }
    public bool IsAvailable { get; set; }
    public DateTime CreatedAt { get; } // Read-only property

    public Product()
    {
        Sku = "UNKNOWN";
        Description = "New Product";
        Price = Money.Euros(0);
        IsAvailable = false;
        CreatedAt = DateTime.UtcNow;
    }

    public Product(string sku, string description, decimal amount, string currency = "EUR")
    {
        if (string.IsNullOrWhiteSpace(sku))
            throw new ArgumentException("SKU cannot be empty", nameof(sku));
        if (string.IsNullOrWhiteSpace(description))
            throw new ArgumentException("Description cannot be empty", nameof(description));

        Sku = sku;
        Description = description;
        Price = new Money(amount, currency);
        IsAvailable = true;
        CreatedAt = DateTime.UtcNow;
    }

    public override string ToString() => $"{Sku}: {Description} - {Price}";
}
