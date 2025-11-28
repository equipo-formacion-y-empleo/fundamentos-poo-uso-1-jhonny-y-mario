# Ex05d_MethodOverloading

## Problema

En este ejercicio trabajarás con la **sobrecarga de métodos**, una característica de POO que permite tener varios métodos con el mismo nombre pero diferentes parámetros.

La clase `Order` tiene dos versiones del método `AddLine()`:
- Una que usa el precio del producto automáticamente
- Otra que permite especificar un precio personalizado

Debes crear un pedido y agregar dos líneas usando ambas versiones del método para ver cómo funciona la sobrecarga.

### Pasos a realizar:
1. **Crear cliente y pedido**: Crea un `Customer` y un `Order` con su número.
2. **Crear productos**: Crea dos productos con SKU, descripción y precio.
3. **Agregar primera línea (sin precio personalizado)**: Usa `order.AddLine(producto1, cantidad)` - el método usará automáticamente el precio del producto.
4. **Agregar segunda línea (con precio personalizado)**: Usa `order.AddLine(producto2, cantidad, precioEspecial)` - aquí especificas un precio diferente al del producto (por ejemplo, un precio promocional).
5. **Mostrar total**: Imprime el total del pedido que incluye ambas líneas.

### Concepto clave:
La **sobrecarga de métodos** permite que `AddLine` tenga diferentes comportamientos dependiendo de los parámetros que le pases. El compilador elige automáticamente qué versión usar según los argumentos.

## 🛠️ Herramientas Disponibles

### Clase `Order`

```csharp
// Factory method
Order Order.Create(OrderNumber orderNumber, Customer customer)

// Sobrecarga 1: Precio personalizado
void AddLine(Product product, int quantity, Money unitPrice)

// Sobrecarga 2: Usa precio del producto
void AddLine(Product product, int quantity)

// Propiedad calculada
Money Total { get; }
```

### Clases Auxiliares

```csharp
// Product
Product product = new Product(string sku, string description, Money price);

// OrderNumber
OrderNumber OrderNumber.New(); // Genera número único

// Customer
Customer customer = new Customer(string name, string email);

// Money
Money.Euros(decimal amount)
```

## Variables Disponibles

En Program.cs puedes modificar:
```csharp
string skuProducto1 = "LAPTOP-001";
decimal precioProducto1 = 899.99m;
int cantidadLinea1 = 2;
string skuProducto2 = "MOUSE-002";
decimal precioProducto2 = 25.50m;
int cantidadLinea2 = 5;
decimal precioEspecial = 20.00m;
```
