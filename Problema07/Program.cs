Console.Write("Ingresa un numero:");
sbyte numero = sbyte.Parse(Console.ReadLine());

if (numero < 0)
{
    Console.WriteLine("El numero es negativo");
}
else if (numero > 0)
{
    Console.WriteLine("El numero es positivo");
}
else
{
    Console.WriteLine("El numero es cero");
}
