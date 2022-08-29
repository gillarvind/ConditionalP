namespace FunctionalCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("select program \n1.Conversion Program\n2.ReverseNumber Program\n3.Prime Number Porgram\n4.Fibonacci Series Program\n5.\n5.Perfect Number Program");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        ConversionP conversionP = new ConversionP();
                        conversionP.Conver();
                        break;
                    case 2:
                        ReverseNumber reverseNumber = new ReverseNumber();
                        reverseNumber.RevNumber();
                        break;
                    case 3:
                        PrimeNumer primeNumer = new PrimeNumer();
                        primeNumer.Prime();
                        break;
                    case 4:
                        PerfectNum perfectNum = new PerfectNum();
                        perfectNum.Number();
                        break;
                    case 5:
                        FibonacciSeries fibonacciSeries = new FibonacciSeries();
                        fibonacciSeries.Series();
                        break;
                    default:
                        Console.WriteLine("enter correct number");
                        break;
                }
            }
        }
    }
    }
}