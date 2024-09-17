using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace if_odd_or_even
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int k;
            Console.Write("Enter the number-->");
            k = int.Parse(Console.ReadLine());
            if (k % 2 == 0)
            { Console.Write("This is an Even numbar");
                Console.ReadLine();
            
            }
            else
            { Console.Write("This is an ODD number");
                Console.ReadLine();
            }
        }
    }
}
