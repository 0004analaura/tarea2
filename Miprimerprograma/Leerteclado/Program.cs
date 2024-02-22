using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leerteclado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Suma de dos numeros");
            Console.WriteLine("Ingresa numero 1");
            //Los datos se leen como cadena
            string dato = Console.ReadLine();
            //Convertir a numero con int.parse
            int n1 = int.Parse(dato);


            Console.WriteLine("Ingresa numero 2: ");
            dato = Console.ReadLine();
            int n2 = int.Parse(dato);
            int suma = n1 + n2;
            Console.WriteLine("El resultados es: {0}", suma);
            Console.ReadKey(true);

        }
    }
}
