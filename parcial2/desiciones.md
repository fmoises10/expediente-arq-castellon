# Parcial 2 - Arquitectura de Software

## Situación 1 — Observer

Aplico el patrón Observer porque cuando vence una membresía varios interesados deben recibir el aviso.
Así, el módulo de membresías no necesita llamar directamente a WhatsApp, Recepción o Promociones.
Si aparece otro interesado, se puede agregar sin modificar el módulo que detecta el vencimiento.
Sin Observer, cada nuevo aviso obligaría a modificar nuevamente el módulo de membresías.

## Situación 2 — Strategy

Usaría Strategy porque el precio del gimnasio cambia dependiendo del horario o del día.

Por ejemplo, en la mañana se cobra normal, en la noche aumenta y el fin de semana se aplica un descuento.

De esta forma cada cálculo puede estar separado y no tener todos los casos juntos en muchos `if/else`.

Si el dueño cambia una regla, se puede cambiar esa parte sin tener que modificar todo el módulo de facturación.

## Situación 3 — Adapter

Usaría Adapter porque el sistema del gimnasio y el sistema de pagos externo no trabajan de la misma forma.

El proveedor usa sus propios nombres y además maneja el monto en centavos.

El Adapter sirve para convertir esos datos y hacer que el sistema del gimnasio pueda trabajar con el proveedor.

Así, si después se cambia de proveedor, no sería necesario cambiar todo el código que utiliza los pagos.

## P2.3 — SOLID

La solución del Observer se relaciona con el principio Open/Closed (OCP).

La clase `Membresias` no tiene que modificarse cada vez que aparece una nueva forma de notificación.

Por ejemplo, se puede crear `Promociones` implementando `Notificacion` y agregarla a la lista.


