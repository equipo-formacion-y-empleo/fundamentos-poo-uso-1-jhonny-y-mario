# Ex04b_StaticMethodsDomain

## Problema

En este ejercicio trabajarás con **métodos estáticos de utilidad** de la clase `Money` del dominio comercial. Estos métodos permiten realizar operaciones entre objetos `Money` sin necesidad de llamarlos desde una instancia específica.

Debes comparar dos precios, convertir monedas, calcular descuentos y determinar el mayor precio.

### Pasos a realizar:
1. **Crear dos importes**: Usa el método estático `Money.Euros(precio1)` y `Money.Euros(precio2)` para crear dos objetos Money en euros.
2. **Comparar importes**: Usa el método estático `Money.Compare(importe1, importe2)` para obtener la diferencia entre ambos precios.
3. **Obtener el mayor**: Usa el método estático `Money.Max(importe1, importe2)` para determinar cuál es el precio más alto.
4. **Convertir moneda**: Usa el método estático `Money.Convert(importe1, "USD", tasaUSD)` para convertir el primer importe a dólares usando la tasa de cambio.
5. **Calcular descuento**: Usa el método estático `Money.CalculateDiscount(importe1, descuento)` para aplicar un porcentaje de descuento.
6. **Mostrar resultados**: Imprime todos los cálculos de forma clara, mostrando los importes con su moneda.

### Característica importante:
Los métodos estáticos de `Money` actúan como **funciones de utilidad** que operan sobre objetos Money, pero se llaman desde la clase (`Money.Metodo()`) en lugar de desde una instancia.

## Herramientas Disponibles

**Clase:** `Money` (Domain) - Métodos estáticos de utilidad:
- **Factory method:** `Money.Euros(decimal)` - Crea importe en EUR
- **`Money.Compare(Money, Money)`** - Devuelve diferencia entre dos importes (misma moneda)
- **`Money.Max(Money, Money)`** - Devuelve el importe mayor (misma moneda)
- **`Money.Convert(Money, string, decimal)`** - Convierte a otra moneda
- **`Money.CalculateDiscount(Money, decimal)`** - Aplica descuento porcentual
- **Propiedades:** `Amount`, `Currency` - Para mostrar valores

## Comportamiento

El programa debe:
1. Crear objetos Money usando factory methods estáticos
2. Convertir entre diferentes monedas usando `ConvertTo()`
3. Formatear valores monetarios usando `Format()`
4. Comparar valores en diferentes monedas
5. Mostrar resultados formateados

## Variables Disponibles

En Program.cs puedes modificar:
```csharp
decimal precio1 = 99.99m;
decimal precio2 = 149.99m;
decimal tasaUSD = 1.1m;
decimal descuento = 15m;
```

## Salida

El programa imprime:
```
=== Conversor de Monedas ===

Cantidad original: <cantidad> <moneda>
Moneda destino: <moneda_destino>
Tasa de conversión: <tasa>

Resultado: <cantidad_convertida> <moneda_destino>

Formato local:
- EUR: <formato_eur>
- USD: <formato_usd>
```

## Ejemplo de Salida

### Con valores por defecto:

**Salida:**
```
=== Conversor de Monedas ===

Cantidad original: 100 EUR
Moneda destino: USD
Tasa de conversión: 1.1

Resultado: 110 USD

Formato local:
- EUR: 100,00 €
- USD: $110.00
```

### Con precio1 = 250m, precio2 = 0m, tasaUSD = 0.85m:

**Salida:**
```
=== Conversor de Monedas ===

Cantidad original: 250 EUR
Moneda destino: GBP
Tasa de conversión: 0.85

Resultado: 212.5 GBP

Formato local:
- EUR: 250,00 €
- GBP: £212.50
```

## Conceptos Clave

- **Factory Methods:** `Money.EUR()`, `Money.USD()` crean instancias
- **Métodos Estáticos del Dominio:** Operaciones que no dependen de instancia
- **Conversión de Moneda:** Método estático que crea nuevos objetos
- **Formato:** Método estático para representar valores monetarios
- **Namespace:** Requiere `using Domain;`
