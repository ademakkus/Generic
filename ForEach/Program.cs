using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForEach
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 1, 2, 3, 4, 5,6,7,8,9,10 };
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
            Console.ForegroundColor = ConsoleColor.DarkMagenta;

            Console.WriteLine("IEnumarator kullanımı");
            IEnumerator numerator = numbers.GetEnumerator();
            while (numerator.MoveNext())
            {
                Console.WriteLine(numerator.Current);
            }
            Console.ReadKey();


        }
    }
}
