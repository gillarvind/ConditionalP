using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalCode
{
    internal class PrimeNumer
    {
        int count = 0;
        public void Prime()
        {
            Console.WriteLine("check number is prime number or not");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    count++;
                }
                if (count == 2)
                {
                    Console.WriteLine("this is a prime number");
                }
                else
                {
                    Console.WriteLine("this is not a prime number");
                }
            }
        }
    }
}
