using System;

public class Rifa
{
    public static void Run()
    {
        Console.WriteLine("La rifa de Esteban");

        Console.WriteLine("Cual es tu nombre?");
        Console.Write("Escribe tu nombre: ");

        string? nombre = Console.ReadLine();

        Console.Write("Elige un número (1, 2 o 3): ");

        string? elec = Console.ReadLine();

        string premio = (elec=="1") ? "CRV" : "apartamento";

        string articulo = (premio=="CRV") ? "una" : "un";
        

        Console.WriteLine("{0}, seleccionaste {1}, por lo que ganaste {2} {3}, felicidades.", nombre, elec, articulo,premio);
        Console.ReadLine();
        
    }

}