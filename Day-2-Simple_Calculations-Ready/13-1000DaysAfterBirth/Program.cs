using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_1000DaysAfterBirth
    {
    class Program
        {
        static void Main(string[] args)
            {
            string format = "dd-MM-yyyy"; // DATE Format
            //Console.Write("ENTER Date: ");
            var dateIN = DateTime.ParseExact(Console.ReadLine(), format, null); // Get Date from Console
            //var dateIN = DateTime.ParseExact(Console.ReadLine(), format, CultureInfo.InvariantCulture); // Get Date from Console

            // Console.WriteLine("ENTER: " + dateIN);
            var date1000 = dateIN.AddDays(1000 - 1);

            //DateTime date1000 = dateIN.AddDays(1000 - 1);
            //Console.WriteLine("OUT: " + date1000.ToString(format));
            Console.WriteLine(date1000.ToString(format));

            // FOR EXAMPLE:
            //DateTime today = DateTime.Now;
            //DateTime answer = today.AddDays(36);
            //Console.WriteLine("Today: {0:dddd}", today);
            //Console.WriteLine("36 days from today: {0:dddd}", answer);
            }
        }
    }
