using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalCode
{
    internal class ReverseNumber
    {
        int reverse = 0, rem;
        public void RevNumber()
        {
            Console.WriteLine("enter a number to reverse");
            int num = Convert.ToInt32(Console.ReadLine());
            while (num != 0)
            {
                rem = num % 10;
                reverse = (reverse * 10) + rem;
                num = num / 10;
            }
            Console.WriteLine("reverse number is:" + reverse);
        }
    }
}
