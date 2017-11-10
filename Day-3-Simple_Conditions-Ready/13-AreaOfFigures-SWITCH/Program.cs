using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_AreaOfFigures_SWITCH
    {
    class Program
        {
        static void Main(string[] args)
            {
            double area = 0;
            Console.Write("Enter kind of figure: ");
            var kindOfFigure = Console.ReadLine();

            switch (kindOfFigure)
                {
                case "square":
                        {
                        var a = double.Parse(Console.ReadLine());
                        area = a * a;
                        }
                    break;
                case "rectangle":
                        {
                        var a = double.Parse(Console.ReadLine());
                        var b = double.Parse(Console.ReadLine());
                        area = a * b;
                        }
                    break;
                case "circle":
                        {
                        var r = double.Parse(Console.ReadLine());
                        area = Math.PI * r * r;
                        }
                    break;
                case "triangle":
                        {
                        var a = double.Parse(Console.ReadLine());
                        var ha = double.Parse(Console.ReadLine());
                        area = (a * ha) / 2;
                        }
                    break;
                }
            Console.WriteLine(Math.Round(area, 3));
            }
        }
    }
