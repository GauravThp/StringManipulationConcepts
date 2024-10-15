using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Substring
{
     class substring
    {
        static void Main(string [] args)
        {
            Console.WriteLine("Please enter the main string: ");
            string mainstring = Console.ReadLine();

            Console.WriteLine("Please enter the Substring: ");
            string subString = Console.ReadLine();

            FindSubstring(mainstring, subString);

        }

        //public static void FindSubstring(string mainstring, string substring)
        //{
        //    int index = mainstring.IndexOf(substring);
        //    if (index != -1)
        //    {
        //        Console.WriteLine("Substring Found at " + index);

        //    }
        //    else
        //    {
        //        Console.WriteLine("Substring Not found");
        //    }
        //}

        //    public static void FindSubstring (string mainstring, string subString)
        //    {
        //        int mainStringLength = mainstring.Length;
        //        int subStringLength = subString.Length;

        //        for (int i = 0; i <= mainStringLength - subStringLength; i++)
        //        {
        //            bool match = true;
        //            for (int j = 0;  j < subStringLength ; j++)
        //                {
        //                if (mainstring[i+j] != subString[j])
        //                {
        //                    match = false;
        //                    break;
        //                }

        //            }
        //            if (match)
        //            {
        //                Console.WriteLine("Substring found at index " + i);
        //                return;
        //            }

      
    //        }
    //        Console.WriteLine("Substring not found");
    //    }
     public static void FindSubstring (string mainstring, string subString)
        {
            int mainStringLength = mainstring.Length;
            int subStringLength =  subString.Length;

            for (int i = 0; i <= mainStringLength - subStringLength; i ++)
            {
                bool flag = true;

                for (int j = 0; j < subStringLength; j++)
                {
                    if (mainstring[i+j] != subString[j])
                    {
                        flag = false;
                        break;
                        
                    }

                }
                if (flag)
                {
                    Console.WriteLine("Substring found at index " + i);
                    return;
                }

            }
            Console.WriteLine("Substring Not found");
        }
    }
}
