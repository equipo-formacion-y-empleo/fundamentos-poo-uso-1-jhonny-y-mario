# Ex05c_ParametersLogistics

## Problema

En este ejercicio trabajarás con la clase `ShippingCalculator` del dominio de logística para calcular el costo de un envío aplicando descuentos secuenciales.

Debes calcular el costo base de un envío según su peso y distancia, aplicar dos descuentos de forma acumulativa, y mostrar el desglose completo del cálculo.

### Pasos a realizar:
1. **Calcular costo base**: Usa el método estático `ShippingCalculator.CalculateCost(peso, distancia)` para obtener el costo inicial del envío.
2. **Aplicar primer descuento**: Usa el método estático `ShippingCalculator.ApplyDiscount(costoBase, descuento1)` para aplicar el primer porcentaje de descuento.
3. **Aplicar segundo descuento**: Aplica el segundo descuento sobre el resultado anterior usando `ShippingCalculator.ApplyDiscount(costoConDescuento1, descuento2)`.
4. **Calcular ahorro**: Resta el costo final del costo base para obtener el ahorro total. Calcula el porcentaje de ahorro: `(ahorro / costoBase) * 100`.
5. **Mostrar desglose**: Imprime el costo base, ambos descuentos aplicados, el costo final, el ahorro y el porcentaje de ahorro.

### Característica importante:
Los descuentos son **acumulativos** - cada descuento se aplica sobre el resultado del cálculo anterior, no sobre el costo base original.

## Herramientas Disponibles

**Clase:** `ShippingCalculator` (Logistics) - Requiere `using Logistics;`
- **Método estático:** `CalculateCost(double weightKg, int distanceKm)`
  - Devuelve: Costo base (decimal)
  - Fórmula interna: tarifa base + (peso × tarifa_peso) + (distancia × tarifa_distancia)
- **Método estático:** `ApplyDiscount(decimal cost, decimal discountPercent)`
  - Devuelve: Costo con descuento aplicado
  - Validación: Porcentaje entre 0-100

**Cálculos:** 
- Descuentos son acumulativos (aplicar uno tras otro)
- Ahorro total = costo_base - costo_final
- Porcentaje de ahorro = (ahorro / costo_base) × 100

## Comportamiento

El programa debe:
1. Calcular el costo base de un envío
2. Aplicar descuentos múltiples usando `ApplyDiscount()` con `params`
3. Usar `out` para obtener el detalle del descuento
4. Mostrar el desglose completo del cálculo

## Variables Disponibles

En Program.cs puedes modificar:
```csharp
double peso = 10.0;
int distancia = 500;
decimal descuento1 = 10m;
decimal descuento2 = 5m;
```

## Salida

El programa imprime:
```
=== Calculadora de Envíos ===

Parámetros:
- Peso: <peso> kg
- Distancia: <distancia> km

Costo base: <costo_base> €

Aplicando descuentos:
- Descuento 1: <desc1>%
- Descuento 2: <desc2>%

Desglose:
- Descuento total: <descuento_total> €
- Costo final: <costo_final> €

Ahorro: <ahorro> € (<porcentaje>%)
```

## Ejemplo de Salida

### Con valores por defecto:

**Salida:**
```
=== Calculadora de Envíos ===

Parámetros:
- Peso: 10.0 kg
- Distancia: 500 km

Costo base: 75.00 €

Aplicando descuentos:
- Descuento 1: 10%
- Descuento 2: 5%

Desglose:
- Descuento total: 11.25 € (10% + 5% sobre resto)
- Costo final: 63.75 €

Ahorro: 11.25 € (15.0%)
```

### Con peso = 25.5, distancia = 1000, descuento1 = 15m, descuento2 = 10m:

**Salida:**
```
=== Calculadora de Envíos ===

Parámetros:
- Peso: 25.5 kg
- Distancia: 1000 km

Costo base: 165.00 €

Aplicando descuentos:
- Descuento 1: 15%
- Descuento 2: 10%

Desglose:
- Descuento total: 38.78 € (15% + 10% sobre resto)
- Costo final: 126.23 €

Ahorro: 38.78 € (23.5%)
```

### Con peso = 5.0, distancia = 200, descuento1 = 0m, descuento2 = 0m:

**Salida:
```
=== Calculadora de Envíos ===

Parámetros:
- Peso: 5.0 kg
- Distancia: 200 km

Costo base: 30.00 €

Aplicando descuentos:
(Sin descuentos)

Desglose:
- Descuento total: 0.00 €
- Costo final: 30.00 €

Ahorro: 0.00 € (0.0%)
```

## Conceptos Clave

- **Namespace:** Requiere `using Logistics;`
- **Parámetro `out`:** Devuelve el desglose del descuento además del costo final
- **Parámetro `params`:** Permite aplicar cantidad variable de descuentos
- **Descuentos Acumulativos:** Cada descuento se aplica sobre el resultado anterior
- **Cálculos de Negocio:** Fórmulas específicas del dominio de logística
