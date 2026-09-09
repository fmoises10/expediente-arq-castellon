package practicas.c8;

public class ConfiguracionTienda {
    // 1. Guardamos la única copia aquí adentro
    private static ConfiguracionTienda instancia;

    // 2. 'private' para que NADIE afuera pueda hacer: new ConfiguracionTienda()
    private ConfiguracionTienda() {}

    // 3. Este método es la ÚNICA forma de pedir la configuración
    public static ConfiguracionTienda getInstancia() {
        if (instancia == null) {
            instancia = new ConfiguracionTienda();
        }
        return instancia;
    }
}