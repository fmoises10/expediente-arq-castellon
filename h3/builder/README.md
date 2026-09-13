# Práctica: Patrón Builder en el Sistema Tienda con Inventario

## Problema identificado

El sistema de la tienda necesita crear objetos `Venta` que contienen varios datos, como cliente, productos, total, método de pago, dirección y estado.

Cuando una clase tiene muchos parámetros, es fácil confundir el orden de los valores al crear el objeto. El programa puede compilar correctamente, pero la información puede quedar registrada de forma incorrecta.

---

## ¿Por qué implementamos el patrón Builder?

El patrón **Builder** permite construir una `Venta` paso a paso, utilizando métodos que indican claramente qué información se está agregando.

En lugar de enviar todos los parámetros directamente al constructor, se utiliza un objeto `VentaBuilder` que permite configurar la venta de manera más clara y ordenada.

---

## Funcionamiento del Builder

El proceso es el siguiente:

```text
VentaBuilder
     ↓
Configuración de la venta
     ↓
crear()
     ↓
Venta
```

Los datos se agregan mediante métodos como:

```text
conCliente()
conProductos()
conTotal()
conMetodoPago()
conDireccion()
conEstado()
```

Finalmente, el método `crear()` genera el objeto `Venta`.

---

## Ventaja principal

Sin Builder:

```text
new Venta(cliente, productos, total, metodoPago, direccion, estado)
```

Con Builder:

```text
new VentaBuilder()
    .conCliente(...)
    .conProductos(...)
    .conTotal(...)
    .conMetodoPago(...)
    .conDireccion(...)
    .conEstado(...)
    .crear()
```

Esto hace que la construcción del objeto sea más fácil de leer y reduce el riesgo de confundir los parámetros.

---

## Instrucciones de Ejecución

Para ejecutar la práctica desde la carpeta del proyecto:

```text
npx tsx main.ts
```

El programa debe mostrar en consola la venta construida utilizando el patrón Builder.
