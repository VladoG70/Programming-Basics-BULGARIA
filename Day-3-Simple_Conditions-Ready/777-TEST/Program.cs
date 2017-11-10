using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _777_TEST
    {
    class Program
        {
        static void Main(string[] args)
            {
            var test = Console.Read(); // Чете само 1 СИМВОЛ
            Console.WriteLine((char)test);

            var test1 = int.Parse(Console.ReadLine()); // Чете цял НИЗ/СТРИНГ
            Console.Write(test1);

            Console.Write("1-ви ред -> Използваме Console.Write()");
            Console.WriteLine("2-ви ред -> ТЕКСТ-1 ...");

            Console.WriteLine("3-ти ред -> Използваме Console.WriteLine()");
            Console.WriteLine("4-ти ред -> ТЕКСТ-2 ...");

            var a = 5;
            var b = 7;
            var c = 8;
            var sum = a + b + c;
            var d = 0.5;

            Console.WriteLine("Eto tova poluchavame: " + a + " - " + (b + c) + sum); // Eto....: 57820
            Console.WriteLine("Eto: {0} - {1} - {2} - {3}", a, b, c, sum); // Eto: 5 - 7 - 8 - 20

            Console.WriteLine("ФОРМАТИРАНЕ:");
            Console.WriteLine("{0:F3}", d);
            }
        }
    }
