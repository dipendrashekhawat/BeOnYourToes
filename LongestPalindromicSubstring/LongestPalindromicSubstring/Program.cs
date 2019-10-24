using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestPalindromicSubstring
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "hellosannasmith";
            LongestPalindromicSubstring(str);
            Console.ReadLine();
        }

        public static void PrintPalindromicSubString(string str, int low, int high)
        {
            if (str.Substring(low, (high + 1) - low).Length > 2)
                Console.WriteLine(str.Substring(low, (high + 1) - low));
            else
                Console.WriteLine("none");
        }

        public static void LongestPalindromicSubstring(string str)
        {
            int maxLength = 1; 

            int start = 0;
            int len = str.Length;

            int low, high;

            for (int i = 1; i < len; ++i)
            {

                low = i - 1;
                high = i;
                while (low >= 0 && high < len &&
                    str[low] == str[high])
                {
                    if (high - low + 1 > maxLength)
                    {
                        start = low;
                        maxLength = high - low + 1;
                    }
                    --low;
                    ++high;
                }

 
                low = i - 1;
                high = i + 1;
                while (low >= 0 && high < len &&
                    str[low] == str[high])
                {
                    if (high - low + 1 > maxLength)
                    {
                        start = low;
                        maxLength = high - low + 1;
                    }
                    --low;
                    ++high;
                }
            }

            PrintPalindromicSubString(str, start, start + maxLength - 1);
        }
    }
}
