Console.Write("Ingrese el peso del paquete en kg: ");
float peso = float.Parse(Console.ReadLine());
int tarifa;

if (peso <= 0)
{
    tarifa = 0;
    Console.WriteLine("Peso invalido");
}
else if (peso < 1)
{
    tarifa = 8000;
    Console.WriteLine($"La tarifa de envio es: ${tarifa}");
}
else if (peso < 5)
{
    tarifa = 15000;
    Console.WriteLine($"La tarifa de envio es: ${tarifa}");
}
else if (peso < 20)
{
    tarifa = 32000;
    Console.WriteLine($"La tarifa de envio es: ${tarifa}");
}
else
{
    tarifa = 60000;
    Console.WriteLine($"La tarifa de envido es: ${tarifa}");
}
