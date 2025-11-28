# Ex01b_PropertiesDomain

## Problema

En este ejercicio trabajarás con la clase `Product` del dominio comercial para gestionar productos. El objetivo es practicar el uso de propiedades para asignar y modificar el estado de un objeto.

Debes crear un producto vacío y luego asignar sus datos (SKU, descripción y precio) usando únicamente las propiedades de la clase, sin usar constructores con parámetros.

### Pasos a realizar:
1. Crear un objeto `Product` usando el constructor sin parámetros: `new Product()`.
2. Asignar valores a las propiedades:
   - `Sku`: el código del producto (usa la variable `sku`)
   - `Description`: la descripción del producto (usa la variable `nombre`)
   - `Price`: el precio del producto (crea un objeto `Money` con la variable `precio`)
3. Mostrar en consola el estado inicial del producto (SKU, descripción y precio).
4. Modificar la propiedad `Description` agregando el texto ` (Reacondicionado)` al final.
5. Mostrar en consola el estado final del producto con la descripción actualizada.

### Restricción importante:
Todo debe hacerse mediante propiedades. No uses constructores con parámetros ni métodos auxiliares para esta tarea.

## Herramientas Disponibles

**Clase:** `Product` (Domain)
- **Constructor sin parámetros:** `new Product()`
- **Propiedad `Sku`:** Código único del producto (lectura/escritura)
- **Propiedad `Description`:** Descripción del producto (lectura/escritura)
- **Propiedad `Price`:** Precio como objeto `Money` (lectura/escritura)

**Clase:** `Money` (Domain)
- **Constructor:** `new Money(decimal amount, string currency)` - Crea un objeto Money con cantidad y moneda

**Tarea:** Mostrar el producto inicial, modificar la descripción, y mostrar el resultado actualizado.

## Variables Disponibles

En Program.cs puedes modificar:
```csharp
string sku = "LAPTOP-001";
string nombre = "Laptop HP 15\"";
decimal precio = 799.99m;
```

## Salida

El programa imprime:
```
=== Gestión de Productos ===
Producto creado:
  SKU: <sku>
  Descripción: <nombre>
  Precio: <precio>

Modificando descripción a: <nueva_descripcion>

Producto actualizado:
  SKU: <sku>
  Descripción: <nueva_descripcion>
  Precio: <precio>
```

## Ejemplo de Salida

### Con valores por defecto:

**Salida:**
```
=== Gestión de Productos ===
Producto creado:
  SKU: LAPTOP-001
  Descripción: Laptop HP 15"
  Precio: 799.99

Modificando descripción a: Laptop HP 15" (Reacondicionado)

Producto actualizado:
  SKU: LAPTOP-001
  Descripción: Laptop HP 15" (Reacondicionado)
  Precio: 799.99
```

### Con sku = "MOUSE-002", nombre = "Mouse Logitech", precio = 29.99m:

**Salida:**
```
=== Gestión de Productos ===
Producto creado:
  SKU: MOUSE-002
  Descripción: Mouse Logitech
  Precio: 29.99

Modificando descripción a: Mouse Logitech Inalámbrico

Producto actualizado:
  SKU: MOUSE-002
  Descripción: Mouse Logitech Inalámbrico
  Precio: 29.99
```

## Conceptos Clave

- **Dominio Comercial:** Clases que modelan conceptos del negocio
- **Setters:** Permiten asignar estado tras la construcción vacía
- **Post-Procesamiento:** Se puede modificar el nombre para reflejar estado
- **Namespace:** Requiere `using Domain;`
