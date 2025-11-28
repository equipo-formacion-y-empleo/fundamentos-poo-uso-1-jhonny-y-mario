# Ex04a_StaticMethodsSystem

## Problema

En este ejercicio trabajarás con **métodos estáticos** de las clases `Math` y `DateTime` del framework .NET. Los métodos estáticos son funciones de utilidad que no requieren crear instancias de la clase.

Debes realizar varios cálculos matemáticos y consultas de calendario usando estos métodos estáticos.

### Pasos a realizar:
1. **Calcular potencia**: Usa `Math.Pow(baseValue, exponente)` para calcular `baseValue` elevado a `exponente`.
2. **Calcular raíz cuadrada**: Usa `Math.Sqrt(numero)` para calcular la raíz cuadrada del número.
3. **Redondear π**: Usa `Math.Round(Math.PI, 2)` para redondear el valor de Pi a 2 decimales.
4. **Obtener días de febrero**: Usa `DateTime.DaysInMonth(year, 2)` para saber cuántos días tiene febrero en el año especificado (el mes 2 es febrero).
5. **Verificar año bisiesto**: Usa `DateTime.IsLeapYear(year)` para determinar si el año es bisiesto.
6. **Mostrar resultados**: Imprime todos los cálculos realizados de forma clara.

### Característica importante:
Todos estos métodos son **estáticos** - los llamas directamente desde la clase (`Math.Metodo()`, `DateTime.Metodo()`) sin necesidad de crear un objeto.

## Herramientas Disponibles

**Clase:** `Math` (System) - Métodos estáticos matemáticos
- `Math.Pow(double, double)` - Calcula potencias (base^exponente)
- `Math.Sqrt(double)` - Raíz cuadrada
- `Math.Round(double, int)` - Redondea a N decimales

**Clase:** `DateTime` (System) - Métodos estáticos de calendario
- `DateTime.DaysInMonth(int year, int month)` - Días en un mes (febrero = 2)
- `DateTime.IsLeapYear(int year)` - Verifica si es año bisiesto

**Nota:** Estos métodos son estáticos (utility functions) - no necesitas crear instancias.

## Variables Disponibles

En Program.cs puedes modificar:
```csharp
double baseValue = 2;
double exponente = 8;
double numero = 144;
int year = 2024;
```

## Salida

El programa imprime:
```
=== Calculadora Científica ===

Operaciones con Math:
<base>^<exp> = <resultado>
√<numero> = <resultado>
<numero> redondeado a 2 decimales = <resultado>

Operaciones con DateTime:
Días en febrero de <año>: <dias>
¿Es año bisiesto?: <true/false>
```

## Ejemplo de Salida

### Con valores por defecto:

**Salida:**
```
=== Calculadora Científica ===

Operaciones con Math:
2^8 = 256
√144 = 12
3.14159 redondeado a 2 decimales = 3.14

Operaciones con DateTime:
Días en febrero de 2024: 29
¿Es año bisiesto?: True
```

### Con baseValue = 3, exponente = 4, numero = 81, year = 2025:

**Salida:**
```
=== Calculadora Científica ===

Operaciones con Math:
3^4 = 81
√81 = 9
3.14159 redondeado a 2 decimales = 3.14

Operaciones con DateTime:
Días en febrero de 2025: 28
¿Es año bisiesto?: False
```

## Conceptos Clave

- **Métodos Estáticos:** No requieren crear instancias (`Math.Pow()` vs `list.Add()`)
- **Utility Classes:** `Math` solo tiene métodos estáticos (clase utilitaria)
- **Sin Estado:** Los métodos estáticos no acceden a estado de instancia
- **Llamada Directa:** Se llaman usando el nombre de la clase
- **Funciones Puras:** Devuelven un resultado sin efectos secundarios
