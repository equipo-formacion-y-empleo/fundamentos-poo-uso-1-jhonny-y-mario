# Ex05b_ParametersDomain

## Problema

En este ejercicio trabajarás con dos tipos especiales de parámetros en C#: `ref` y `params`, usando las clases del dominio comercial.

El parámetro `ref` permite que un método modifique directamente una variable que le pasas. Lo usarás con `InventoryService.ProcessItem()` para llevar un contador de items procesados.

El parámetro `params` permite pasar múltiples mensajes a un método. Lo usarás con `InventoryService.LogUpdates()` para registrar varios mensajes a la vez.

### Pasos a realizar:
1. **Inicializar contador**: Crea una variable `int contador = 0` que se usará para contar los items procesados.
2. **Procesar items**: Para cada uno de los tres SKUs, llama a `InventoryService.ProcessItem(sku, ref contador)`. El parámetro `ref` permite que el método incremente directamente el contador.
3. **Registrar actualizaciones**: Llama a `InventoryService.LogUpdates()` pasando múltiples mensajes como argumentos separados. El parámetro `params` permite pasar cualquier cantidad de mensajes.
4. **Mostrar resultados**: Imprime el contador final y los mensajes registrados.

### Características importantes:
- **`ref`**: La variable se pasa por referencia - los cambios dentro del método afectan a la variable original.
- **`params`**: Permite pasar una cantidad variable de argumentos del mismo tipo sin necesidad de crear un array explícitamente.

## Herramientas Disponibles

**Clase:** `InventoryService` (Domain)
- **Método:** `ProcessItem(string sku, ref int counter)` 
  - Parámetro `ref`: Modifica el contador externo sumándole 1
  - Muestra mensaje de procesamiento
- **Método:** `LogUpdates(params string[] messages)`
  - Parámetro `params`: Acepta cantidad variable de mensajes
  - Imprime cada mensaje con prefijo "LOG:"

**Uso:** Crear instancia con `new InventoryService()`, crear contador `int count = 0`

## Comportamiento

El programa debe:
1. Usar `ProcessItem()` con parámetro `ref` para modificar un contador externo
2. Usar `LogUpdates()` con parámetro `params` para registrar múltiples mensajes
3. Demostrar cómo `ref` modifica variables externas
4. Mostrar el resultado del procesamiento

## Variables Disponibles

En Program.cs puedes modificar:
```csharp
string sku1 = "ITEM-001";
string sku2 = "ITEM-002";
string sku3 = "ITEM-003";
```

## Salida

El programa imprime:
```
=== Sistema de Procesamiento de Inventario ===

Contador inicial: 0

Procesando ítems...
- <sku1> procesado
- <sku2> procesado
- <sku3> procesado

Contador final: <count>

Log de actualizaciones:
[<timestamp>] <mensaje1>
[<timestamp>] <mensaje2>
[<timestamp>] <mensaje3>
```

## Ejemplo de Salida

### Con valores por defecto:

**Salida:**
```
=== Sistema de Procesamiento de Inventario ===

Contador inicial: 0

Procesando ítems...
- ITEM-001 procesado
- ITEM-002 procesado
- ITEM-003 procesado

Contador final: 3

Log de actualizaciones:
[10:30:00] Ítem ITEM-001 procesado
[10:30:00] Ítem ITEM-002 procesado
[10:30:00] Ítem ITEM-003 procesado
[10:30:00] Procesamiento completado: 3 ítems
```

### Con sku1 = "LAPTOP-001", sku2 = "MOUSE-002", sku3 = "KEYBOARD-003":

**Salida:**
```
=== Sistema de Procesamiento de Inventario ===

Contador inicial: 0

Procesando ítems...
- LAPTOP-001 procesado
- MOUSE-002 procesado
- KEYBOARD-003 procesado

Contador final: 3

Log de actualizaciones:
[10:30:00] Ítem LAPTOP-001 procesado
[10:30:00] Ítem MOUSE-002 procesado
[10:30:00] Ítem KEYBOARD-003 procesado
[10:30:00] Procesamiento completado: 3 ítems
```

## Conceptos Clave

- **Parámetro `ref`:** Permite modificar una variable del llamador
- **Parámetro `params`:** Acepta cantidad variable de strings para logging
- **Efectos Secundarios:** `ref` crea efectos secundarios intencionales
- **Logging Flexible:** `params` permite logs con diferente cantidad de mensajes
- **Namespace:** Requiere `using Domain;`
