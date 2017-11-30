using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_WireNet
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            double price = double.Parse(Console.ReadLine());
            double weight = double.Parse(Console.ReadLine());
            double lenght;
            double totalPrice;
            double totalWeight;

            lenght = 2 * a + 2 * b;
            totalPrice = lenght * price;
            totalWeight = (lenght * h) * weight;

            Console.WriteLine("{0}", lenght);
            Console.WriteLine("{0:F2}", totalPrice);
            Console.WriteLine("{0:F3}", totalWeight);
        }
    }
}
