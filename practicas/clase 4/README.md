## 4. Interface Segregation Principle (ISP)

En la tienda existen dos tipos de usuarios principales: el vendedor y el administrador.

Cada uno realiza tareas diferentes dentro del sistema. El vendedor se encarga principalmente de buscar productos y registrar ventas, mientras que el administrador puede modificar precios, controlar el stock y generar reportes.

El problema aparecería si se utilizara una sola interfaz con todas estas funciones, ya que el vendedor tendría que depender de métodos que no utiliza.

Por eso se separan las interfaces según las funciones que necesita cada usuario.

### IVendedor

El vendedor solamente necesita:

* buscarProducto()
* registrarVenta()

### IAdministrador

El administrador necesita:

* ajustarStock()
* cambiarPrecio()
* generarReporte()

De esta forma, cada usuario trabaja solamente con las operaciones que corresponden a su función dentro del sistema.
