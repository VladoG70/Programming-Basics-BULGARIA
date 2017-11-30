using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _04_Logistics
    {
    class Logistics
        {
        static void Main(string[] args)
            {
            var number = int.Parse(Console.ReadLine());

            var totalLoads = 0.0;
            var loadsWithBus = 0;
            var loadsWithTruck = 0;
            var loadsWithTrain = 0;
            var averageLoadsSum = 0.0;

            for (int i = 1; i <= number; i++)
                {
                var load = int.Parse(Console.ReadLine());
                totalLoads = totalLoads + load;

                if (load <= 3)
                    {
                    loadsWithBus = loadsWithBus + load;
                    }
                else
                    {
                    if (load >= 4 && load <= 11)
                        {
                        loadsWithTruck = loadsWithTruck + load;
                        }
                    else
                        {
                        loadsWithTrain = loadsWithTrain + load;
                        }
                    }
                }
            averageLoadsSum = (loadsWithBus * 200 + loadsWithTruck * 175 + loadsWithTrain * 120) / totalLoads;
            Console.WriteLine("{0:F2}", averageLoadsSum);
            Console.WriteLine("{0:F2}%", (loadsWithBus/totalLoads) * 100.00);
            Console.WriteLine("{0:F2}%", (loadsWithTruck/totalLoads) * 100.00);
            Console.WriteLine("{0:F2}%", (loadsWithTrain/totalLoads) * 100.00);
            }
        }
    }
