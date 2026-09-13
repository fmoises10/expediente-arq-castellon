import { VentaBuilder } from "./VentaBuilder";

const venta = new VentaBuilder()
    .conCliente("Juan Pérez")
    .conProductos(["Teclado", "Mouse", "Monitor"])
    .conTotal(1250)
    .conMetodoPago("QR")
    .conDireccion("Av. Blanco Galindo")
    .conEstado("Confirmada")
    .crear();

console.log("Venta creada utilizando el patrón Builder:");
console.log(venta);