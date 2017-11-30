using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_LuckyNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            bool isLucky = false;

            for (int digit1 = 1; digit1 <= 9; digit1++)
            {
                for (int digit2 = 1; digit2 <= 9; digit2++)
                {
                    for (int digit3 = 1; digit3 <= 9; digit3++)
                    {
                        for (int digit4 = 1; digit4 <= 9; digit4++)
                        {
                            if (digit1 + digit2 == digit3 + digit4)
                            {
                                if (num % (digit1+digit2) == 0)
                                {
                                    isLucky = true;
                                }
                            }

                            if (isLucky)
                            {
                                Console.Write("{0}{1}{2}{3} ", digit1, digit2, digit3, digit4);
                                isLucky = false;
                            }
                        }
                    }
                }
            }
        }
    }
}
