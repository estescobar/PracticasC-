using System;

public class Saludo
{
    public static void Run()
    {
        Console.WriteLine("Cual es tu nombre?");
        Console.Write("Escribe tu nombre: ");

        string? nombre = Console.ReadLine();

        Console.WriteLine("Cual es tu apellido?");
        Console.Write("Escribe tu apellido: ");

        string? apellido = Console.ReadLine();
        
        Console.WriteLine("Hola, "+nombre+" "+apellido+".");
        Console.ReadLine();

    }
}