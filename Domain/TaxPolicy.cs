namespace Domain;

/// <summary>
/// Política fiscal para cálculo de impuestos.
/// </summary>
public static class TaxPolicy
{
    public const decimal StandardRate = 0.21m;
    public const decimal ReducedRate = 0.10m;
    public const decimal SuperReducedRate = 0.04m;

    public static Money ApplyStandard(Money amount) => amount.AddTax(StandardRate);
    public static Money ApplyReduced(Money amount) => amount.AddTax(ReducedRate);
    public static Money ApplySuperReduced(Money amount) => amount.AddTax(SuperReducedRate);

    public static decimal CalculateTaxAmount(Money baseAmount, decimal rate)
    {
        return baseAmount.Amount * rate;
    }
}
