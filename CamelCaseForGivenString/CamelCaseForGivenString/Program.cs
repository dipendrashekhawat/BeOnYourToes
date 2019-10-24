using System;
using System.Text.RegularExpressions;

namespace CamelCaseForGivenString
{
    class Program
    {
        static void Main(string[] args)
        {
            String str = "cats AND*Dogs-are Awesome";
            str = Regex.Replace(str, @"[^0-9a-zA-Z]+", " ");
            convert(str); // output: catsANDDogsAreAwesome
            Console.ReadKey();
        }

        static void convert(String str)
        {
            int cnt = 0;
            int n = str.Length;
            char[] ch = str.ToCharArray();
            int res_ind = 0;

            for (int i = 0; i < n; i++)
            {
                if (ch[i] == ' ')
                {
                    cnt++;

                    ch[i + 1] = char.ToUpper(ch[i + 1]);
                    continue;
                }
                else
                    ch[res_ind++] = ch[i];
            }

            ch[0] = char.ToLower(ch[0]);

            for (int i = 0; i < n - cnt; i++)
                Console.Write(ch[i]);
        }
    }
}
