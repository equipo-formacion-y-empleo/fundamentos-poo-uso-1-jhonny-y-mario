# Ex03a_InstanceMethodsSystem

## Problema

En este ejercicio trabajarás con la clase `List<string>` del framework .NET para gestionar una lista de tareas. El objetivo es practicar el uso de **métodos de instancia** que modifican el estado de una colección.

Debes crear una lista de tareas, agregar elementos, insertar una tarea prioritaria al inicio y eliminar una tarea específica.

### Pasos a realizar:
1. **Crear una lista vacía**: Usa el constructor `new List<string>()` para crear una lista de cadenas de texto.
2. **Agregar tareas iniciales**: Usa el método `Add()` para agregar las tres tareas definidas en las variables (`tarea1`, `tarea2`, `tarea3`).
3. **Insertar tarea prioritaria**: Usa el método `Insert(0, "Tarea Urgente")` para insertar una tarea prioritaria al inicio de la lista (posición 0).
4. **Eliminar una tarea**: Usa el método `Remove()` para eliminar la segunda tarea original de la lista.
5. **Mostrar resultados**: Después de cada operación, muestra el contenido de la lista y al final el número total de tareas usando la propiedad `Count`.

## Herramientas Disponibles

**Clase:** `List<string>` (System.Collections.Generic)
- **Constructor:** `new List<string>()` - Crea lista vacía
- **Método:** `Add(string)` - Agrega elemento al final
- **Método:** `Insert(int index, string)` - Inserta en posición específica
- **Método:** `Remove(string)` - Elimina primera coincidencia del elemento
- **Propiedad:** `Count` - Número de elementos

**Salida esperada:** Mostrar lista inicial, tras inserción urgente, tras cancelación, y total final.

## Variables Disponibles

En Program.cs puedes modificar:
```csharp
string tarea1 = "Revisar emails";
string tarea2 = "Reunión con cliente";
string tarea3 = "Preparar informe";
```

## Salida

El programa imprime:
```
=== Gestor de Tareas ===
Agregando tareas...
Lista actual: <tarea1>, <tarea2>, <tarea3>

Insertando tarea prioritaria al inicio...
Lista actual: <tarea_prioritaria>, <tarea1>, <tarea2>, <tarea3>

Eliminando tarea: <tarea2>
Lista actual: <tarea_prioritaria>, <tarea1>, <tarea3>

Total de tareas: <count>
```

## Ejemplo de Salida

### Con valores por defecto:

**Salida:**
```
=== Gestor de Tareas ===
Agregando tareas...
Lista actual: Revisar emails, Reunión con cliente, Preparar informe

Insertando tarea prioritaria al inicio...
Lista actual: Llamada urgente, Revisar emails, Reunión con cliente, Preparar informe

Eliminando tarea: Reunión con cliente
Lista actual: Llamada urgente, Revisar emails, Preparar informe

Total de tareas: 3
```

### Con tarea1 = "Comprar material", tarea2 = "Entregar proyecto", tarea3 = "Hacer backup":

**Salida:**
```
=== Gestor de Tareas ===
Agregando tareas...
Lista actual: Comprar material, Entregar proyecto, Hacer backup

Insertando tarea prioritaria al inicio...
Lista actual: Llamada urgente, Comprar material, Entregar proyecto, Hacer backup

Eliminando tarea: Entregar proyecto
Lista actual: Llamada urgente, Comprar material, Hacer backup

Total de tareas: 3
```

## Conceptos Clave

- **Colecciones Genéricas:** `List<T>` es una colección tipada
- **Métodos de Instancia:** `Add()`, `Insert()`, `Remove()` modifican el objeto
- **Estado Mutable:** La lista cambia su contenido con cada operación
- **Propiedad Count:** Acceso al tamaño de la colección
- **Índices:** `Insert(0, ...)` inserta en la primera posición
