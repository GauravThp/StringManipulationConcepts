using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindEvenDigits
{
     public class FIndEvenNumDigits
    {
         static void Main(string [] args)
        {
            int[] nums = { 12, 2, 6, 55, 789, 896523 };

            Console.WriteLine(FindEvenDigits(nums));
           
        }
         public static int  FindEvenDigits (int [] nums)
        {
            int Length = nums.Length;
            int count = 0;

            for (int i = 0; i < Length; i++)
            {
                if (CountDigits(nums[i]) % 2 == 0)
                    count++;
            }
            return count;

        }

        public static int CountDigits(int num)
        {
            int count = 0;

            while (num != 0 )
            {
                num /= 10;
                count++;
            }
            return count;
        }






    }
}
