using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_12_EqualPairs_1
    {
    class Program
        {
        static void Main(string[] args)
            {
            var n = int.Parse(Console.ReadLine());
            double num;
            int pairCount = 0;
            int pairEQ = 1; // 1-equal 0-different 
            int checkPairCount = 0;
            double pairSum = 0.0;
            double pairSumOLD = 0.0;
            double maxDiff = 0.0;
            double pairMax = 0.0;

            for (int i = 0; i < (2 * n); i++)
                {
                if (n == 1)   // only n=1
                    {
                    num = double.Parse(Console.ReadLine());
                    pairCount += 1;
                    pairSum += num;
                    if (i == 0)
                        {
                        pairCount = 0;
                        pairSumOLD = pairSum;
                        pairSum = 0;
                        }
                    if (i == 1)
                        {
                        if (pairSum == pairSumOLD)
                            {
                            Console.WriteLine("Yes, value={0}", (pairSum + pairSumOLD));
                            }
                        else
                            {
                            maxDiff = Math.Max(pairSum, pairSumOLD) - Math.Min(pairSum, pairSumOLD);
                            Console.WriteLine("No, maxdiff={0}", maxDiff);
                            }
                        }

                    }
                else // If n>1 ----------------------------------------
                    {
                    num = double.Parse(Console.ReadLine());
                    pairCount += 1;
                    pairSum += num;
                    checkPairCount += 1;
                    if (pairCount == 2)
                        {
                        if (i >= 3)
                            {
                            maxDiff = Math.Max(pairSum, pairSumOLD) - Math.Min(pairSum, pairSumOLD);
                            }
                        if (i == 3)
                            {
                            pairMax = maxDiff;
                            }
                        pairCount = 0;
                        if (checkPairCount == 4)
                            {
                            checkPairCount = 0;
                            if (!(pairSum == pairSumOLD))
                                {
                                pairEQ = 0;
                                }
                            }
                        if (maxDiff > pairMax)
                            {
                            pairMax = maxDiff;
                            }
                        pairSumOLD = pairSum;
                        pairSum = 0.0;
                        }
                    }
                } // end For
            if (n > 1)
                {


                if (pairEQ == 1)
                    {
                    Console.WriteLine("Yes, value={0}", pairSumOLD);
                    }
                else
                    {
                    Console.WriteLine("No, maxdiff={0}", pairMax);
                    }
                }
            }
        }
    }
