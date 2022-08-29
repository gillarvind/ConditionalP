using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalCode
{
    internal class PerfectNum
    {
        int checkNum = 0;
        public void Number()
        {
            Console.WriteLine("take number to check its perfect or not");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= num / 2; i++)
            {
                if (num % i == 0)
                {
                    checkNum += i;
                }
            }
            if (checkNum == num)
            {
                Console.WriteLine("it's a perfect number");
            }
            else
            {
                Console.WriteLine("it's not a perfect number");
            }
        }
    }
}
