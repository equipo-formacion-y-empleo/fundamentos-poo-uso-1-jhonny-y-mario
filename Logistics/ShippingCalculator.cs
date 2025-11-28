namespace Logistics;

/// <summary>
/// Utilidad para calcular costes de envío.
/// </summary>
public static class ShippingCalculator
{
    public static decimal CalculateCost(double weightKg, int distanceKm)
    {
        const decimal baseRate = 5.00m;
        const decimal weightRate = 0.50m;
        const decimal distanceRate = 0.10m;

        return baseRate + (decimal)weightKg * weightRate + distanceKm * distanceRate;
    }

    public static decimal ApplyDiscount(decimal cost, decimal discountPercent)
    {
        if (discountPercent < 0 || discountPercent > 100)
            throw new ArgumentException("Discount must be between 0 and 100");

        return cost * (1 - discountPercent / 100);
    }
}
