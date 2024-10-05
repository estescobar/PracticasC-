using System;

public class Triangulos
{
    public static void Run()
    {
        Console.WriteLine("Ingresa un numero: ");

        if (int.TryParse(Console.ReadLine(), out int largo))
        {
            for (int i = 1; i <= largo; i++)
            {
                string r="*";
                for (int k = 1; k < i; k++)
                {
                    r+="*";
                }
                Console.WriteLine(r);

                
            }
        }
    }
}