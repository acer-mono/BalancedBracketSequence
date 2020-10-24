using System;
using BalancedBracketSequence.Stack;

namespace BalancedBracketSequence
{
    static class Program
    {
        static void Main()
        {
            var elements = Console.ReadLine();
            var amount = elements?.Length ?? 0;
            
            Stack<char> stack = new Stack<char>(amount);
            Check(elements, stack);
        }

        private static void GetStackState(Stack<char> stack, int step)
        {
            Console.Write($"Step {step}: ");
            foreach (var el in stack)
            {
                Console.Write($"{el} ");
            }
            Console.WriteLine();
        }

        private static void Check(string elements, Stack<char> stack)
        {
            var step = 0;
            foreach (var item in elements)
            {
                step++;
                
                if ((item == ')' || item == '}' || item == ']') && stack.Empty)
                {
                    Console.WriteLine("No");
                    return;
                }
                
                switch (item)
                {
                    case '(':
                    case '[':
                    case '{':
                        stack.Push(item);
                        break;
                    case ')' when stack.Top == '(':
                        stack.Pop();
                        break;
                    case ')' when stack.Top != '(':
                        Console.WriteLine("No");
                        return;
                    case ']' when stack.Top == '[':
                        stack.Pop();
                        break;
                    case ']' when stack.Top != '[':
                        Console.WriteLine("No");
                        return;
                    case '}' when stack.Top == '{':
                        stack.Pop();
                        break;
                    case '}' when stack.Top != '{':
                        Console.WriteLine("No");
                        return;
                }
                GetStackState(stack, step);
            }
            
            Console.WriteLine(stack.Empty ? "Yes" : "No");
        }
    }
}