# Práctica: Patrón Adapter en el Sistema Tienda con Inventario

## Sistema Externo Identificado

**Sistema externo de proveedores**

La tienda necesita recibir información de productos provenientes de un sistema externo de proveedores.

El sistema externo utiliza nombres y estructuras diferentes a las que maneja nuestro sistema interno.

---

## ¿Por qué implementamos el patrón Adapter?

El sistema de la tienda trabaja con productos utilizando los atributos `codigo`, `nombre` y `precio`.

Sin embargo, el sistema externo del proveedor entrega la información utilizando `codigoProducto`, `descripcionProducto` y `precioVenta`.

Como las estructuras no coinciden, no es conveniente modificar el sistema externo para adaptarlo a nuestra aplicación.

Por este motivo se implementa el patrón **Adapter**, que funciona como un traductor entre ambas estructuras.

El `ProductoAdapter` recibe un `ProductoExterno` y convierte sus datos al formato que necesita el sistema de la tienda.

De esta manera, la lógica principal de la tienda puede trabajar con su propia estructura de `Producto` sin depender directamente de cómo el proveedor organiza sus datos.

---

## Funcionamiento del Adapter

El proceso es el siguiente:

```text
ProductoExterno
      ↓
ProductoAdapter
      ↓
Producto
      ↓
Sistema de Tienda
```

El adaptador realiza las siguientes conversiones:

```text
codigoProducto → codigo
descripcionProducto → nombre
precioVenta → precio
```

Así, el sistema puede utilizar productos provenientes del proveedor sin modificar la clase externa.

---

## Instrucciones de Ejecución

Para verificar el funcionamiento del Adapter, ejecutar el programa principal desde la consola:

```text
java Main
```

El programa debe mostrar los datos del producto externo utilizando
