using System;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("Please specify a script to run (1, 2, or 3).");
                return;
            }

            switch (args[0])
            {
                case "1":
                    HelloWorld.Run();
                    break;

                case "2":
                    Saludo.Run();
                    break;    

                case "3":
                    Rifa.Run();
                    break;   

                case "4":
                    Triangulos.Run();
                    break;   

                case "5":
                    Promedio.Run();
                    break;  

                default:
                    Console.WriteLine("Invalid script number. Please enter 1, 2, or 3.");
                    break;
            }
        }
    }
}