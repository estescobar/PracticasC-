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

                default:
                    Console.WriteLine("Invalid script number. Please enter 1, 2, or 3.");
                    break;
            }
        }
    }
}