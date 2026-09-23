# Detecciones SOLID
se evidencian 3 problemas 
## 1. SRP o responsabilidad unica:

Donde: En `GestorDePedidos`.
Por qué?: Esta clase hace varias cosas: calcula el precio, guarda el pedido, muestra el vale y manda el correo. No debería encargarse de todo.

## 2. OCP o abierta y cerrada:

Donde: En el `switch` de `tipoMenu`.

Por qué: Si aparece otro tipo de menú, hay que modificar el `switch` y agregar otro `case`.

## 3. DIP

Dónde: En `GestorDePedidos`, cuando usa `new BaseDeDatosComedor()` y `new CorreoUniversitario()`.
Por qué: El gestor depende directamente de esas clases concretas, en vez de trabajar con una abstracción.