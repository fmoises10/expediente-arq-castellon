// Refactor: Felix Moises Castellon
namespace Parcial1.Farmacia;
//cura 1

public interface IRegistradorPedidos
{
    void RegistrarPedido(string medicamento, int cantidad);
}

public interface IGestorFarmaceutico
{
    void AutorizarVentaControlada(string medicamento);
    void AjustarPrecio(string medicamento, decimal nuevoPrecio);
    void VerLibroDeControlados();
}

public class Farmaceutico : IRegistradorPedidos, IGestorFarmaceutico
{
    public void RegistrarPedido(string medicamento, int cantidad)
        => Console.WriteLine($"[FARM] Pedido: {cantidad} x {medicamento}");

    public void AutorizarVentaControlada(string medicamento)
        => Console.WriteLine($"[FARM] Venta controlada de {medicamento} autorizada");

    public void AjustarPrecio(string medicamento, decimal nuevoPrecio)
        => Console.WriteLine($"[FARM] {medicamento} ahora cuesta {nuevoPrecio:0.00} Bs");

    public void VerLibroDeControlados()
        => Console.WriteLine("[FARM] Libro de medicamentos controlados");
}

public class Cajero : IRegistradorPedidos
{
    public void RegistrarPedido(string medicamento, int cantidad)
        => Console.WriteLine($"[CAJA] Pedido: {cantidad} x {medicamento}");
}

//cura 2

public interface IRepositorioPedidos
{
    void GuardarPedido(string cliente, string medicamento, int cantidad, decimal total);
}

public interface IServicioNotificacion
{
    void Enviar(string mensaje);
}

public class BaseDeDatosMySql : IRepositorioPedidos
{
    public void GuardarPedido(string cliente, string medicamento, int cantidad, decimal total)
        => Console.WriteLine($"[MYSQL] INSERT INTO pedidos VALUES ('{cliente}', '{medicamento}', {cantidad}, {total})");
}

public class CorreoSmtp : IServicioNotificacion
{
    public void Enviar(string mensaje)
        => Console.WriteLine($"[SMTP] {mensaje}");
}

public class GestorDePedidos
{
    private readonly IRepositorioPedidos _repositorio;
    private readonly IServicioNotificacion _notificacion;

    // Inyección de dependencias por constructor
    public GestorDePedidos(IRepositorioPedidos repositorio, IServicioNotificacion notificacion)
    {
        _repositorio = repositorio;
        _notificacion = notificacion;
    }

    public void ProcesarPedido(string cliente, string tipoCliente, string medicamento, int cantidad, decimal precioUnitario)
    {
        decimal total = cantidad * precioUnitario;

        decimal descuento;
        switch (tipoCliente)
        {
            case "particular":
                descuento = 0;
                break;
            case "asegurado":
                descuento = total * 0.20m;
                break;
            case "convenio":
                descuento = total * 0.10m;
                break;
            default:
                descuento = 0;
                break;
        }
        decimal totalFinal = total - descuento;

        // Uso de abstracciones en lugar de instancias concretas
        _repositorio.GuardarPedido(cliente, medicamento, cantidad, totalFinal);

        Console.WriteLine("----- COMPROBANTE -----");
        Console.WriteLine($"{cantidad} x {medicamento}");
        Console.WriteLine($"Cliente: {cliente} ({tipoCliente})");
        Console.WriteLine($"TOTAL: {totalFinal:0.00} Bs");

        _notificacion.Enviar($"Su pedido de {medicamento} fue registrado, {cliente}");
    }
}