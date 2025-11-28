# Ex05e_DefaultParameters

## Problema

En este ejercicio trabajarás con el concepto de **parámetros por defecto** simulado mediante sobrecarga de métodos. C# no tiene parámetros opcionales en el sentido tradicional, pero se puede simular con sobrecarga.

La clase `Order` tiene dos versiones del método `ApplyPercentageDiscount()`:
- Una que requiere especificar la razón del descuento
- Otra que usa una razón por defecto automáticamente

Debes crear dos pedidos idénticos y aplicar el mismo descuento de dos formas diferentes para comprobar que el resultado es el mismo.

### Pasos a realizar:
1. **Crear primer pedido**: Crea cliente, producto y pedido. Agrega una línea con cierta cantidad.
2. **Aplicar descuento con razón explícita**: Usa `order1.ApplyPercentageDiscount(porcentaje, "Descuento promocional")` especificando la razón.
3. **Obtener total del primer pedido**: Guarda el total en una variable.
4. **Crear segundo pedido idéntico**: Repite el proceso de creación con los mismos datos.
5. **Aplicar descuento sin razón**: Usa `order2.ApplyPercentageDiscount(porcentaje)` sin especificar razón - el método usará una razón por defecto.
6. **Verificar igualdad**: Comprueba que ambos totales son iguales y muéstralo en consola.

### Concepto clave:
Mediante **sobrecarga**, se puede simular parámetros por defecto: una versión del método con todos los parámetros, y otra que llama a la primera con valores predeterminados.

## 🛠️ Herramientas Disponibles

### Clase `Order`

```csharp
// Factory method
Order Order.Create(OrderNumber orderNumber, Customer customer)

// Añadir línea con precio del producto
void AddLine(Product product, int quantity)

// Aplicar descuento con razón personalizada
void ApplyPercentageDiscount(decimal percentage, string reason)

// Aplicar descuento con razón por defecto
void ApplyPercentageDiscount(decimal percentage)

// Propiedad calculada (incluye descuento)
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
string skuProducto = "MONITOR-001";
decimal precioProducto = 299.99m;
int cantidad = 3;
decimal porcentajeDescuento = 10m;
string razonPersonalizada = "Cliente VIP";
```
