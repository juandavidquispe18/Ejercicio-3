using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ingresar y definir datos
            Console.Write("Ingrese el número de notas: ");
            int cantidad = int.Parse(Console.ReadLine());
            double suma_notas = 0;

            //Hallar el promedio de notas
            for (int i = 1; i <= cantidad; i++) {
                
                Console.Write($"Ingrese la nota {i}: ");
                double nota = double.Parse(Console.ReadLine());
                suma_notas += nota;
            }

            //Mostrar resultados
            double promedio = suma_notas / cantidad;
            Console.WriteLine($"El promedio es: {promedio}");
            Console.ReadKey();
        }
    }
}
