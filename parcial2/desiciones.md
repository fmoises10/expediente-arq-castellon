# Parcial 2 - Arquitectura de Software

## Situación 1 — Observer

Aplico el patrón Observer porque cuando vence una membresía varios interesados deben recibir el aviso.
Así, el módulo de membresías no necesita llamar directamente a WhatsApp, Recepción o Promociones.
Si aparece otro interesado, se puede agregar sin modificar el módulo que detecta el vencimiento.
Sin Observer, cada nuevo aviso obligaría a modificar nuevamente el módulo de membresías.

## Situación 2 — Strategy

Aplico el patrón Strategy porque el cálculo de la tarifa cambia según la franja horaria y las reglas se modifican con frecuencia.
Cada regla puede mantenerse separada y seleccionarse según corresponda.
Esto evita tener los mismos `if/else` copiados en facturación y cotizaciones.
Sin Strategy, cada cambio de temporada obligaría a modificar varios lugares y puede generar inconsistencias.

## Situación 3 — Adapter

Aplico el patrón Adapter porque el gateway externo tiene una interfaz diferente a la que necesita el sistema del gimnasio.
El SDK usa nombres, unidades y datos propios del proveedor, por ejemplo montos en centavos.
El Adapter traduce esa interfaz externa a la interfaz que entiende el sistema del gimnasio.
Sin Adapter, el código quedaría acoplado directamente al proveedor y cambiarlo sería más costoso.

## P2.3 — SOLID

La implementación del Observer rescata el principio Open/Closed (OCP).
La clase `Membresias` trabaja con la abstracción `Notificacion` y no necesita modificarse cuando aparece un nuevo interesado.
Por ejemplo, se puede agregar `Promociones` implementando `Notificacion` y registrándola con `agregar()`.
La decisión concreta está en usar una lista de `Notificacion` y no una lista de clases concretas.
