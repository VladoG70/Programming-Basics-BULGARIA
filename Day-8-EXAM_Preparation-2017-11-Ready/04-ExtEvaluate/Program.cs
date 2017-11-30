using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_ExtEvaluate
{
    class Program
    {
        static void Main(string[] args)
        {
            int students = int.Parse(Console.ReadLine());

            int poorMarks = 0;
            int satisfactoryMarks = 0;
            int goodMarks = 0;
            int veryGoodMarks = 0;
            int excellentMarks = 0;
            double totalMarks = 0;


            for (int i = 0; i < students; i++)
            {
                double points = double.Parse(Console.ReadLine());

                if (points < 22.5)
                {
                    poorMarks++;
                    totalMarks++;
                }
                else
                {
                    if (points >= 22.5 && points < 40.5)
                    {
                        satisfactoryMarks++;
                        totalMarks++;
                    }
                    else
                    {
                        if (points >= 40.5 && points < 58.5)
                        {
                            goodMarks++;
                            totalMarks++;
                        }
                        else
                        {
                            if (points >= 58.5 && points < 76.5)
                            {
                                veryGoodMarks++;
                                totalMarks++;
                            }
                            else
                            {
                                if (points >= 76.5 && points <= 100)
                                {
                                    excellentMarks++;
                                    totalMarks++;
                                }
                            }
                        }
                    }
                }
            }

            Console.WriteLine("{0:F2}% poor marks", poorMarks / totalMarks * 100);
            Console.WriteLine("{0:F2}% satisfactory marks", satisfactoryMarks / totalMarks * 100);
            Console.WriteLine("{0:F2}% good marks", goodMarks / totalMarks * 100);
            Console.WriteLine("{0:F2}% very good marks", veryGoodMarks / totalMarks * 100);
            Console.WriteLine("{0:F2}% excellent marks", excellentMarks / totalMarks * 100);
        } // End of MAIN
    }
}
