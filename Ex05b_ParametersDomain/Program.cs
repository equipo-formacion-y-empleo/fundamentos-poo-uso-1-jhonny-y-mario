/* ======================================================================
 * Ejercicio 05b - Parámetros Avanzados (Domain)
 * Descripción: Practicar parámetros ref y params usando
 *              InventoryService del dominio comercial.
 * ====================================================================== */

using Domain;

Console.WriteLine("=== Sistema de Procesamiento de Inventario ===");

// 🧪 Cambia estos valores para experimentar
string sku1 = "ITEM-001";
string sku2 = "ITEM-002";
string sku3 = "ITEM-003";

// TODO 🧩 Sigue estos pasos para implementar la función:
// 1. Crea una instancia de InventoryService
// 2. Crea un contador int processedCount = 0
// 3. Usa ProcessItem(sku, ref processedCount) para procesar los 3 SKUs
// 4. Observa cómo processedCount se modifica por referencia
// 5. Usa LogUpdates() con params para registrar múltiples mensajes en una llamada
// 6. Muestra el contador final y los logs
// (Elimina este comentario y la excepción al terminar)
