using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace strings
{
     class stringsManipulation
    {
        static void Main(string [] args)
        {
            //while (true)
           //// {
                Console.WriteLine("Enter the String you want to check palindrome: ");
                string input = Console.ReadLine();
                //if (input == "N")
                //    break;
                CheckPalindrome(input);
           /// }
            
            //string reversedString = ReverseWordOrder(input);
           // Console.WriteLine("The Reversed String is : " + reversedString);

        }

        public static string ReverseString (string str)
        {
            char[] charArray = str.ToCharArray();
            int Length = charArray.Length;

            char[] reverseArray = new char[Length];

            for (int i = 0; i < Length; i ++)
            {
                reverseArray[i] = charArray[Length - 1 - i];
            }

            return new string( reverseArray);



        }


        public static string ReverseWordOrder (string st)
        {
            string[] word = st.Split(' ');
            string reversedString = " ";
            int Length = word.Length;


            for ( int i = Length - 1; i >= 0; i --)
            {
                reversedString += word[i] + " ";
            }

            return new string (reversedString).Trim();
        }

        //public static void 1CheckPalindrome (string input)
        //{
        //    int Length = input.Length;

        //    //string reverseString = "";
        //    StringBuilder reverseString = new StringBuilder();

        //    for (int i = Length - 1; i >= 0 ; i-- )
        //        {
        //        // reverseString += input[i].ToString();
        //        //reverseString.Append(input[i]);
        //        reverseString.Append(input[i]);
                
        //        }
        //    if (reverseString.ToString() == input)
        //    {
        //        Console.WriteLine("It is Palindrome");
        //    }

        //   else
        //    {
        //        Console.WriteLine("It is not Palindrome");
        //    }
        //}

        public static void CheckPalindrome (string input)
        {
            int Length = input.Length;

            StringBuilder reverseString = new StringBuilder();

            for (int i = Length -1; i >= 0; i --)
            {
                reverseString.Append(input[i]);
            }

            if (reverseString.ToString() == input)
            {
                Console.WriteLine("It is a Palindrome");
            }
            else
            {
                Console.WriteLine("It is not a Palindrome");
            }

        }

       
    }

}
