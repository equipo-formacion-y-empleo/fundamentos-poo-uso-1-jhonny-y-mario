namespace Logistics;

/// <summary>
/// Representa un paquete en el sistema de logística.
/// </summary>
public class Package
{
    public string TrackingNumber { get; set; }
    public string Destination { get; set; }
    public double WeightKg { get; set; }
    public DateTime ShippedDate { get; }

    public Package()
    {
        TrackingNumber = string.Empty;
        Destination = string.Empty;
        ShippedDate = DateTime.UtcNow;
    }

    public Package(string trackingNumber, string destination, double weightKg)
    {
        TrackingNumber = trackingNumber;
        Destination = destination;
        WeightKg = weightKg;
        ShippedDate = DateTime.UtcNow;
    }
}
