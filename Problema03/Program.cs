Console.WriteLine("Ingrese la opcion a realizar: ");
Console.WriteLine("1-consultar saldo");
Console.WriteLine("2-realizar retiro");
Console.WriteLine("3-realizar deposito");
Console.WriteLine("4-salir");

byte opcion = byte.Parse(Console.ReadLine());

switch (opcion)
{
    case 1:
        Console.WriteLine("Su saldo es: $670000");
        break;
    case 2:
        Console.WriteLine("Ha seleccionado: Retirar dinero");
        break;
    case 3:
        Console.WriteLine("Ha seleccionado: Depositar dinero");
        break;
    case 4:
        Console.WriteLine("Ha seleccionado: Salir");
        break;
    default:
        Console.WriteLine("Opcion invalida");
        break;
}