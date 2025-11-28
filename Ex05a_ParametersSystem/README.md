# Ex05a_ParametersSystem

## Problema

En este ejercicio practicarás dos tipos especiales de parámetros en C#: `out` y `params`.

El parámetro `out` permite que un método devuelva múltiples valores. Lo usarás con `int.TryParse()` para intentar convertir un texto a número y obtener tanto el resultado (si tuvo éxito) como el valor convertido.

El parámetro `params` permite pasar una cantidad variable de argumentos a un método. Lo usarás con `String.Format()` para formatear mensajes con múltiples valores.

### Pasos a realizar:
1. **Intentar convertir texto a número**: Usa `int.TryParse(input, out int numero)` para intentar convertir la variable `input` a un entero. El método devuelve `true` si tuvo éxito y coloca el valor convertido en la variable `numero`.
2. **Mostrar el resultado**: Si el parseo fue exitoso, muestra el número obtenido. Si falló, indica que no se pudo convertir.
3. **Formatear un mensaje**: Usa `String.Format("Hola {0}, tienes {1} años", nombre, edad)` para crear un mensaje formateado con las variables `nombre` y `edad`.
4. **Demostrar params**: Crea y muestra una lista con varias palabras usando `String.Format()` o un método similar que acepte múltiples argumentos mediante `params`.

## Herramientas Disponibles

**Método estático:** `int.TryParse(string, out int)` (System)
- Parámetro `out`: Devuelve el número parseado (si tiene éxito)
- Return: `true` si parseo exitoso, `false` si falló
- Ejemplo: `if (int.TryParse("42", out int numero)) { /* uso numero */ }`

**Método estático:** `String.Format(string formato, params object[])` (System)
- Parámetro `params`: Acepta cantidad variable de argumentos
- Ejemplo: `String.Format("Hola {0}, tienes {1} años", nombre, edad)`

## Comportamiento

El programa debe:
1. Usar `int.TryParse()` con parámetro `out` para validar entrada
2. Usar `String.Format()` con parámetro `params` para formatear mensajes
3. Mostrar cómo `out` permite devolver múltiples valores
4. Demostrar el uso de arrays variables con `params`

## Variables Disponibles

En Program.cs puedes modificar:
```csharp
string input = "42";
string nombre = "Juan";
string edad = "25";
```

## Salida

El programa imprime:
```
=== Sistema de Validación y Formato ===

Intentando parsear: "<input>"
Resultado: <éxito/fallo>
Valor parseado: <numero> (o N/A si falla)

Formateando mensaje con params:
<mensaje_formateado>

Procesando múltiples valores:
<valor1>, <valor2>, <valor3>
```

## Ejemplo de Salida

### Con valores por defecto (parseo exitoso):

**Salida:**
```
=== Sistema de Validación y Formato ===

Intentando parsear: "42"
Resultado: ✓ Parseo exitoso
Valor parseado: 42

Formateando mensaje con params:
Hola Juan, tienes 25 años

Procesando múltiples valores:
Valor 1: Hola
Valor 2: Juan
Valor 3: tienes
Valor 4: 25
Valor 5: años
```

### Con input = "abc", nombre = "María", edad = "30" (parseo fallido):

**Salida:**
```
=== Sistema de Validación y Formato ===

Intentando parsear: "abc"
Resultado: ✗ Parseo fallido
Valor parseado: N/A

Formateando mensaje con params:
Hola María, tienes 30 años

Procesando múltiples valores:
Valor 1: Hola
Valor 2: María
Valor 3: tienes
Valor 4: 30
Valor 5: años
```

## Conceptos Clave

- **Parámetro `out`:** Permite devolver un valor adicional desde un método
- **TryParse Pattern:** Devuelve `bool` (éxito) + valor por `out`
- **Parámetro `params`:** Permite pasar cantidad variable de argumentos
- **String.Format:** Usa `params object[]` para formatear strings
- **Múltiples Retornos:** `out` permite que un método "devuelva" varios valores
