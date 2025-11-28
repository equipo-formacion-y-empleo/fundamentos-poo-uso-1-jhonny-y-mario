/* ======================================================================
 * Ejercicio 04b - Métodos Estáticos (Domain)
 * Descripción: Practicar métodos estáticos de utilidad usando la clase
 *              Money del dominio comercial (no solo factories).
 * ====================================================================== */

Console.WriteLine("=== Conversor de Monedas ===");

// 🧪 Cambia estos valores para experimentar
decimal precio1 = 99.99m;
decimal precio2 = 149.99m;
decimal tasaUSD = 1.1m;
decimal descuento = 15m;

// TODO 🧩 Sigue estos pasos para implementar la función:
// 1. Usa el factory method Money.Euros(cantidadEUR) para crear el importe original
// 2. Calcula la cantidad convertida: cantidadEUR * tasaConversion
// 3. Crea el importe convertido usando new Money(cantidad, monedaDestino)
// 4. Muestra el importe original y el convertido
// 5. Usa Money.Format() si existe, o ToString() para formatear
// (Elimina este comentario y la excepción al terminar)
