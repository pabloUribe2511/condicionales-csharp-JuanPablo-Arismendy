Console.Write("ingrese su edad: "); byte edad = byte.Parse(Console.ReadLine());

if (edad >= 16)
{
    Console.WriteLine("Puede votar");
}
else
{
    Console.WriteLine("Aun no puede votar");
}