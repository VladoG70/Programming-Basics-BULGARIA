using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_LettersComb
    {
    class ProgramLettersComb
        {
        static void Main(string[] args)
            {
            char begin = char.Parse(Console.ReadLine());
            char end = char.Parse(Console.ReadLine());
            char exclude = char.Parse(Console.ReadLine());
            int count = 0;

            for (int firstLetter = begin; firstLetter <= end; firstLetter++)
                {
                if (firstLetter != exclude)
                    {
                    for (int secondLetter = begin; secondLetter <= end; secondLetter++)
                        {
                        if (secondLetter != exclude)
                            {
                            for (int thirdLetter = begin; thirdLetter <= end; thirdLetter++)
                                {
                                if (thirdLetter != exclude)
                                    {
                                    Console.Write("{0}{1}{2} ", (char)firstLetter, (char)secondLetter, (char)thirdLetter);
                                    count++;
                                    }

                                }
                            }

                        }
                    }

                }
            Console.WriteLine(count);

            }
        }
    }
