/* ======================================================================
 * Ejercicio 05c - Parámetros Avanzados (Logistics)
 * Descripción: Practicar parámetros out y params usando
 *              ShippingCalculator del dominio de logística.
 * ====================================================================== */

using Logistics;

Console.WriteLine("=== Calculadora de Envíos ===");

// 🧪 Cambia estos valores para experimentar
double peso = 10.0;
int distancia = 500;
decimal descuento1 = 10m;
decimal descuento2 = 5m;

// TODO 🧩 Sigue estos pasos para implementar la función:
// 1. Usa ShippingCalculator.CalculateCost(peso, distancia) para obtener el costo base
// 2. Usa ShippingCalculator.ApplyDiscount() con params para aplicar múltiples descuentos
// 3. Si ApplyDiscount tiene parámetro out, úsalo para obtener el desglose
// 4. Muestra el costo base, descuentos aplicados y costo final
// 5. Calcula el ahorro total y el porcentaje
