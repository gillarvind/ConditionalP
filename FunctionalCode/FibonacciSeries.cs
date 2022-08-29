using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalCode
{
    internal class FibonacciSeries
    {
        int firstNum = 0, secondNum = 1, thirdNum = 0;
        public void Series()
        {
            Console.WriteLine("enter the number to print FibonacciSeries");
            int num = Convert.ToInt32(Console.ReadLine());
            while (num > 0)
            {
                thirdNum = firstNum + secondNum;
                Console.WriteLine(thirdNum);
                firstNum = secondNum;
                secondNum = thirdNum;
                num--;
            }
        }
    }
}
