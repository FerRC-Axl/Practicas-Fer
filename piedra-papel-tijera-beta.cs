using System;

Random random = new Random();

Console.WriteLine("Piedra, papel o tijera:");
string usuario = Console.ReadLine().ToLower();

int numero = random.Next(3);
string maquina = numero == 0 ? "piedra" : numero == 1 ? "papel" : "tijera";

Console.WriteLine("La máquina eligió: " + maquina);

if (usuario == maquina)
    Console.WriteLine("Empate.");
else if ((usuario == "piedra" && maquina == "tijera") ||
         (usuario == "papel" && maquina == "piedra") ||
         (usuario == "tijera" && maquina == "papel"))
    Console.WriteLine("Ganaste.");
else
    Console.WriteLine("Perdiste.");
