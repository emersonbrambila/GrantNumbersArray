using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Grant_Number_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = { 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144 };
            IEnumerable<int> grantNumberArray = (from element in numeros where element % 2 == 1 select element);

            Console.Write("O seguinte array contém somente números ímpares: ");

            foreach (int element in grantNumberArray)
            {
                Console.Write($"{element} ");
            }

            Console.WriteLine("\n Pressione Enter para sair...");
            Console.Read();
        }
    }
}