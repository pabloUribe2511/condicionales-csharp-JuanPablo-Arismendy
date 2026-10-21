Console.Write("Ingrese el color del semaforo (rojo, amarillo, verde): ");
string color = Console.ReadLine()!.ToLower();

if (color == "rojo")
{
    Console.WriteLine("Detenerse");
}
else if (color == "amarillo")
{
    Console.WriteLine("Precaucion");
}
else if (color == "verde")
{
    Console.WriteLine("Avanzar");
}
else
{
    Console.WriteLine("Color no valido");
}
