using System;

class Program
{
    static void Main()
    {
        // Título em Amarelo dando destaque
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("========================================");
        Console.WriteLine("       Noites Traçoeiras - Louvor       ");
        Console.WriteLine("========================================");
        Console.ResetColor();
        Console.WriteLine();

        // Estrofe normal em branco
        Console.WriteLine("Ainda que a figueira não floresça");
        Console.WriteLine("E não haja fruto na vide");
        Console.WriteLine("Ainda que a comovente história");
        Console.WriteLine("Pareça não ter fim");
        Console.WriteLine();

        // Refrão em Ciano dando destaque
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("--- REFRÃO ---");
        Console.WriteLine("Ainda que vierem noites traçoeiras");
        Console.WriteLine("Se a cruz pesada for, Ele te sustentará");
        Console.WriteLine("A dor pode durar uma noite");
        Console.WriteLine("Mas a alegria vem pela manhã!");
        Console.ResetColor();
        Console.WriteLine();

        // Volta a cor original ao terminar
        Console.ResetColor();
    }
}
