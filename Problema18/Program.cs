using System.Globalization;

CultureInfo cultura = CultureInfo.GetCultureInfo("es-CO");

Console.Write("Ingrese la estatura en metros: ");
double estatura = double.Parse(Console.ReadLine() ?? string.Empty, cultura);

Console.Write("Ingrese la edad: ");
int edad = int.Parse(Console.ReadLine() ?? string.Empty);

Console.Write("¿Va acompañado por un adulto? (si/no): ");
string respuestaAcompanante = (Console.ReadLine() ?? string.Empty).Trim();
bool vaAcompanado = respuestaAcompanante.Equals("si", StringComparison.OrdinalIgnoreCase);

bool puedeSubir = estatura >= 1.40 && (edad >= 12 || vaAcompanado);
Console.WriteLine(puedeSubir ? "Puede subir" : "No puede subir");
