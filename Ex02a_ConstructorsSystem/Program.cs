/* ======================================================================
 * Ejercicio 02a - Constructores (System)
 * Descripción: Practicar sobrecarga de constructores usando DateTime
 *              y TimeSpan del framework .NET.
 * ====================================================================== */

Console.WriteLine("=== Sistema de Citas Médicas ===");

// 🧪 Cambia estos valores para experimentar
int year = 2024;
int month = 12;
int day = 25;
int hour = 14;
int durationHours = 2;

// TODO 🧩 Sigue estos pasos para implementar la función:
// 1. Crea un DateTime usando el constructor con parámetros (year, month, day, hour, 0, 0)
// 2. Crea un TimeSpan para la duración usando new TimeSpan(durationHours, 0, 0)
// 3. Calcula la hora de finalización sumando el TimeSpan al DateTime
// 4. Muestra la fecha actual usando DateTime.Now
// 5. Calcula días hasta la cita usando (citaDateTime - DateTime.Now).Days
// 6. Muestra todos los resultados formateados
