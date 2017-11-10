using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_Roundings
{
    class Roundings
    {
        static void Main(string[] args)
        {
            double a = 123.321;
            double b = 123.456;
            double c = 123.556;
            double d = 123.789;
            double e = -123.789;
            double f = -124.2;

            Console.WriteLine("Math.Truncate:");
            Console.WriteLine("Truncate rounds <a, b, c, d> to the nearest integer towards ZERO.");
            Console.WriteLine("Math.Truncate eliminates numbers after the decimal. It acts upon a decimal or floating-point number. It calculate the integral part of a number. Math.Truncate is reliable and easy-to-use. Its functionality differs from Math.Round.");
            Console.WriteLine($"a = {a} -Truncate-> {Math.Truncate(a)}");
            Console.WriteLine($"b = {b} -Truncate-> {Math.Truncate(b)}");
            Console.WriteLine($"c = {c} -Truncate-> {Math.Truncate(c)}");
            Console.WriteLine($"d = {d} -Truncate-> {Math.Truncate(d)}");
            Console.WriteLine($"e = {e} -Truncate-> {Math.Truncate(e)}");
            Console.WriteLine($"f = {f} -Truncate-> {Math.Truncate(f)}");

            Console.WriteLine("--------------------------------------------------------------------");

            Console.WriteLine("Math.Floor:");
            Console.WriteLine("Returns the largest integer less than or equal to the specified double-precision floating-point number.");
            Console.WriteLine("Math.Floor rounds down. It operates on types such as decimal or double. It reduces the value to the nearest integer. The Floor method is straightforward, but useful, when it is called for in programming.");
            Console.WriteLine($"a = {a} -Floor-> {Math.Floor(a)}");
            Console.WriteLine($"b = {b} -Floor-> {Math.Floor(b)}");
            Console.WriteLine($"c = {c} -Floor-> {Math.Floor(c)}");
            Console.WriteLine($"d = {d} -Floor-> {Math.Floor(d)}");

            Console.WriteLine("--------------------------------------------------------------------");

            Console.WriteLine("Math.Ceiling:");
            Console.WriteLine("Returns the smallest integral value that is greater than or equal to the specified double-precision floating-point number.");
            Console.WriteLine("Math.Ceiling rounds up to the next full integer. This means that any number over 1 but under 2 would be rounded to 2.");
            Console.WriteLine($"a = {a} -Ceiling-> {Math.Ceiling(a)}");
            Console.WriteLine($"b = {b} -Ceiling-> {Math.Ceiling(b)}");
            Console.WriteLine($"c = {c} -Ceiling-> {Math.Ceiling(c)}");
            Console.WriteLine($"d = {d} -Ceiling-> {Math.Ceiling(d)}");

            Console.WriteLine("--------------------------------------------------------------------");

            Console.WriteLine("Math.Round:");
            Console.WriteLine("Rounds a value to the NEAREST integer or to the specified number of fractional digits.");
            Console.WriteLine("Math.Round. This method rounds numbers to the nearest value. It receives the desired number of significant digits. It is part of the System namespace.");
            Console.WriteLine($"a = {a} -Round-> {Math.Round(a)}");
            Console.WriteLine($"b = {b} -Round-> {Math.Round(b)}  <--- Attention!");
            Console.WriteLine($"c = {c} -Round-> {Math.Round(c)}");
            Console.WriteLine($"d = {d} -Round-> {Math.Round(d)}");

            Console.WriteLine("--------------------------------------------------------------------");
        }
    }
}
