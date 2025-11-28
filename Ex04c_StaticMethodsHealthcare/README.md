# Ex04c_StaticMethodsHealthcare

## Problema

En este ejercicio trabajarás con **métodos estáticos** de la clase `HealthMetrics` del dominio de salud. Estos métodos permiten realizar cálculos médicos comunes sin necesidad de crear objetos.

Debes calcular el Índice de Masa Corporal (IMC), determinar su categoría, y calcular la frecuencia cardíaca máxima y zona aeróbica para una persona.

### Pasos a realizar:
1. **Calcular IMC**: Usa el método estático `HealthMetrics.CalculateBMI(pesoKg, alturaM)` para calcular el Índice de Masa Corporal.
2. **Obtener categoría**: Usa el método estático `HealthMetrics.GetBMICategory(bmi)` para determinar la categoría (Underweight, Normal, Overweight, Obese) según el IMC calculado.
3. **Calcular frecuencia cardíaca máxima**: Usa el método estático `HealthMetrics.CalculateMaxHeartRate(edad)` para obtener el pulso máximo recomendado.
4. **Calcular zona aeróbica**: Multiplica la frecuencia máxima por 0.70 y 0.85 para obtener el rango de la zona aeróbica (70% - 85% del máximo).
5. **Mostrar resultados**: Imprime un resumen completo con todos los valores calculados.

### Característica importante:
Todos los cálculos se realizan mediante **métodos estáticos** - funciones de utilidad médica que no requieren crear instancias de `HealthMetrics`.

## Herramientas Disponibles

**Clase:** `HealthMetrics` (Healthcare) - Requiere `using Healthcare;`
- **Método estático:** `CalculateBMI(double weightKg, double heightM)` - Calcula IMC
- **Método estático:** `GetBMICategory(double bmi)` - Devuelve categoría (string)
- **Método estático:** `CalculateMaxHeartRate(int age)` - Frecuencia cardíaca máxima

**Cálculos adicionales:** Zona aeróbica = 70% y 85% de la FCM

## Comportamiento

El programa debe:
1. Calcular el IMC (Índice de Masa Corporal) usando `CalculateBMI()`
2. Obtener la categoría del IMC usando `GetBMICategory()`
3. Calcular la frecuencia cardíaca máxima usando `CalculateMaxHeartRate()`
4. Mostrar recomendaciones basadas en los resultados

## Variables Disponibles

En Program.cs puedes modificar:
```csharp
double pesoKg = 75;
double alturaM = 1.75;
int edad = 30;
```

## Salida

El programa imprime:
```
=== Calculadora de Salud ===

Datos del paciente:
- Peso: <peso> kg
- Altura: <altura> m
- Edad: <edad> años

Resultados:
- IMC: <imc> (<categoria>)
- Frecuencia cardíaca máxima: <fcm> bpm
- Zona aeróbica (70-85%): <min>-<max> bpm
```

## Ejemplo de Salida

### Con valores por defecto:

**Salida:**
```
=== Calculadora de Salud ===

Datos del paciente:
- Peso: 75 kg
- Altura: 1.75 m
- Edad: 30 años

Resultados:
- IMC: 24.49 (Peso Normal)
- Frecuencia cardíaca máxima: 190 bpm
- Zona aeróbica (70-85%): 133-162 bpm
```

### Con pesoKg = 90, alturaM = 1.70, edad = 45:

**Salida:**
```
=== Calculadora de Salud ===

Datos del paciente:
- Peso: 90 kg
- Altura: 1.70 m
- Edad: 45 años

Resultados:
- IMC: 31.14 (Obesidad)
- Frecuencia cardíaca máxima: 175 bpm
- Zona aeróbica (70-85%): 123-149 bpm
```

## Ejemplos de Categorías

- **IMC < 18.5:** Bajo Peso
- **IMC 18.5-24.9:** Peso Normal
- **IMC 25-29.9:** Sobrepeso
- **IMC ≥ 30:** Obesidad

## Conceptos Clave

- **Namespace:** Requiere `using Healthcare;`
- **Métodos Utilitarios:** Cálculos que no requieren instancia
- **Fórmulas Médicas:** IMC = peso / altura², FCM = 220 - edad
- **Métodos Puros:** Reciben parámetros y devuelven resultados sin efectos secundarios
- **Validaciones:** Los métodos validan que los valores sean positivos
