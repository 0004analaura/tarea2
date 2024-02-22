using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leer_teclado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Suma de dos numeros");
            Console.WriteLine("Ingrese el numero 1");

            string dato = Console.ReadLine();
            int n1 = int.Parse(dato);

            Console.WriteLine("Ingresa el numero 2:");
            dato = Console.ReadLine();
            int n2 = int.Parse(dato);

            int suma = n1 + n2;

            Console.WriteLine("El Resultado de la suma es:´{0}", suma);

            Console.ReadKey(true);
        }
    }
}
