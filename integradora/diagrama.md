# Diagrama de clases - Comedor Sabor Andino

```mermaid
classDiagram

class Estudiante {
    +int id
    +string nombre
    +recibirAviso()
}

class Pedido {
    +int id
    +int cantidad
    +string estado
    +registrar()
    +preparar()
    +entregar()
    +anular()
}

class Menu {
    +string tipo
    +decimal precio
}

class Cajero {
    +registrarPedido()
}

class Administrador {
    +ajustarPrecio()
    +anularPedido()
    +generarReporte()
}

class Reporte {
    +generarPorTipo()
}

class IObservadorPedido {
    <<interface>>
    +actualizar()
}

class NotificadorPedido {
    +suscribir()
    +notificar()
}

Estudiante "1" --> "0..*" Pedido : realiza
Pedido "1" --> "1" Menu : contiene
Cajero --> Pedido : registra
Administrador --> Pedido : administra
Administrador --> Reporte : solicita
Pedido --> NotificadorPedido : notifica
IObservadorPedido <|.. Estudiante : observa
NotificadorPedido --> IObservadorPedido : avisa