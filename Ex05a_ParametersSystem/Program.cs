/* ======================================================================
 * Ejercicio 05a - Parámetros Avanzados (System)
 * Descripción: Practicar parámetros out y params usando TryParse
 *              y String.Format del framework .NET.
 * ====================================================================== */

Console.WriteLine("=== Sistema de Validación y Formato ===");

// 🧪 Cambia estos valores para experimentar
string input = "42";
string nombre = "Juan";
string edad = "25";

// TODO 🧩 Sigue estos pasos para implementar la función:
// 1. Usa int.TryParse(input, out int numero) para intentar parsear
// 2. Si tiene éxito, muestra el número parseado
// 3. Si falla, muestra mensaje de error
// 4. Usa String.Format() con params para crear mensaje: "Hola {nombre}, tienes {edad} años"
// 5. Muestra el mensaje formateado
// 6. Crea otro mensaje usando String.Format con múltiples valores
