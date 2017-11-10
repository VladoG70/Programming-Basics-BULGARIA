using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_TrainingLab
    {
    class Program
        {
        static void Main(string[] args)
            {
            double w = 1.0;
            double h = 2.0;
            int seats = 0;
            int row = 0;
            int col = 0;

            do // 3<= h <= w <=100
                {
                w = double.Parse(Console.ReadLine());
                h = double.Parse(Console.ReadLine());
                } while (h < 3 || w > 100 || w < h);

            h -= 1; // Corridor - 1 meter
            // Convert to centimeters
            h *= 100;
            w *= 100;


            col = Convert.ToInt16(w) / 120;
            row = Convert.ToInt16(h) / 70;

            seats = row * col - 3;
            Console.WriteLine(seats);
            }
        }
    }
