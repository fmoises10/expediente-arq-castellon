// Solucion: Felix Moises Castellon

interface Notificacion {
    actualizar(socio: string): void;
}

class WhatsApp implements Notificacion {
    actualizar(socio: string): void {
        console.log("WhatsApp: avisar a " + socio);
    }
}

class Recepcion implements Notificacion {
    actualizar(socio: string): void {
        console.log("Recepcion: membresia vencida de " + socio);
    }
}

class Membresias {
    private notificaciones: Notificacion[] = [];

    agregar(notificacion: Notificacion): void {
        this.notificaciones.push(notificacion);
    }

    vencerMembresia(socio: string): void {
        console.log("Membresia vencida: " + socio);

        for (const notificacion of this.notificaciones) {
            notificacion.actualizar(socio);
        }
    }
}

const membresias = new Membresias();

const whatsapp = new WhatsApp();
const recepcion = new Recepcion();

membresias.agregar(whatsapp);
membresias.agregar(recepcion);

membresias.vencerMembresia("Juan Perez");