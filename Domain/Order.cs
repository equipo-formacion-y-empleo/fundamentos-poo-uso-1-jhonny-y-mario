namespace Domain;

/// <summary>
/// Estado de un pedido.
/// </summary>
public enum OrderStatus
{
    Draft,
    Confirmed,
    Shipped,
    Delivered,
    Cancelled
}

/// <summary>
/// Representa un pedido con líneas de producto.
/// </summary>
public class Order
{
    private decimal _discountPercentage = 0;
    public OrderNumber Number { get; }
    public Customer Customer { get; }
    public OrderStatus Status { get; private set; }
    public List<OrderLine> Lines { get; }
    public DateTime CreatedAt { get; }

    public Order(OrderNumber number, Customer customer)
    {
        Number = number ?? throw new ArgumentNullException(nameof(number));
        Customer = customer ?? throw new ArgumentNullException(nameof(customer));
        Status = OrderStatus.Draft;
        Lines = new List<OrderLine>();
        CreatedAt = DateTime.UtcNow;
    }

    public void AddLine(Product product, int quantity)
    {
        if (Status != OrderStatus.Draft)
            throw new InvalidOperationException("Cannot modify confirmed order");
        
        var line = new OrderLine(product, quantity, product.Price);
        Lines.Add(line);
    }

    public void AddLine(Product product, int quantity, Money unitPrice)
    {
        if (Status != OrderStatus.Draft)
            throw new InvalidOperationException("Cannot modify confirmed order");
        
        var line = new OrderLine(product, quantity, unitPrice);
        Lines.Add(line);
    }

    public Money Total => GetTotal();

    public void ApplyPercentageDiscount(decimal percentage, string reason)
    {
        if (percentage < 0 || percentage > 100)
            throw new ArgumentException("Percentage must be between 0 and 100");
        _discountPercentage = percentage;
    }
    
    public void ApplyPercentageDiscount(decimal percentage)
    {
        ApplyPercentageDiscount(percentage, "Descuento aplicado");
    }

    public Money GetTotal()
    {
        if (Lines.Count == 0) return Money.Euros(0);
        
        var firstCurrency = Lines[0].GetSubtotal().Currency;
        decimal total = 0;
        
        foreach (var line in Lines)
        {
            var subtotal = line.GetSubtotal();
            if (subtotal.Currency != firstCurrency)
                throw new InvalidOperationException("Mixed currencies in order");
            total += subtotal.Amount;
        }
        
        if (_discountPercentage > 0)
        {
            total -= total * (_discountPercentage / 100m);
        }
        
        return new Money(total, firstCurrency);
    }

    public void Confirm()
    {
        if (Status != OrderStatus.Draft)
            throw new InvalidOperationException("Order already confirmed");
        if (Lines.Count == 0)
            throw new InvalidOperationException("Cannot confirm empty order");
        
        Status = OrderStatus.Confirmed;
    }

    public void Cancel()
    {
        if (Status == OrderStatus.Delivered)
            throw new InvalidOperationException("Cannot cancel delivered order");
        
        Status = OrderStatus.Cancelled;
    }

    public override string ToString() => $"Order {Number} - {Customer.Name} ({Lines.Count} lines, {Status})";
}
