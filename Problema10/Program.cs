using System.Globalization;

Console.Write("Ingrese un dato: ");
string entrada = Console.ReadLine() ?? "";

object dato;

if (bool.TryParse(entrada, out bool booleano))
{
    dato = booleano;
}
else if (int.TryParse(entrada, out int entero))
{
    dato = entero;
}
else if (double.TryParse(entrada, NumberStyles.Float, CultureInfo.CurrentCulture, out double decimalDato)
    || double.TryParse(entrada, NumberStyles.Float, CultureInfo.InvariantCulture, out decimalDato))
{
    dato = decimalDato;
}
else
{
    dato = entrada;
}

switch (dato)
{
    case string texto:
        Console.WriteLine($"Texto de {texto.Length} caracteres");
        break;
    case int valorEntero:
        Console.WriteLine($"Entero: {valorEntero}");
        break;
    case double valorDecimal:
        Console.WriteLine($"Decimal: {valorDecimal}");
        break;
    case bool valorBooleano:
        Console.WriteLine($"Booleano: {valorBooleano}");
        break;
    default:
        Console.WriteLine("Tipo no reconocido");
        break;
}
