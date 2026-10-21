using System.Globalization;

CultureInfo cultura = CultureInfo.GetCultureInfo("es-CO");

Console.Write("Ingrese el peso en kilogramos: ");
double peso = double.Parse(Console.ReadLine() ?? string.Empty, cultura);

Console.Write("Ingrese la estatura en metros: ");
double estatura = double.Parse(Console.ReadLine() ?? string.Empty, cultura);

double imc = peso / (estatura * estatura);
string categoria = imc switch
{
    < 18.5 => "Bajo peso",
    < 25 => "Peso normal",
    < 30 => "Sobrepeso",
    _ => "Obesidad"
};

Console.WriteLine($"IMC: {imc.ToString("0.0", cultura)} - {categoria}");
