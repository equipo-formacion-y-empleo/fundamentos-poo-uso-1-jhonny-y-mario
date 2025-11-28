namespace Domain;

/// <summary>
/// Representa una línea de pedido con producto, cantidad y precio unitario.
/// </summary>
public class OrderLine
{
    public Product Product { get; }
    public int Quantity { get; }
    public Money UnitPrice { get; }

    public OrderLine(Product product, int quantity, Money unitPrice)
    {
        if (quantity <= 0)
            throw new ArgumentException("Quantity must be positive", nameof(quantity));

        Product = product ?? throw new ArgumentNullException(nameof(product));
        Quantity = quantity;
        UnitPrice = unitPrice ?? throw new ArgumentNullException(nameof(unitPrice));
    }

    public Money GetSubtotal() => UnitPrice.Multiply(Quantity);

    public Money ApplyDiscount(decimal discountPercent)
    {
        if (discountPercent < 0 || discountPercent > 1)
            throw new ArgumentException("Discount must be between 0 and 1", nameof(discountPercent));
        
        var subtotal = GetSubtotal();
        return subtotal.Multiply(1 - discountPercent);
    }

    public override string ToString() => $"{Quantity}x {Product.Sku} @ {UnitPrice} = {GetSubtotal()}";
}
