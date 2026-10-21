Console.Write("Ingrese el anio: ");
short anio = short.Parse(Console.ReadLine());

if (anio % 4 == 0 && anio % 100 != 0 || anio % 400 == 0)
{
    Console.WriteLine("El anio es bisiesto");
}
else
{
    Console.WriteLine("El anio no es bisiesto");
}


