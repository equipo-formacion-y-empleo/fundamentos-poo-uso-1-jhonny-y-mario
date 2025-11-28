namespace Domain;

public class InventoryService
{
    /// <summary>
    /// Procesa un item y actualiza el contador.
    /// </summary>
    public void ProcessItem(string sku, ref int processedCount)
    {
        Console.WriteLine($"[Procesando] {sku}...");
        processedCount++;
    }

    /// <summary>
    /// Registra múltiples mensajes de log.
    /// </summary>
    public void LogUpdates(params string[] messages)
    {
        foreach (var msg in messages)
        {
            Console.WriteLine($"LOG: {msg}");
        }
    }
}
