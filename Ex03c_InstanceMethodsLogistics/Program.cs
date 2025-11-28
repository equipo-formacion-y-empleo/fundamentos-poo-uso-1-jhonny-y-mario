/* ======================================================================
 * Ejercicio 03c - Métodos de Instancia (Logistics)
 * Descripción: Practicar métodos de instancia para gestionar el ciclo
 *              de vida usando Shipment del dominio de logística.
 * ====================================================================== */

Console.WriteLine("=== Sistema de Gestión de Envíos ===");

// 🧪 Cambia estos valores para experimentar
string tracking1 = "PKG-001";
double peso1 = 5.5;
string tracking2 = "PKG-002";

// TODO 🧩 Sigue estos pasos para implementar la función:
// 1. Crea un Shipment con un ID generado
// 2. Crea dos paquetes con los tracking numbers y pesos recibidos (peso2 = 3.2 kg fijo)
// 3. Usa AddPackage() para agregar ambos paquetes
// 4. Usa GetTotalWeight() para obtener y mostrar el peso total
// 5. Usa Ship() para cambiar el estado a Shipped
// 6. Usa Deliver() para cambiar el estado a Delivered
// 7. Muestra el resumen final con estado y número de paquetes
// (Elimina este comentario y la excepción al terminar)
