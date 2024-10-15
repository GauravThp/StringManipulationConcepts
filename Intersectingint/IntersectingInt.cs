using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intersectingint
{
    public class IntersectingInt
    {
        static void Main(string[] args)
        {
            int[] nums1 = { 1, 3, 4, 1, 2 };
            int[] nums2 = { 1,2,2 } ;


            int[] result = Intersection(nums1, nums2);
            Console.WriteLine("Intersection of the nums : ");

            for (int i = 0; i < result.Length; i++ )
            {
                Console.WriteLine(result[i] + " ");
            }

        }

        public static int[] Intersection(int[] nums1, int[] nums2)
        {

            List<int> intersectionList = new List<int>();

            int num1Length = nums1.Length;
            int num2Lenght = nums2.Length;

            for (int i = 0; i < num1Length; i++)
            {
                int num1 = nums1[i];

                for (int j = 0; j < num2Lenght; j++)
                {
                    int num2 = nums2[j];
                    if (num1 == num2)
                    {
                        if (!intersectionList.Contains(num1))
                        {
                            intersectionList.Add(num1);
                        }
                        break;
                    }
                   
                }
            }
            return intersectionList.ToArray();
        }



    }
}
