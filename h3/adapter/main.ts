import {
    ProductoAdapter,
    ProductoExterno,
    Producto,
} from "./ProductoAdapter";

const sistemaExterno = new ProductoExterno();

const productoAdapter: ProductoAdapter = new ProductoAdapter(
    sistemaExterno,
);

const producto: Producto = productoAdapter.obtenerProducto("PROD-001");

console.log("Producto traducido al dominio de la Tienda:");
console.log(producto);