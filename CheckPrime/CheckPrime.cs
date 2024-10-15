using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckPrime
{
     class CheckPrime
    {
        public static void Main(string [] args)
        {
            Console.WriteLine("Please check if the number is prime or not");
            int num = int.Parse(Console.ReadLine());
            
            if (IsPrimeNum(num))
            {
                Console.WriteLine("Its a prime number");

            }
            else
            {
                Console.WriteLine("Its not a prime numer");
            }
        }

        public static bool IsPrimeNum(int num)
        {
            if (num < 2 )
            {
                return false; 
            }
            for (int i = 2; i <= Math.Sqrt(num); i ++)
            {
                if (num % i == 0 )
                {
                    return false;
                }
               
            }
            return true;

        }

    }
}
