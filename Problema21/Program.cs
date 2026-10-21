Console.Write("Ingrese la cantidad de artículos en el carrito: ");
int cantidad = int.Parse(Console.ReadLine() ?? string.Empty);

string mensaje = $"Tienes {cantidad} {(cantidad == 1 ? "artículo" : "artículos")} en el carrito";
Console.WriteLine(mensaje);
