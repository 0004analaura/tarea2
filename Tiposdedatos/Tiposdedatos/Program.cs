﻿using System;

namespace tiposdeDatos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            sbyte byteConSigno = sbyte.MaxValue; 
            byte byteSinSigno = byte.MaxValue;
            short shortConSingo = short.MaxValue;
            ushort shortSinSigno = ushort.MaxValue;
            int intConSigno = int.MaxValue;
            uint intSinSigno = uint.MaxValue;
            long longConSingo = long.MaxValue;
            ulong longSinSigno = ulong.MaxValue;
            float floatValor = float.MaxValue;
            double doubleValor = double.MaxValue;
            decimal decimalValor = decimal.MaxValue;




            Console.WriteLine("Max[sbtye]: {0} ", byteConSigno);
            Console.WriteLine("Max[btye]: {0} ", byteSinSigno);
            Console.WriteLine("Max[short]: {0} ", shortConSingo);
            Console.WriteLine("Max[ushort]: {0} ", shortSinSigno);
            Console.WriteLine("Max[int]: {0} ", intConSigno);
            Console.WriteLine("Max[uint]: {0} ", intSinSigno);
            Console.WriteLine("Max[long]: {0} ", longConSingo);
            Console.WriteLine("Max[ulong]: {0} ", longSinSigno);
            Console.WriteLine("Max[float]: {0} ", floatValor);
            Console.WriteLine("Max[double]: {0} ", doubleValor);
            Console.WriteLine("Max[decimal]: {0} ", decimalValor);

            Console.ReadKey(true);


        }
    }
}