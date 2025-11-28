# Ex03c_InstanceMethodsLogistics

## Problema

En este ejercicio trabajarás con las clases `Shipment` y `Package` del dominio de logística para gestionar un envío completo. Practicarás el uso de **métodos de instancia** que agregan elementos y cambian el estado de un objeto.

Debes crear un envío, agregarle paquetes, calcular el peso total y cambiar su estado a medida que progresa la entrega.

### Pasos a realizar:
1. **Crear un envío**: Usa el constructor `new Shipment(shipmentId, carrier)` con un ID de envío y el nombre de la transportista. El estado inicial será `Pending`.
2. **Crear y agregar primer paquete**: Crea un `Package` con el primer número de seguimiento, un destino y el peso. Usa el método `AddPackage()` del envío para agregarlo.
3. **Crear y agregar segundo paquete**: Crea otro `Package` con el segundo número de seguimiento, un destino y peso de 3.2 kg. Agrégalo al envío.
4. **Calcular peso total**: Usa el método `GetTotalWeight()` para obtener el peso total de todos los paquetes en el envío. Muestra también cuántos paquetes hay con la propiedad `Packages.Count`.
5. **Cambiar estados del envío**: Usa el método `Ship()` para cambiar el estado a `InTransit`, y luego el método `Deliver()` para cambiarlo a `Delivered`.
6. **Mostrar resultados**: Después de cada fase, muestra el estado actual, número de paquetes y peso total.

## Herramientas Disponibles

**Clase:** `Shipment` (Logistics)
- **Constructor:** `new Shipment()` - Crea envío con ID autogenerado y estado inicial
- **Método:** `AddPackage(Package)` - Agregar paquete al envío
- **Método:** `GetTotalWeight()` - Calcular peso total de todos los paquetes
- **Método:** `Ship()` - Cambiar estado a "enviado"
- **Método:** `Deliver()` - Cambiar estado a "entregado"
- **Propiedades:** `ShipmentId`, `Status`, `Packages.Count`

**Clase:** `Package` (Logistics)
- **Constructor:** `new Package()` con propiedades `TrackingNumber` y `WeightKg`

## Comportamiento

El programa debe:
1. Crear un envío vacío
2. Agregar paquetes al envío usando `AddPackage()`
3. Calcular el peso total usando `GetTotalWeight()`
4. Cambiar el estado del envío usando `Ship()` y `Deliver()`
5. Mostrar el resumen del envío

## Variables Disponibles

En Program.cs puedes modificar:
```csharp
string tracking1 = "PKG-001";
double peso1 = 5.5;
string tracking2 = "PKG-002";
```

## Salida

El programa imprime:
```
=== Sistema de Gestión de Envíos ===
Creando envío ID: <shipment_id>
Estado inicial: <estado>

Agregando paquetes...
Paquete agregado: <tracking> (<peso> kg)
Paquete agregado: <tracking> (<peso> kg)

Peso total del envío: <peso_total> kg
Total de paquetes: <count>

Enviando...
Estado: <estado>

Entregando...
Estado: <estado>
```

## Ejemplo de Salida

### Con valores por defecto:

**Salida:**
```
=== Sistema de Gestión de Envíos ===
Creando envío ID: a1b2c3d4-e5f6-7890-abcd-ef1234567890
Estado inicial: Pending

Agregando paquetes...
Paquete agregado: PKG-001 (5.5 kg)
Paquete agregado: PKG-002 (3.2 kg)

Peso total del envío: 8.7 kg
Total de paquetes: 2

Enviando...
Estado: Shipped

Entregando...
Estado: Delivered
```

### Con tracking1 = "INT-001", peso1 = 12.8, tracking2 = "INT-002":

**Salida:**
```
=== Sistema de Gestión de Envíos ===
Creando envío ID: b2c3d4e5-f6a7-8901-bcde-f12345678901
Estado inicial: Pending

Agregando paquetes...
Paquete agregado: INT-001 (12.8 kg)
Paquete agregado: INT-002 (3.2 kg)

Peso total del envío: 16.0 kg
Total de paquetes: 2

Enviando...
Estado: Shipped

Entregando...
Estado: Delivered
```

## Conceptos Clave

- **Namespace:** Requiere `using Logistics;`
- **Máquina de Estados:** El envío pasa por estados: Pending → Shipped → Delivered
- **Agregación:** Un envío contiene múltiples paquetes
- **Métodos de Consulta:** `GetTotalWeight()` no modifica el estado
- **Métodos de Comando:** `Ship()` y `Deliver()` cambian el estado
