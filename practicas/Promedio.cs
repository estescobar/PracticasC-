using System;

public class Promedio
{
    public static void Run()
    {
        double[] calificaciones = new double[3];

        for (int i = 0; i < calificaciones.Length; i++)
        {
            Console.Write($"Ingresa la calificación de la asignatura {i + 1}: ");
            calificaciones[i] = Convert.ToDouble(Console.ReadLine());
        }

        double suma = 0;
        foreach (double calificacion in calificaciones)
        {
            suma += calificacion;
        }
        double promedio = suma / calificaciones.Length;

        Console.WriteLine($"El promedio de las calificaciones es: {promedio}");
    }
}