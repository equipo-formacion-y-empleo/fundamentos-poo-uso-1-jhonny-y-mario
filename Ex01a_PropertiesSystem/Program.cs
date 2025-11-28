/* ======================================================================
 * Ejercicio 01a - Propiedades e Instanciación (System)
 * Descripción: Explorar SOLO propiedades de StringBuilder (Capacity,
 *              Length e indexador) sin usar métodos como Append/ToString.
 * ====================================================================== */

Console.WriteLine("=== Exploración de StringBuilder ===");

// 🧪 Cambia estos valores para experimentar
int targetLength = 10;

// TODO 🧩 Implementa los pasos:
// 1. Crea un StringBuilder vacío (constructor sin parámetros)
// 2. Muestra Length y Capacity iniciales
// 3. Establece Capacity a 100 (propiedad de lectura/escritura)
// 4. Establece Length a targetLength (reserva espacio) -> agrega '\0'
// 5. Escribe caracteres en posiciones sucesivas usando el indexador
//    para formar "API-DEMO" (o parte si targetLength < 8)
// 6. Recorre los caracteres y construye un string manual sin usar ToString()
// 7. Muestra Length y Capacity finales y el contenido parcial
