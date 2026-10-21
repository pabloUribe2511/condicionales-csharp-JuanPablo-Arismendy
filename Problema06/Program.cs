Console.Write("Ingresa tu acccion jugador1 (piedra, papel o tijera): ");
string accionUsuario = Console.ReadLine();

Console.Write("Ingresa la accion jugador2(piedra, papel o tijera): ");
string accionUsuario2 = Console.ReadLine();

if (accionUsuario == accionUsuario2)
{
    Console.WriteLine("Empate");
}
else if ((accionUsuario == "piedra" && accionUsuario2 == "tijera") || (accionUsuario == "papel" && accionUsuario2 == "piedra") || (accionUsuario == "tijera" && accionUsuario2 == "papel"))
{
    Console.WriteLine("Jugador 1 gana");
}
else
{
    Console.WriteLine("Jugador 2 gana");
}
