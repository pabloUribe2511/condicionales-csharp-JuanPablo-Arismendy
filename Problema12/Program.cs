Console.WriteLine("Para solicitar un Credito, ingrese los siguientes datos:");
Console.Write("Tienes empleo? (si/no): ");
string empleo = Console.ReadLine()!.ToLower();


if (empleo == "No")
{
    Console.WriteLine("credito rechazado" );
}
else
{
    Console.Write("Cuanto es tu ingreso mensual?: ");
    double ingreso = double.Parse(Console.ReadLine()!);
    if (ingreso < 2500000)
    {
        Console.WriteLine("Credito basico aprovado");
    }
    else
    {
        Console.WriteLine("Credito alto aprovado");
    }
}
