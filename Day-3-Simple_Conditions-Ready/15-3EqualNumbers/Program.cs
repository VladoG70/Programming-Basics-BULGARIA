using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_3EqualNumbers
    {
    class Program
        {
        static void Main(string[] args)
            {
            var n1 = double.Parse(Console.ReadLine());
            var n2 = double.Parse(Console.ReadLine());
            var n3 = double.Parse(Console.ReadLine());

            if (n1 == n2)
                {
                if (n2 == n3)
                    {
                    Console.WriteLine("yes");
                    }
                else
                    {
                    Console.WriteLine("no");
                    }
                }
            else
                {
                Console.WriteLine("no");
                }
            }
        }
    }
