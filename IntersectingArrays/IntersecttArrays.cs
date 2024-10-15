using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntersectingArrays
{
    public  class IntersecttArrays
    {
        public static void Main(string[] args)
        {
            int[][] nums = new int[] [] {
                new int[] {3,1,2,4,5},
                new int[] {1,2,3,4 },
                new int[] {3,4,5,6 }
            };

            IList<int> CommonElements = IntersecttArrays.Intersection(nums);
            foreach (int element in CommonElements)
            {
                Console.WriteLine(element);
            }

            
        }
          public static IList<int> Intersection(int [] [] nums)
        {
            HashSet<int> CommonElements = new HashSet<int>(nums[0]);

            for (int i = 1; i < nums.Length; i++)
            {
                HashSet<int> CurrentElement = new HashSet<int>(nums[i]);
            CommonElements.IntersectWith(CurrentElement);
            }
            List<int> result = new List<int>(CommonElements);
            result.Sort();
            return result;
        }
       
    }   
}
