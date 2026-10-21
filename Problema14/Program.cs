using System.Globalization;

Console.Write("Ingrese la nota final (0 a 5): ");
double nota = double.Parse(Console.ReadLine() ?? string.Empty, CultureInfo.GetCultureInfo("es-CO"));
string estado = nota >= 3 ? "Aprobado" : "Reprobado";

Console.WriteLine($"Nota: {nota.ToString("0.0", CultureInfo.GetCultureInfo("es-CO"))} - {estado}");
