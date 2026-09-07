# Detección de Violaciones SOLID - Parcial 1

| Principio | Dónde vive (Clase / Método) | Por qué es una violación (Explicación breve) |
|---|---|---|
| **LSP / ISP** | `Cajero` / `AutorizarVentaControlada`, `AjustarPrecio`, `VerLibroDeControlados` | La interfaz `IEmpleadoDeFarmacia` fuerza a `Cajero` a implementar métodos que no soporta, lanzando `NotSupportedException`. |
| **SRP** | `GestorDePedidos` / `ProcesarPedido` | Asume demasiadas responsabilidades a la vez: calcula descuentos, orquesta el pedido, gestiona la persistencia y genera la notificación. |
| **OCP** | `GestorDePedidos` / `ProcesarPedido` | El cálculo de descuentos usa un `switch(tipoCliente)`. Agregar un nuevo tipo de cliente exige modificar el código existente en lugar de extenderlo. |
| **DIP** | `GestorDePedidos` / `ProcesarPedido` | Depende directamente de clases concretas (`new BaseDeDatosMySql()` y `new CorreoSmtp()`) en lugar de depender de abstracciones. |