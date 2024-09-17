using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leap_year
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the year-->");
            int year = int.Parse(Console.ReadLine());
            if (year % 4 == 0)
            {
                Console.Write("It is an Leap year");
                Console.ReadLine();
            }
            else
            {
                Console.Write("It is Not an Leap Year");
                Console.ReadLine();
            }
        }
    }
}
