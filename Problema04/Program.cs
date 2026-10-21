Console.WriteLine("Ingrese el nivel de bateria de su celular (0-100): ");
byte nivelBateria = byte.Parse(Console.ReadLine());
byte nivelActual = nivelBateria;

if (nivelActual < 0 || nivelActual > 100)
{
    Console.WriteLine("Nivel de bateria invalido");
}
else if (nivelActual < 20)
{
    Console.WriteLine("Bateria baja, por favor cargue su celular");
    Console.WriteLine("Nivel de bateria actual: " + nivelActual + "%");
}
else if (nivelActual < 50)
{
    Console.WriteLine("Bateria media, puede seguir usando su celular");
    Console.WriteLine("Nivel de bateria actual: " + nivelActual + "%");
}
else if (nivelActual < 80)
{
    Console.WriteLine("Bateria alta, puede seguir usando su celular");
    Console.WriteLine("Nivel de bateria actual: " + nivelActual + "%");
}
else
{
    Console.WriteLine("Bateria llena, puede seguir usando su celular");
    Console.WriteLine("Nivel de bateria actual: " + nivelActual + "%");
}
