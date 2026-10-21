Console.Write("Ingrese la velocidad medida en km/h: ");
double velocidad = double.Parse(Console.ReadLine() ?? string.Empty);

string sancion = velocidad switch
{
    < 0 => "Lectura inválida",
    <= 50 => "Sin infracción",
    <= 70 => "Multa leve",
    <= 90 => "Multa grave",
    _ => "Multa gravísima e inmovilización"
};

Console.WriteLine(sancion);
