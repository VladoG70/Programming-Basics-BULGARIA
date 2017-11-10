using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_BonusScore
    {
    class Program
        {
        static void Main(string[] args)
            {
            var bonusScore = 0.0;
            var extraBonus = 0;
            var totalScore = 0.0;
            Console.Write("Eneter score = ");
            var score = int.Parse(Console.ReadLine());

            if (score <= 100)
                {
                bonusScore += 5;
                }
            else
                {
                if (score > 100 && score <= 1000)
                    {
                    bonusScore = score * 0.2;
                    }
                else
                    {
                    bonusScore = score * 0.1;
                    }
                }

            if ((score % 2) == 0)
                {
                extraBonus += 1;
                // Console.WriteLine("Numbur EVEN !!! " + score);
                }
            else
                {
                if ((score % 5) == 0) // Verification about 5 !!!!!!!!!!!!
                    {
                    // Console.WriteLine("Numbur XXXX(5)!!! " + score);
                    extraBonus += 2;
                    }
                }

            bonusScore += extraBonus;
            totalScore = score + bonusScore;
            Console.WriteLine("Bonus score: " + bonusScore);
            Console.WriteLine("Total score: " + totalScore);
            }
        }
    }
