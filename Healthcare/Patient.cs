namespace Healthcare;

/// <summary>
/// Representa un paciente en el sistema de salud.
/// </summary>
public class Patient
{
    public string PatientId { get; set; }
    public string FullName { get; set; }
    public int Age { get; set; }
    public DateTime RegistrationDate { get; }

    public Patient()
    {
        PatientId = string.Empty;
        FullName = string.Empty;
        RegistrationDate = DateTime.UtcNow;
    }

    public Patient(string fullName, int age)
    {
        PatientId = Guid.NewGuid().ToString("N")[..8].ToUpper();
        FullName = fullName;
        Age = age;
        RegistrationDate = DateTime.UtcNow;
    }

    public Patient(string patientId, string fullName, int age) : this(fullName, age)
    {
        PatientId = patientId;
    }
}
