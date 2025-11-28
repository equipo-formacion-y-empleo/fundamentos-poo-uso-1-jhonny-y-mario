# Ex01c_PropertiesLogistics

## Problema

En este ejercicio trabajarás con la clase `Package` del dominio de logística para registrar la información de un paquete. Practicarás la asignación y modificación de propiedades de un objeto.

Debes crear un paquete vacío, asignarle sus datos (número de seguimiento, destino y peso), y luego actualizar el destino.

### Pasos a realizar:
1. Crear un objeto `Package` usando el constructor sin parámetros: `new Package()`.
2. Asignar valores a las propiedades:
   - `TrackingNumber`: el número de seguimiento (usa la variable `trackingNumber`)
   - `Destination`: el destino del paquete (usa la variable `destination`)
   - `WeightKg`: el peso en kilogramos (usa la variable `weightKg`)
3. Mostrar en consola los valores asignados (número de seguimiento, destino y peso).
4. Modificar la propiedad `Destination` agregando el texto ` (Actualizado)` al final.
5. Mostrar en consola los valores finales con el destino actualizado.

### Restricción importante:
Solo usa propiedades para asignar y modificar los datos. No uses métodos ni lógica adicional.

## Herramientas Disponibles

**Clase:** `Package` (Logistics)
- **Constructor sin parámetros:** `new Package()`
- **Propiedad `TrackingNumber`:** Número de seguimiento (lectura/escritura)
- **Propiedad `Destination`:** Destino del paquete (lectura/escritura)
- **Propiedad `WeightKg`:** Peso en kilogramos (lectura/escritura)

**Tarea:** Registrar el paquete con los datos iniciales, actualizar el destino, y mostrar ambos estados.

## Variables Disponibles

En Program.cs puedes modificar:
```csharp
string trackingNumber = "PKG-2024-001";
string destination = "Madrid, España";
double weightKg = 2.5;
```

## Salida

El programa imprime:
```
=== Sistema de Seguimiento de Paquetes ===
Paquete creado:
  Tracking: <tracking>
  Destino: <destino>
  Peso: <peso> kg

Modificando destino a: <nuevo_destino>

Paquete actualizado:
  Tracking: <tracking>
  Destino: <nuevo_destino>
  Peso: <peso> kg
```

## Ejemplo de Salida

### Con valores por defecto:

**Salida:**
```
=== Sistema de Seguimiento de Paquetes ===
Paquete creado:
  Tracking: PKG-2024-001
  Destino: Madrid, España
  Peso: 2.5 kg

Modificando destino a: Madrid, España (Actualizado)

Paquete actualizado:
  Tracking: PKG-2024-001
  Destino: Madrid, España (Actualizado)
  Peso: 2.5 kg
```

### Con trackingNumber = "INT-2024-999", destination = "New York, USA", weightKg = 15.8:

**Salida:**
```
=== Sistema de Seguimiento de Paquetes ===
Paquete creado:
  Tracking: INT-2024-999
  Destino: New York, USA
  Peso: 15.8 kg

Modificando destino a: New York, USA (Actualizado)

Paquete actualizado:
  Tracking: INT-2024-999
  Destino: New York, USA (Actualizado)
  Peso: 15.8 kg
```

## Conceptos Clave

- **Namespace:** Requiere `using Logistics;`
- **Asignación de Estado:** Uso de setters tras construcción vacía
- **Separación de Conceptos:** Propiedades de solo lectura se verán en ejercicios posteriores
- **Dominio Nuevo:** Introducción a logística sin lógica de métodos aún
