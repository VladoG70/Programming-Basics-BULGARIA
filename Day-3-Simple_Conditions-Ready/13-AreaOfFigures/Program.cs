using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_AreaOfFigures
    {
    class Program
        {
        static void Main(string[] args)
            {
            // square, rectangle, circle или triangle
            var figure = Console.ReadLine();
            var area = 0.0;

            if (figure == "square")
                {
                var a = double.Parse(Console.ReadLine());
                area = a * a;
                Console.WriteLine(Math.Round(area,3));
                }
            else
                {
                if (figure == "rectangle")
                    {
                    var a = double.Parse(Console.ReadLine());
                    var b = double.Parse(Console.ReadLine());
                    area = a * b;
                    Console.WriteLine(Math.Round(area, 3));
                    //Console.WriteLine("{0:F3}", area);
                    }
                else
                    {
                    if (figure == "circle")
                        {
                        var r = double.Parse(Console.ReadLine());
                        area = Math.PI * r * r;
                        Console.WriteLine(Math.Round(area, 3));
                        //Console.WriteLine("{0:F3}", area);
                        }
                    else
                        {
                        if (figure == "triangle")
                            {
                            var a = double.Parse(Console.ReadLine());
                            var ha = double.Parse(Console.ReadLine());
                            area = (1.0 / 2.0) * a * ha;
                            Console.WriteLine(Math.Round(area, 3));
                            //Console.WriteLine("{0:F3}", area);
                            }
                        }
                    }
                }



            }
        }
    }
