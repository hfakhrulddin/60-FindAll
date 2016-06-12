using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindAll
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] evenNumbers = Array.FindAll<int>(numbers, i => i % 2 == 0);
            foreach (int n in evenNumbers)
            {

                Console.WriteLine(n);
            }
            Console.ReadLine();
        }

        static int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
    }
    }
}
