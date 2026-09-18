# ADR - Decisión de Arquitectura

## Contexto

El sistema de Tienda con Inventario necesita gestionar productos, stock, precios y ventas. Además, debe comunicarse con una pasarela externa para procesar pagos y notificar eventos importantes del sistema.

## Decisión

Se decidió utilizar una arquitectura basada en contenedores, separando la aplicación web, la lógica de gestión, el servicio de avisos y la base de datos.

Para las notificaciones se utiliza el patrón Observer, permitiendo avisar a los usuarios cuando ocurre un evento.

Para la comunicación con la pasarela de pagos externa se utiliza el patrón Adapter, permitiendo adaptar la interfaz externa a la que necesita nuestro sistema.

## Consecuencias

La separación de responsabilidades facilita el mantenimiento y permite modificar una parte del sistema sin afectar directamente a las demás.

El uso de Observer permite agregar nuevos tipos de notificación con menor acoplamiento.

El Adapter permite cambiar o integrar otra pasarela de pagos sin modificar directamente la lógica principal del sistema.