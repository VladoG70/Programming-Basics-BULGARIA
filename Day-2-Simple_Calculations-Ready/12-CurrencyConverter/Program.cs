using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_CurrencyConverter
    {
    class Program
        {
        static void Main(string[] args)
            {
            var bgnTOusd = 1.79549m;
            var bgnTOeur = 1.95583m;
            var bgnTOgbp = 2.53405m;
            var outSUM = 0m;

            Console.Write("Enter SUM = ");
            var SUM = decimal.Parse(Console.ReadLine());
            Console.Write("Enter INput currency: ");
            var inCurrency = Console.ReadLine();
            Console.Write("Enter OUTput currency: ");
            var outCurrency = Console.ReadLine();


            switch (inCurrency)
                {
                case "BGN":
                    switch (outCurrency)
                        {
                        case "USD": outSUM = SUM / bgnTOusd; break;
                        case "EUR": outSUM = SUM / bgnTOeur; break;
                        case "GBP": outSUM = SUM / bgnTOgbp; break;
                        }
                    break;
                case "USD":
                    switch (outCurrency)
                        {
                        case "BGN": outSUM = SUM * bgnTOusd; break;
                        case "EUR": outSUM = (SUM * bgnTOusd) / bgnTOeur; break;
                        case "GBP": outSUM = (SUM * bgnTOusd) / bgnTOgbp; break;
                        }
                    break;
                case "EUR":
                    switch (outCurrency)
                        {
                        case "BGN": outSUM = SUM * bgnTOeur; break;
                        case "USD": outSUM = (SUM * bgnTOeur) / bgnTOusd; break;
                        case "GBP": outSUM = (SUM * bgnTOeur) / bgnTOgbp; break;
                        }
                    break;
                case "GBP":
                    switch (outCurrency)
                        {
                        case "BGN": outSUM = SUM * bgnTOgbp; break;
                        case "USD": outSUM = (SUM * bgnTOgbp) / bgnTOusd; break;
                        case "EUR": outSUM = (SUM * bgnTOgbp) / bgnTOeur; break;
                        }
                    break;
                }
            Console.WriteLine(new string('-', 10));
            Console.WriteLine(Math.Round(outSUM, 2) + " " + outCurrency);
            Console.WriteLine(new string('-', 10));
            Console.WriteLine("INput currency = " + inCurrency);
            Console.WriteLine("OUTput currency = " + outCurrency);
            }
        }
    }
