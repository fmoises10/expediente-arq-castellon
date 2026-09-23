//no manejo bien el lenguaje de la familia C#

// Refactor: Félix Moisés Castellón

namespace Integradora.Comedor;

public class CalculadorPrecio
{
    public decimal Calcular(string tipoMenu, int cantidad)
    {
        decimal precioBase;

        switch (tipoMenu)
        {
            case "estandar":
                precioBase = 12;
                break;

            case "vegetariano":
                precioBase = 14;
                break;

            case "beca":
                precioBase = 5;
                break;

            default:
                precioBase = 12;
                break;
        }

        return precioBase * cantidad;
    }
}
//aqui estaba el problme ya que habian muchas responsabilidades
public class GestorDePedidos
//en teoria aqui habia muchas responsabilidades y aplicamos single responsability
{
    private CalculadorPrecio calculadorPrecio = new CalculadorPrecio();

    public void ProcesarPedido(string estudiante, string tipoMenu, int cantidad)
    {
        decimal total = calculadorPrecio.Calcular(tipoMenu, cantidad);

        Console.WriteLine("----- VALE DE COMEDOR -----");
        Console.WriteLine($"{estudiante}: {cantidad} x menú {tipoMenu}");
        Console.WriteLine($"TOTAL: {total:0.00} Bs");
    }
}

public static class Demo
{
    public static void Correr()
    {
        new GestorDePedidos().ProcesarPedido("Noelia", "vegetariano", 2);
    }
}