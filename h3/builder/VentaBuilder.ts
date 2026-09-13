export class Venta {
    constructor(
        public cliente: string,
        public productos: string[],
        public total: number,
        public metodoPago: string,
        public direccion: string,
        public estado: string
    ) { }
}

export class VentaBuilder {
    private cliente: string = "";
    private productos: string[] = [];
    private total: number = 0;
    private metodoPago: string = "";
    private direccion: string = "";
    private estado: string = "Pendiente";

    public conCliente(cliente: string): VentaBuilder {
        this.cliente = cliente;
        return this;
    }

    public conProductos(productos: string[]): VentaBuilder {
        this.productos = productos;
        return this;
    }

    public conTotal(total: number): VentaBuilder {
        this.total = total;
        return this;
    }

    public conMetodoPago(metodoPago: string): VentaBuilder {
        this.metodoPago = metodoPago;
        return this;
    }

    public conDireccion(direccion: string): VentaBuilder {
        this.direccion = direccion;
        return this;
    }

    public conEstado(estado: string): VentaBuilder {
        this.estado = estado;
        return this;
    }

    public crear(): Venta {
        return new Venta(
            this.cliente,
            this.productos,
            this.total,
            this.metodoPago,
            this.direccion,
            this.estado
        );
    }
}