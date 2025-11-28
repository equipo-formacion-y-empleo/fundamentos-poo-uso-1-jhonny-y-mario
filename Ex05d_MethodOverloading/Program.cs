/* ======================================================================
 * Ejercicio 05d - Sobrecarga de Métodos (Domain)
 * Descripción: Practicar sobrecarga de métodos usando Order.AddLine
 *              con diferentes parámetros.
 * ====================================================================== */

using Domain;

Console.WriteLine("=== Sistema de Pedidos con Sobrecarga ===");

// 🧪 Cambia estos valores para experimentar
string skuProducto1 = "LAPTOP-001";
decimal precioProducto1 = 899.99m;
int cantidadLinea1 = 2;
string skuProducto2 = "MOUSE-002";
decimal precioProducto2 = 25.50m;
int cantidadLinea2 = 5;
decimal precioEspecial = 20.00m;

// TODO 🧩 Sigue estos pasos para implementar la función:
// 1. Crea el primer producto con skuProducto1, descripción y precio
// 2. Crea el segundo producto con skuProducto2, descripción y precio
// 3. Crea un cliente y un pedido
// 4. Añade la primera línea usando AddLine(product, quantity) - sobrecarga simplificada
// 5. Añade la segunda línea usando AddLine(product, quantity, unitPrice) con precio especial
// 6. Muestra el total del pedido
// (Elimina este comentario y la excepción al terminar)
