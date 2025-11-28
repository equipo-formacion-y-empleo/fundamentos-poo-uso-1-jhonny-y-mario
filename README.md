# Fundamentos de POO (Uso) - Ejercicios Prácticos

Este repositorio contiene ejercicios diseñados para practicar el **uso** de objetos, métodos y propiedades en C#.

## 📚 Estructura del Repositorio

El repositorio está organizado en **5 conceptos fundamentales**, cada uno con **3 variantes**:

### Librerías de Dominio

- **`Domain/`**: Clases de dominio comercial (Product, Customer, Order, Money, etc.)
- **`Logistics/`**: Clases de logística (Package, Shipment, ShippingCalculator)
- **`Healthcare/`**: Clases de salud (Patient, MedicalRecord, HealthMetrics)

## 🎯 Ejercicios por Concepto

### Concepto 1: Propiedades e Instanciación

Aprender a crear objetos y acceder a sus propiedades (Lectura/Escritura vs Solo Lectura).

- **Ex01a_PropertiesSystem**: StringBuilder (Clases del Sistema .NET)
- **Ex01b_PropertiesDomain**: Product (Dominio comercial)
- **Ex01c_PropertiesLogistics**: Package (Logística)

### Concepto 2: Constructores

Practicar sobrecarga de constructores.

- **Ex02a_ConstructorsSystem**: DateTime, TimeSpan (Sistema)
- **Ex02b_ConstructorsDomain**: Customer (Dominio)
- **Ex02c_ConstructorsHealthcare**: Patient (Healthcare)

### Concepto 3: Métodos de Instancia

Llamar a métodos que modifican el estado de un objeto.

- **Ex03a_InstanceMethodsSystem**: List<T> (Sistema)
- **Ex03b_InstanceMethodsDomain**: Order (Dominio)
- **Ex03c_InstanceMethodsLogistics**: Shipment (Logística)

### Concepto 4: Métodos Estáticos

Usar métodos estáticos y factory methods.

- **Ex04a_StaticMethodsSystem**: Math, DateTime (Sistema)
- **Ex04b_StaticMethodsDomain**: Money (Dominio)
- **Ex04c_StaticMethodsHealthcare**: HealthMetrics (Healthcare)

### Concepto 5: Parámetros Avanzados y Sobrecarga

Practicar `ref`, `out`, `params`, sobrecarga de métodos y parámetros por defecto.

- **Ex05a_ParametersSystem**: int.TryParse, String.Format (Sistema)
- **Ex05b_ParametersDomain**: InventoryService (Dominio)
- **Ex05c_ParametersLogistics**: ShippingCalculator (Logística)
- **Ex05d_MethodOverloading**: Order.AddLine - Sobrecarga de métodos (Dominio)
- **Ex05e_DefaultParameters**: Order.ApplyPercentageDiscount - Parámetros por defecto (Dominio)

## 🚀 Cómo realizar los ejercicios

1. **Navega** a la carpeta del ejercicio (ej. `Ex01a_PropertiesSystem`)
2. **Lee** el archivo `Program.cs` con las instrucciones
3. **Completa** el código donde veas `// TU CÓDIGO AQUÍ`
4. **Ejecuta** con `dotnet run` dentro de la carpeta del ejercicio
5. **Consulta** `Solution.cs` si necesitas ayuda (está comentado)

## 📖 Progresión de Aprendizaje

### Nivel 1: Sistema (.NET)
Ejercicios con clases del sistema: `StringBuilder`, `List<T>`, `Math`, `DateTime`

### Nivel 2: Dominio (Comercial)
Ejercicios con clases de ejemplos vistos en clase: `Product`, `Customer`, `Order`, `Money`

### Nivel 3: Nuevos Dominios
Ejercicios con clases nuevas que requieren importar namespaces diferentes:
- `using Logistics;` → Package, Shipment, ShippingCalculator
- `using Healthcare;` → Patient, MedicalRecord, HealthMetrics

## 💡 Conceptos Clave

- **Propiedades**: Acceso y modificación de estado (`get`/`set`)
- **Constructores**: Inicialización de objetos
- **Métodos de Instancia**: Operaciones que dependen del estado del objeto
- **Métodos Estáticos**: Operaciones que NO dependen de una instancia
- **Parámetros**: `ref` (modificar variables externas), `out` (devolver múltiples valores), `params` (cantidad variable de argumentos)
- **Sobrecarga de Métodos**: Múltiples métodos con el mismo nombre pero diferentes parámetros
- **Parámetros por Defecto**: Valores predefinidos para simplificar llamadas a métodos

## 🔧 Compilación

``bash
# Compilar todo
dotnet build fundamentos-poo-uso.sln

# Ejecutar un ejercicio específico
cd Ex01a_PropertiesSystem
dotnet run
``

## 📝 Notas

- Los ejercicios están diseñados para practicar **uso**, no implementación
- Cada ejercicio es independiente
