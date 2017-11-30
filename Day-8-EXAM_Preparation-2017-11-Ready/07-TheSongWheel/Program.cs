using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_TheSongWheel
{
    class Program
    {
        static void Main(string[] args)
        {
            int m = int.Parse(Console.ReadLine());
            int count = 0;
            bool isPass = false;
            int pass = -1;

            for (int digit1 = 1; digit1 <= 9; digit1++)
            {
                for (int digit2 = 1; digit2 <= 9; digit2++)
                {
                    for (int digit3 = 1; digit3 <= 9; digit3++)
                    {
                        for (int digit4 = 1; digit4 <= 9; digit4++)
                        {
                            if (digit1 < digit2 && digit3 > digit4)
                            {
                                if (m == (digit1 * digit2 + digit3 * digit4))
                                {
                                    count++;
                                    if (count == 4)
                                    {
                                        pass = digit1 * 1000 + digit2 * 100 + digit3 * 10 + digit4;
                                    }
                                    isPass = true;
                                }
                            }

                            if (isPass)
                            {
                                Console.Write("{0}{1}{2}{3} ", digit1, digit2, digit3, digit4);
                                isPass = false;
                            }
                        }
                    }
                }
            }

            Console.WriteLine();

            if (pass != -1)
            {
                Console.WriteLine("Password: {0}", pass);
            }
            else
            {
                Console.WriteLine("No!");
            }
        } // End of MAIN
    }
}
