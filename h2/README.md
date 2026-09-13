# Hitos de Arquitectura 2 (H2): Refactorización SOLID - Tienda con Inventario

Este entregable documenta la evolución del sistema de **Tienda con Inventario**, pasando de un modelo inicial con responsabilidades concentradas y alto acoplamiento (H1) a un diseño más organizado y mantenible aplicando los principios **SOLID**.

El sistema permite gestionar productos, inventario, ventas y pagos, diferenciando además las operaciones realizadas por vendedores y administradores.

## 1. Diagrama ANTES (Modelo Inicial H1 con Problemas de Diseño)

En el modelo inicial, varias responsabilidades se encontraban concentradas en pocas clases. `Producto` manejaba información propia del producto junto con operaciones relacionadas al stock, mientras que `Venta` también concentraba responsabilidades relacionadas con el detalle de la venta y el pago.

Además, los tipos de producto y los métodos de pago estaban planteados de forma rígida, dificultando la incorporación de nuevas variantes.

**Diagrama Antes - Problemas de Diseño**

![Diagrama Antes](img/diagrama_antes.png)

## 2. Diagrama DESPUÉS (Modelo Arquitectónico con SOLID Aplicado)

Después de la refactorización, las responsabilidades fueron separadas en diferentes clases e interfaces.

El sistema se organiza en módulos relacionados con usuarios, catálogo, inventario, ventas y pagos. También se utilizan abstracciones para permitir diferentes tipos de productos y métodos de pago sin modificar las clases principales.

**Diagrama Después - SOLID Completo**

![Diagrama Después](img/diagrama_despues.png)

## 3. Justificación del Cambio y Principios Aplicados

Para mejorar el diseño inicial de la tienda se separaron las responsabilidades que estaban concentradas principalmente en `Producto` y `Venta`. El manejo del stock pasó a `Inventario`, mientras que la información de una venta se organizó mediante `DetalleVenta` y el procesamiento del pago se separó en `Pago`, aplicando el principio **SRP (Single Responsibility Principle)**.

Para cumplir con **OCP (Open/Closed Principle)** se definieron diferentes tipos de productos y métodos de pago mediante abstracciones. De esta manera, es posible agregar nuevas variantes sin modificar las clases principales del sistema.

En **LSP (Liskov Substitution Principle)** se separaron los comportamientos de los productos físicos y digitales. Un `ProductoDigital` no necesita manejar operaciones de stock, por lo que no se obliga a implementar comportamientos que no corresponden a su naturaleza.

Para **ISP (Interface Segregation Principle)** se dividieron las operaciones de acuerdo con el tipo de usuario. `IVendedor` contiene las operaciones necesarias para el vendedor, mientras que `IAdministrador` contiene las operaciones correspondientes al administrador. De esta forma, cada clase depende únicamente de los métodos que realmente necesita.

Finalmente, mediante **DIP (Dependency Inversion Principle)** se busca que la lógica principal del sistema trabaje con abstracciones en lugar de depender directamente de implementaciones concretas. Esto permite cambiar posteriormente la forma de almacenamiento o persistencia sin modificar la lógica principal del sistema.

Con estos cambios, el sistema queda más organizado, facilita futuras modificaciones y permite agregar nuevas funcionalidades con menor impacto sobre las clases existentes.
