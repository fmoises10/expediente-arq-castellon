//no manejo bien el lenguaje de la familia C#

// Refactor: Félix Moisés Castellón

namespace Integradora.Comedor;

public class CalculadorPrecio
{
//SE SEPARA EL SWITCH CASE POR PRINCIPIOS SOLID PARA NO TENER TODO EN UNA SOLA CLASE
    public decimal Calcular(string tipoMenu, int cantidad)
    {
        decimal precioBase;
//ocp estaria aqui para abrir a mas codigo
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
    //SEPARAMOS LAS COSAS 

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
//no se si terminaria asi pero intuyo   q es lo ideal