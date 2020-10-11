using System;

namespace BalancedBracketSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            var elements = Console.ReadLine();
            var amount = elements?.Length ?? 0;
            
            Stack<char> stack = new Stack<char>(amount);
            Check(elements, stack);
        }


        private static void Check(string elements, Stack<char> stack)
        {
            foreach (var item in elements)
            {
                if ((item == ')' || item == '}' || item == ']') && stack.Empty)
                {
                    Console.WriteLine("No");
                    return;
                }
                
                if (item == '(' || item == '[' || item == '{')
                {
                    stack.Push(item);
                    continue;
                }

                if (item == ')' && stack.Top == '(')
                {
                    stack.Pop(); 
                    continue;
                }
                
                if (item == ')' && stack.Top != '(') { 
                    Console.WriteLine("No");
                    return;
                }

                if (item == ']' && stack.Top == '[')
                {
                    stack.Pop();
                    continue;
                }
                
                if (item == ']' && stack.Top != '[') 
                { 
                    Console.WriteLine("No");
                    return;
                }

                if (item == '}' && stack.Top == '{')
                {
                    stack.Pop();
                    continue;
                }
                
                if (item == '}' && stack.Top != '{') 
                { 
                    Console.WriteLine("No");
                    return;
                }
            }
            
            Console.WriteLine(stack.Empty ? "Yes" : "No");
        }
    }
}