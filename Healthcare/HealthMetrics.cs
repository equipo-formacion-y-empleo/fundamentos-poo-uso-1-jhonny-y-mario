namespace Healthcare;

/// <summary>
/// Utilidad para calcular índices de salud.
/// </summary>
public static class HealthMetrics
{
    public static double CalculateBMI(double weightKg, double heightM)
    {
        if (heightM <= 0)
            throw new ArgumentException("Height must be positive");

        return weightKg / (heightM * heightM);
    }

    public static string GetBMICategory(double bmi)
    {
        return bmi switch
        {
            < 18.5 => "Underweight",
            < 25 => "Normal",
            < 30 => "Overweight",
            _ => "Obese"
        };
    }

    public static int CalculateMaxHeartRate(int age)
    {
        return 220 - age;
    }
}
