/* ======================================================================
 * Ejercicio 03b - Métodos de Instancia (Domain)
 * Descripción: Practicar métodos de instancia de negocio usando la
 *              clase Order del dominio comercial.
 * ====================================================================== */

using Domain;

Console.WriteLine("=== Sistema de Pedidos ===");

// 🧪 Cambia estos valores para experimentar
string sku = "LAPTOP-001";
int cantidad = 2;
decimal precio = 799.99m;
decimal descuento = 10m;

// TODO 🧩 Sigue estos pasos para implementar la función:
// 1. Crea un Customer y un Product con los datos recibidos
// 2. Crea un Order con OrderNumber y el customer
// 3. Usa AddLine() para agregar el producto con la cantidad
// 4. Calcula el subtotal usando CalculateTotal()
// 5. Usa ApplyDiscount() para aplicar el descuento
// 6. Calcula el total final
// 7. Muestra el resumen con subtotal, descuento y total
