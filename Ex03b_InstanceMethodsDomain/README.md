# Ex03b_InstanceMethodsDomain

## Problema

En este ejercicio simularás el flujo completo de un pedido comercial usando las clases del dominio de negocio. El objetivo es practicar el uso de **métodos de instancia** que modifican el estado de los objetos.

Debes crear un pedido, agregarle productos, calcular el subtotal, aplicar un descuento y mostrar el resultado final.

### Pasos a realizar:
1. **Crear un cliente**: Usa la clase `Customer` para crear un cliente con nombre y email.
2. **Crear un producto**: Usa la clase `Product` con el SKU, una descripción y el precio (objeto `Money`).
3. **Crear un pedido**: Usa la clase `Order` con un número de pedido (clase `OrderNumber`) y el cliente creado.
4. **Agregar una línea al pedido**: Usa el método `AddLine()` del pedido para añadir el producto con la cantidad especificada.
5. **Calcular el subtotal**: Obtén el total del pedido antes del descuento usando la propiedad o método `Total` o `GetTotal()`.
6. **Aplicar un descuento**: Usa el método `ApplyPercentageDiscount()` para aplicar el porcentaje de descuento.
7. **Mostrar el resultado**: Muestra el total final y el número de líneas del pedido.

## Variables Disponibles

En `Program.cs` puedes modificar:
```csharp
string sku = "LAPTOP-001";
int cantidad = 2;
decimal precio = 799.99m;
decimal descuento = 10m;
```

## Herramientas Disponibles

**Clase:** `Customer` (Domain)
- **Constructor:** `new Customer(string name, string email)` - Cliente básico

**Clase:** `Product` (Domain)
- **Constructor:** `new Product(string sku, string description, Money price)`

**Clase:** `Order` (Domain)
- **Constructor:** `new Order(OrderNumber, Customer)` - Pedido vacío
- **Método:** `AddLine(Product, int, Money)` - Agregar línea con cantidad
- **Método:** `ApplyPercentageDiscount(decimal, string)` - Aplicar descuento %
- **Método/Propiedad:** `GetTotal()` o `Total` - Obtener total actual
- **Propiedad:** `Lines.Count` - Número de líneas

**Clase:** `Money` (Domain)
- **Constructor:** `new Money(decimal amount, string currency)` - Crear importe con moneda

**Clase:** `OrderNumber` (Domain)
- **Constructor:** `new OrderNumber(string)` - Ej: "ORD-12345"

## Salida Esperada

El programa imprime:
```
=== Sistema de Pedidos ===
Creando pedido ID: <order_id>

Agregando líneas al pedido...
Línea agregada: <cantidad>x <sku> @ <precio> cada uno

Subtotal antes de descuento: <subtotal>

Aplicando descuento del <porcentaje>%...
Descuento aplicado: <descuento>

Total final: <total>
Total de líneas: <count>
```

## Ejemplo de Salida

**Con valores por defecto:**
```
=== Sistema de Pedidos ===
Creando pedido ID: a1b2c3d4-e5f6-7890-abcd-ef1234567890

Agregando líneas al pedido...
Línea agregada: 2x LAPTOP-001 @ 799.99 cada uno

Subtotal antes de descuento: 1599.98

Aplicando descuento del 10%...
Descuento aplicado: 159.998

Total final: 1439.982

Total de líneas: 1
```

## Conceptos Clave

- **Métodos de Negocio:** `AddLine()`, `ApplyDiscount()` son operaciones del dominio
- **Cálculos:** `CalculateTotal()` realiza operaciones sobre el estado interno
- **Estado Acumulativo:** Cada línea se suma al pedido
- **Validaciones:** Los métodos validan parámetros antes de modificar el estado
- **Namespace:** Requiere `using Domain;`
