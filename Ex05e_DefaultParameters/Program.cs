/* ======================================================================
 * Ejercicio 05e - Parámetros por Defecto (Domain)
 * Descripción: Practicar sobrecarga que simula parámetros por defecto
 *              usando Order.ApplyPercentageDiscount.
 * ====================================================================== */

using Domain;

Console.WriteLine("=== Sistema de Descuentos ===");

// 🧪 Cambia estos valores para experimentar
string skuProducto = "MONITOR-001";
decimal precioProducto = 299.99m;
int cantidad = 3;
decimal porcentajeDescuento = 10m;
string razonPersonalizada = "Cliente VIP";

// TODO 🧩 Sigue estos pasos para implementar la función:
// 1. Crea un producto con los parámetros dados
// 2. PEDIDO 1: Crea cliente, pedido, añade línea y aplica descuento CON razón personalizada
// 3. Muestra el total del pedido 1
// 4. PEDIDO 2: Crea otro cliente, pedido, añade línea y aplica descuento SIN razón (usa sobrecarga)
// 5. Muestra el total del pedido 2
// 6. Ambos totales deben ser iguales (mismo descuento aplicado)
// (Elimina este comentario y la excepción al terminar)
