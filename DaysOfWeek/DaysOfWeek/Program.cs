using System;

namespace DaysOfWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input values
            Console.WriteLine("Enter the input values as per read me file: ");
            string S = Console.ReadLine();
            int K = Convert.ToInt16(Console.ReadLine());

            Console.Write("The day of week that is {0} days later from {1} is : ", K, S);
            Console.WriteLine(dayOfWeek(S,K));
            Console.ReadKey();
        }

        public static string dayOfWeek(string S, int K)
        {
            int i = 0;
            int total = 0;
            int day;

            string[] dayOfWeek = new string[7] { "Mon", "Tue", "Wed", "Thu", "Fri", "Sat", "Sun" };

            for (int j = 0; j < dayOfWeek.Length; j++)
            {
                if (dayOfWeek[j] == S)
                {
                    i = j;
                    break;
                }
            }

            total = i + K;

            day = total % 7; // To get the remaining days from a week

            return dayOfWeek[day];
        }
    }
}
