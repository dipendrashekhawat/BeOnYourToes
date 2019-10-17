using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexOfClosingBrace
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string with opening and closing braces: For example a string like this" + " " + "\"{{${computedvalue}}}\"");
            string input = Console.ReadLine();

            Console.WriteLine("Enter the index position of the opening brace for which you want to find its closing brace: ");
            int indexPosition = Convert.ToInt32(Console.ReadLine());

            IndexOfClosingBrace(input, indexPosition); // IndexOfClosingBrace("{{${computedvalue}}}", 0)

            Console.ReadKey();
        }

        private static void IndexOfClosingBrace(string userInput, int index)
        {
            if (userInput[index] != '{')
            {
                Console.Write(userInput + ", " + index + ": -1\n");
                return;
            }

            Stack stack = new Stack();

            for (int i = index; i < userInput.Length; i++)
            {
                if (userInput[i] == '{') 
                {
                    stack.Push(Convert.ToInt32(userInput[i]));
                }
                else if (userInput[i] == '}') 
                {
                    stack.Pop();
                    if (stack.Count == 0)
                    {
                        Console.Write(userInput + ", " + index + ": " +i + "\n");
                        return;
                    }
                }
            }

            Console.Write(userInput + ", " + index + ": -1\n");
        }
    }
}
