﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntradaSalida
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nombre;

            Console.WriteLine("Escribe tu nombre:");
            nombre = Console.ReadLine();
            Console.WriteLine("Hola " + nombre);
            Console.Read();
        }
    }
}
