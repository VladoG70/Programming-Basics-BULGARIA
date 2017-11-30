using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Fishland_2016
    {
    class ProgramFishland
        {
        static void Main(string[] args)
            {
            decimal skumriaPrice = decimal.Parse(Console.ReadLine());
            decimal cacaPrice = decimal.Parse(Console.ReadLine());
            decimal palamud = decimal.Parse(Console.ReadLine());
            decimal safrid = decimal.Parse(Console.ReadLine());
            decimal midi = decimal.Parse(Console.ReadLine());

            decimal palamudPrice = skumriaPrice * 1.6m;
            decimal safridPrice = cacaPrice * 1.8m;
            decimal midiPrice = 7.50m;

            decimal sum = palamud * palamudPrice + safrid * safridPrice + midi * midiPrice;
            sum = Math.Round(sum, 2);

            Console.WriteLine(sum);
            }
        }
    }
