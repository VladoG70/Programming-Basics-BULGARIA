using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_USDtoBGN
    {
    class Program
        {
        static void Main(string[] args)
            {
            Console.Write("Enter USD = ");
            var usd = double.Parse(Console.ReadLine());
            var oneUSD_BGN = 1.79549;
            var BGN = usd * oneUSD_BGN;
            Console.WriteLine(Math.Round(BGN, 2) + " BGN");
            }
        }
    }
