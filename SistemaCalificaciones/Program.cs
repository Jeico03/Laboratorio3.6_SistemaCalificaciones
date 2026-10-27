using System;

namespace SistemaCalificaciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido al sistema de calificaciones.");

            Console.WriteLine("Introduzca el nombre del estudiante:");
            string nombre = Console.ReadLine();

            Console.WriteLine("Introduzca la nota del estudiante:");
            string notaInput = Console.ReadLine();

            decimal nota;

            if (decimal.TryParse(notaInput, out nota))
            {
                if (nota >= 0 && nota <= 100)
                {
                    string clasificacion = "";
                    string condicion = "";

                    if (nota >= 90)
                    {
                        clasificacion = "Excelente";
                        condicion = "Aprobado";
                    }
                    else if (nota >= 80)
                    {
                        clasificacion = "Muy bueno";
                        condicion = "Aprobado";
                    }
                    else if (nota >= 70 && nota < 80)
                    {
                        clasificacion = "Aprobado";
                        condicion = "Aprobado";
                    }
                    else
                    {
                        clasificacion = "Reprobado";
                        condicion = "Reprobado";
                    }

                    Console.WriteLine("\n----------------------------------------");
                    Console.WriteLine($"Estudiante: {nombre}");
                    Console.WriteLine($"Calificación: {nota}");
                    Console.WriteLine($"Clasificación: {clasificacion}");
                    Console.WriteLine($"Condición: {condicion}");
                    Console.WriteLine("----------------------------------------");
                }
                else
                {
                    Console.WriteLine("Nota inválida. Por favor, introduzca una nota entre 0 y 100.");
                }
            }
            else
            {
                Console.WriteLine("La nota introducida no es válida.");
            }
        }
    }
}