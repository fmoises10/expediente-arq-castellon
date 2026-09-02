# Expediente de Arquitectura — Comercio: Tienda con Inventario

**Estudiante:** Félix Moisés Castellón  
**Variante elegida:** Variante 4 — Comercio ("Tienda con inventario")  
**Justificación:** Trabajo en el rubro comercial y conozco la operativa de gestión de stock y ventas.

## 1. Actores del Sistema
* **Vendedor (Operador):** Busca productos y registra ventas.
* **Administrador (Supervisor):** Ajusta stock, cambia precios y ve reportes.

## 2. Inventario de Módulos
* **Catálogo:** Gestiona información de productos y precios.
* **Inventario:** Controla las existencias y alertas de stock mínimo.
* **Ventas:** Procesa transacciones (carrito, pago, entrega).
* **Notificaciones:** Envía alertas de stock crítico.
* **Reportes:** Genera estadísticas de ventas y más vendidos.

## 3. Primer Diagrama de Clases

```mermaid
classDiagram
    class Producto {
        +String id
        +String nombre
        +double precio
        +int stockActual
        +int stockMinimo
        +actualizarStock(int cantidad)
    }
    class Venta {
        +String id
        +DateTime fecha
        +String estado
        +double total
        +confirmar()
    }
    class DetalleVenta {
        +int cantidad
        +double precioUnitario
    }
    class Usuario {
        +String id
        +String rol
    }
    Producto "1" -- "*" DetalleVenta : compone
    Venta "1" *-- "*" DetalleVenta : contiene
    Usuario "1" -- "*" Venta : registra



### 3.1. Diagrama Original (Acoplado)
Este diagrama inicial centraliza todas las responsabilidades, lo que genera un alto acoplamiento entre los módulos.

```mermaid
classDiagram
    class Usuario
    class Vendedor { +registrarVenta() }
    class Administrador { +ajustarStock() }
    class Producto { +descontarStock() }
    class Venta { +procesarPago() }
    
    Usuario <|-- Vendedor
    Usuario <|-- Administrador
    Vendedor -- Venta
    Administrador -- Producto
