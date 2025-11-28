# Ex02b_ConstructorsDomain

## Enunciado (Problema)

Implementar tres formas de crear un `Customer` mediante sobrecarga de constructores.

Requisitos:
1. Crear cliente con solo nombre.
2. Crear cliente con nombre y email.
3. Crear cliente con nombre, email y taxId.
4. Mostrar para cada instancia: `Id`, `Name`, `Email`, `TaxId`.

Objetivo: comparar inicialización automática y valores por defecto.

## Herramientas Disponibles

**Clase:** `Customer` (Domain)
- **Constructor:** `new Customer(string nombre)` - Solo nombre (email y taxId automáticos)
- **Constructor:** `new Customer(string nombre, string email)` - Nombre y email (taxId automático)
- **Constructor:** `new Customer(string nombre, string email, string taxId)` - Datos completos
- **Propiedades:** `Id`, `Name`, `Email`, `TaxId` (solo lectura para mostrar)

## Variables Disponibles

En Program.cs puedes modificar:
```csharp
string nombre = "Juan Pérez";
string email = "juan@example.com";
string taxId = "12345678A";
```

## Salida

El programa imprime:
```
=== Sistema de Registro de Clientes ===

Cliente 1 (constructor sin parámetros):
  ID: <guid>
  Nombre: N/A
  Email: N/A
  Teléfono: N/A

Cliente 2 (constructor con nombre y email):
  ID: <guid>
  Nombre: <nombre>
  Email: <email>
  Teléfono: N/A

Cliente 3 (constructor completo):
  ID: <guid>
  Nombre: <nombre>
  Email: <email>
  Teléfono: <telefono>
```

## Ejemplo de Salida

### Con valores por defecto:

**Salida:**
```
=== Sistema de Registro de Clientes ===

Cliente 1 (constructor sin parámetros):
  ID: a1b2c3d4-e5f6-7890-abcd-ef1234567890
  Nombre: N/A
  Email: N/A
  Teléfono: N/A

Cliente 2 (constructor con nombre y email):
  ID: b2c3d4e5-f6a7-8901-bcde-f12345678901
  Nombre: Juan Pérez
  Email: juan@example.com
  Teléfono: N/A

Cliente 3 (constructor completo):
  ID: c3d4e5f6-a7b8-9012-cdef-123456789012
  Nombre: Juan Pérez
  Email: juan@example.com
  Teléfono: +34 600 123 456
```

### Con nombre = "María García", email = "maria@example.com", taxId = "+34 611 987 654":

**Salida:**
```
=== Sistema de Registro de Clientes ===

Cliente 1 (constructor sin parámetros):
  ID: d4e5f6a7-b8c9-0123-def1-234567890123
  Nombre: N/A
  Email: N/A
  Teléfono: N/A

Cliente 2 (constructor con nombre y email):
  ID: e5f6a7b8-c9d0-1234-ef12-345678901234
  Nombre: María García
  Email: maria@example.com
  Teléfono: N/A

Cliente 3 (constructor completo):
  ID: f6a7b8c9-d0e1-2345-f123-456789012345
  Nombre: María García
  Email: maria@example.com
  Teléfono: +34 611 987 654
```

## Conceptos Clave

- **Múltiples Constructores:** Una clase puede tener varios constructores
- **Encadenamiento:** Un constructor puede llamar a otro usando `this()`
- **Valores por Defecto:** Constructores pueden establecer valores iniciales
- **Generación Automática:** `CustomerId` se genera automáticamente como GUID
- **Namespace:** Requiere `using Domain;`
