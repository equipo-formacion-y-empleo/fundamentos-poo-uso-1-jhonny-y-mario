# Ex02c_ConstructorsHealthcare

## Enunciado (Problema)

Implementar tres escenarios de creación de `Patient`.

Requisitos:
1. Paciente por emergencia (constructor vacío).
2. Paciente nuevo (nombre + edad).
3. Paciente con ID conocido (ID + nombre + edad).
4. Mostrar para cada uno: `PatientId`, `FullName`, `Age`, `RegistrationDate`.

Objetivo: evidenciar diferencias de sobrecarga y autogeneración de datos.

## Herramientas Disponibles

**Clase:** `Patient` (Healthcare) - Requiere `using Healthcare;`
- **Constructor:** `new Patient()` - Registro vacío de emergencia
- **Constructor:** `new Patient(string fullName, int age)` - Paciente nuevo con datos básicos
- **Constructor:** `new Patient(string patientId, string fullName, int age)` - Paciente con ID conocido
- **Propiedades:** `PatientId`, `FullName`, `Age`, `RegistrationDate` (lectura)

## Variables Disponibles

En Program.cs puedes modificar:
```csharp
string nombre = "Carlos Ruiz";
int edad = 35;
string patientId = "PAT-001";
string extra = "";
```

## Salida

El programa imprime:
```
=== Sistema de Registro de Pacientes ===

Paciente 1 (constructor sin parámetros):
  ID: <guid>
  Nombre: Sin asignar
  Edad: 0
  Historia: N/A
  Tipo Sangre: N/A
  Registro: <fecha> (Read-Only)

Paciente 2 (constructor con nombre y edad):
  ID: <guid>
  Nombre: <nombre>
  Edad: <edad>
  Historia: N/A
  Tipo Sangre: N/A
  Registro: <fecha> (Read-Only)

Paciente 3 (constructor completo):
  ID: <guid>
  Nombre: <nombre>
  Edad: <edad>
  Historia: <historia>
  Tipo Sangre: <tipo>
  Registro: <fecha> (Read-Only)
```

## Ejemplo de Salida

### Con valores por defecto:

**Salida:**
```
=== Sistema de Registro de Pacientes ===

Paciente 1 (constructor sin parámetros):
  ID: a1b2c3d4-e5f6-7890-abcd-ef1234567890
  Nombre: Sin asignar
  Edad: 0
  Historia: N/A
  Tipo Sangre: N/A
  Registro: 25/11/2025 10:30:00 (Read-Only)

Paciente 2 (constructor con nombre y edad):
  ID: b2c3d4e5-f6a7-8901-bcde-f12345678901
  Nombre: Carlos Ruiz
  Edad: 35
  Historia: N/A
  Tipo Sangre: N/A
  Registro: 25/11/2025 10:30:00 (Read-Only)

Paciente 3 (constructor completo):
  ID: c3d4e5f6-a7b8-9012-cdef-123456789012
  Nombre: Carlos Ruiz
  Edad: 35
  Historia: HC-2024-001
  Tipo Sangre: O+
  Registro: 25/11/2025 10:30:00 (Read-Only)
```

### Con nombre = "Ana López", edad = 28, patientId = "HC-2024-002", extra = "A+":

**Salida:**
```
=== Sistema de Registro de Pacientes ===

Paciente 1 (constructor sin parámetros):
  ID: d4e5f6a7-b8c9-0123-def1-234567890123
  Nombre: Sin asignar
  Edad: 0
  Historia: N/A
  Tipo Sangre: N/A
  Registro: 25/11/2025 10:30:00 (Read-Only)

Paciente 2 (constructor con nombre y edad):
  ID: e5f6a7b8-c9d0-1234-ef12-345678901234
  Nombre: Ana López
  Edad: 28
  Historia: N/A
  Tipo Sangre: N/A
  Registro: 25/11/2025 10:30:00 (Read-Only)

Paciente 3 (constructor completo):
  ID: f6a7b8c9-d0e1-2345-f123-456789012345
  Nombre: Ana López
  Edad: 28
  Historia: HC-2024-002
  Tipo Sangre: A+
  Registro: 25/11/2025 10:30:00 (Read-Only)
```

## Conceptos Clave

- **Namespace:** Requiere `using Healthcare;`
- **Nuevo Dominio:** Clases del ámbito médico/salud
- **Sobrecarga de Constructores:** 3 formas diferentes de crear un paciente
- **Propiedades Calculadas:** `RegistrationDate` se establece automáticamente
- **Valores por Defecto:** Cada constructor establece valores iniciales apropiados
