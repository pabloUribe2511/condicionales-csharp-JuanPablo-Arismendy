Console.Write("Ingresa una letra:");

char letra = char.Parse(Console.ReadLine())!;
letra = char.ToLower(letra);

if (letra == 'a' || letra == 'e' || letra == 'i' || letra == 'o' || letra == 'u')
{
    Console.WriteLine("La letra es una vocal");
}
else
{
    Console.WriteLine("La letra es una consonante");
}