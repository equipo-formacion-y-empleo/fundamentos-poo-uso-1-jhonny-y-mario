namespace Domain;

/// <summary>
/// Representa un cliente B2B con información fiscal y de contacto.
/// </summary>
public class Customer
{
    public string Id { get; }
    public string Name { get; set; }
    public string TaxId { get; }
    public string Email { get; set; }
    public Address? BillingAddress { get; set; }
    public bool IsActive { get; set; }

    // Constructor principal (el más específico)
    public Customer(string name, string email, string taxId)
    {
        if (string.IsNullOrWhiteSpace(name))
            throw new ArgumentException("Name cannot be empty", nameof(name));

        Id = Guid.NewGuid().ToString();
        Name = name;
        Email = email;
        TaxId = taxId;
        IsActive = true;
    }

    // Constructor encadenado: Solo nombre y email (TaxId vacío)
    public Customer(string name, string email) : this(name, email, "PENDING")
    {
    }

    // Constructor encadenado: Solo nombre (Email y TaxId vacíos)
    public Customer(string name) : this(name, "no-email@example.com")
    {
    }

    public string GetDisplayName() => $"{Name} ({TaxId})";

    public void UpdateEmail(string newEmail)
    {
        if (string.IsNullOrWhiteSpace(newEmail))
            throw new ArgumentException("Email cannot be empty", nameof(newEmail));
        Email = newEmail;
    }

    public override string ToString() => GetDisplayName();
}
