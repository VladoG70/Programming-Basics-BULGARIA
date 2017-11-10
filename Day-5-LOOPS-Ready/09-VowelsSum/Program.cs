using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_VowelsSum
    {
    class Program
        {
        static void Main(string[] args)
            {
            var word = Console.ReadLine();
            char letterW;
            var sumVowels = 0;

            for (int i = 0; i < word.Length; i++)
                {
                letterW = word[i];
                if (letterW == 'a')
                    {
                    sumVowels += 1;
                    }
                else
                    {
                    if (letterW == 'e')
                        {
                        sumVowels += 2;
                        }
                    else
                        {
                        if (letterW == 'i')
                            {
                            sumVowels += 3;
                            }
                        else
                            {
                            if (letterW == 'o')
                                {
                                sumVowels += 4;
                                }
                            else
                                {
                                if (letterW == 'u')
                                    {
                                    sumVowels += 5;
                                    }
                                }
                            }
                        }
                    }
                }
            Console.WriteLine(sumVowels);
            }
        }
    }
