export interface Producto {
    codigo: string;
    nombre: string;
    precio: number;
}

export class ProductoExterno {
    public obtenerProducto(codigoProducto: string) {
        return {
            codigoProducto: codigoProducto,
            descripcionProducto: "Teclado mecánico",
            precioVenta: 350,
        };
    }
}

export class ProductoAdapter implements Producto {
    private sistemaExterno: ProductoExterno;

    constructor(sistemaExterno: ProductoExterno) {
        this.sistemaExterno = sistemaExterno;
    }

    public obtenerProducto(codigo: string): Producto {
        const datosExternos = this.sistemaExterno.obtenerProducto(codigo);

        return {
            codigo: datosExternos.codigoProducto,
            nombre: datosExternos.descripcionProducto,
            precio: datosExternos.precioVenta,
        };
    }

    get codigo(): string {
        return this.obtenerProductoInterno().codigo;
    }

    get nombre(): string {
        return this.obtenerProductoInterno().nombre;
    }

    get precio(): number {
        return this.obtenerProductoInterno().precio;
    }

    private obtenerProductoInterno(): Producto {
        return this.obtenerProducto("PROD-001");
    }
}