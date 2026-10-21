
Console.Write("Ingrese el código del país (2 letras): ");
string codigoPais = (Console.ReadLine() ?? string.Empty).Trim().ToUpperInvariant();

string nombrePais = codigoPais switch
{
    "CO" => "Colombia",
    "MX" => "México",
    "AR" => "Argentina",
    "PE" => "Perú",
    "CL" => "Chile",
    _ => "País no registrado"
};

Console.WriteLine($"País: {nombrePais}");