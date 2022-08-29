using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalCode
{
    internal class ConversionP
    {
        double f, c;
        public void Conver()
        {
            Console.WriteLine("choose any one for conversion\n1.Fahrenheit to Celsius\n2.Celsius to Fahrenheit");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Console.WriteLine("enter fahrenheit temp", f);
                    f = Convert.ToDouble(Console.ReadLine());
                    c = (double)(f - 32) * 5 / 9;
                    Console.WriteLine("Celsius tem:" + c);
                    break;
                case 2:
                    Console.WriteLine("enter celsius temp", c);
                    c = Convert.ToDouble(Console.ReadLine());
                    f = (double)((9 * c) / 5) + 32;
                    Console.WriteLine("Fahrenheit temp:" + f);
                    break;
                default:
                    Console.WriteLine("enter valid number");
                    break;
            }
        }
    }
}
