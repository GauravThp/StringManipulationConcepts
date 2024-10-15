using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumofDigitsEven
{
    public class EvenSumDigits
    {
        public static void Main(string[] args)
        {
            int num = 20;
            Console.WriteLine(CountEven(num));
        }

        public static int CountEven(int num)
        {
            int count = 0;

            for (int i = 1; i <= num; i++)
            {
                if (SumofDigits(i) % 2 == 0)
                {
                    count++;
                }
                
            }

            return count;
        }
         public static int SumofDigits(int n)
        {
            int sum = 0;

            while (n > 0 )
            {
                sum += n % 10;
                n /= 10;

            }
            return sum;


        }


    }
}
