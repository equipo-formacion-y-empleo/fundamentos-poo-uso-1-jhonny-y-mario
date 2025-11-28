namespace Logistics;

/// <summary>
/// Representa un envío que contiene múltiples paquetes.
/// </summary>
public class Shipment
{
    public string ShipmentId { get; }
    public string Carrier { get; set; }
    public List<Package> Packages { get; }
    public ShipmentStatus Status { get; private set; }

    public Shipment(string shipmentId, string carrier)
    {
        ShipmentId = shipmentId;
        Carrier = carrier;
        Packages = new List<Package>();
        Status = ShipmentStatus.Pending;
    }

    public void AddPackage(Package package)
    {
        if (Status != ShipmentStatus.Pending)
            throw new InvalidOperationException("Cannot add packages to shipped orders");
        
        Packages.Add(package);
    }

    public double GetTotalWeight()
    {
        return Packages.Sum(p => p.WeightKg);
    }

    public void Ship()
    {
        if (Packages.Count == 0)
            throw new InvalidOperationException("Cannot ship empty shipment");
        
        Status = ShipmentStatus.InTransit;
    }

    public void Deliver()
    {
        if (Status != ShipmentStatus.InTransit)
            throw new InvalidOperationException("Can only deliver shipments in transit");
        
        Status = ShipmentStatus.Delivered;
    }
}

public enum ShipmentStatus
{
    Pending,
    InTransit,
    Delivered,
    Cancelled
}
