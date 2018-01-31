using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Water_Overflow
{
    class Program
    {
        static void Main(string[] args)
        {
            short n = short.Parse(Console.ReadLine());

            short capacity = 255;
            short liters = capacity;

            for (short i = 0; i < n; i++)
            {
                short currentLiters = short.Parse(Console.ReadLine());

                if (liters - currentLiters >= 0)
                {
                    liters -= currentLiters;
                }
                else
                {
                    Console.WriteLine("Insufficient capacity!");
                }
            }

            short result = (short)(capacity - liters);
            Console.WriteLine(result);
        }
    }
}

