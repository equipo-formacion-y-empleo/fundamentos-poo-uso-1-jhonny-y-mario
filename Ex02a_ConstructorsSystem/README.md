# Ex02a_ConstructorsSystem

## Enunciado (Problema)

Implementar directamente en Program.cs para construir una cita y calcular información temporal asociada. Dadas las variables `year`, `month`, `day`, `hour`, `durationHours`:

Requisitos:
1. Crear un `DateTime` que represente la cita (hora exacta, minutos y segundos = 0).
2. Crear un `TimeSpan` con la duración en horas.
3. Calcular la hora de finalización sumando la duración.
4. Calcular los días entre la fecha actual y la fecha de la cita.
5. Mostrar todos los resultados formateados.

Uso exclusivo de constructores y operaciones básicas (`+`, `-`) sobre `DateTime` y `TimeSpan`.

## Herramientas Disponibles

**Clase:** `DateTime` (System)
- **Constructor:** `new DateTime(year, month, day)` - Fecha específica
- **Constructor:** `new DateTime(year, month, day, hour, minute, second)` - Fecha y hora
- **Operador:** `DateTime + TimeSpan` - Suma duraciones
- **Operador:** `DateTime - DateTime` - Diferencia entre fechas (devuelve `TimeSpan`)

**Clase:** `TimeSpan` (System)
- **Constructor:** `new TimeSpan(hours, minutes, seconds)` - Duración
- **Propiedad:** `.Days` - Obtener días de un TimeSpan

## Variables Disponibles

En Program.cs puedes modificar:
```csharp
int year = 2024;
int month = 12;
int day = 25;
int hour = 14;
int durationHours = 2;
```

## Salida

El programa imprime:
```
=== Sistema de Citas Médicas ===
Fecha actual: <fecha_actual>
Cita programada: <fecha_cita> <hora>:00
Duración: <duracion> horas
Hora de finalización: <hora_fin>:00
Días hasta la cita: <dias>
```

## Ejemplo de Salida

### Con valores por defecto:

**Salida:**
```
=== Sistema de Citas Médicas ===
Fecha actual: 25/11/2025
Cita programada: 25/12/2024 14:00
Duración: 2 horas
Hora de finalización: 16:00
Días hasta la cita: -336
```

### Con year = 2025, month = 12, day = 1, hour = 9, durationHours = 3:

**Salida:**
```
=== Sistema de Citas Médicas ===
Fecha actual: 25/11/2025
Cita programada: 01/12/2025 09:00
Duración: 3 horas
Hora de finalización: 12:00
Días hasta la cita: 6
```

## Conceptos Clave

- **Sobrecarga de Constructores:** `DateTime` tiene múltiples constructores
- **Constructores Parametrizados:** Especificar año, mes, día, hora, etc.
- **Operaciones con Objetos:** Sumar `TimeSpan` a `DateTime`
- **Clases Inmutables:** `DateTime` y `TimeSpan` no cambian su estado
