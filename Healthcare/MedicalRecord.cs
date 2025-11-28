namespace Healthcare;

/// <summary>
/// Representa un registro médico del paciente.
/// </summary>
public class MedicalRecord
{
    public Patient Patient { get; }
    public List<string> Diagnoses { get; }
    public List<string> Prescriptions { get; }
    public DateTime LastVisit { get; private set; }

    public MedicalRecord(Patient patient)
    {
        Patient = patient;
        Diagnoses = new List<string>();
        Prescriptions = new List<string>();
        LastVisit = DateTime.UtcNow;
    }

    public void AddDiagnosis(string diagnosis)
    {
        Diagnoses.Add(diagnosis);
        LastVisit = DateTime.UtcNow;
    }

    public void AddPrescription(string prescription)
    {
        Prescriptions.Add(prescription);
    }

    public void UpdateVisit()
    {
        LastVisit = DateTime.UtcNow;
    }

    public int GetTotalRecords()
    {
        return Diagnoses.Count + Prescriptions.Count;
    }
}
