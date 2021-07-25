using System;
using System.Collections.Generic;

namespace BalancedBrackets
{
    class Program
    {
        public static string IsBalanced(string s)
        {
            Stack<char> stack = new Stack<char>();
            foreach (char c in s)
            {
                if (c == '(' || c == '{' || c == '[')
                {
                    stack.Push(c);
                }
                else
                {
                    if (stack.Count == 0)
                    { return "NO"; }
                    else
                    {
                        char popVal = stack.Pop();
                        if (c == ')' && popVal != '(')
                            return "NO";
                        else if (c == ']' && popVal != '[')
                            return "NO";
                        else if (c == '}' && popVal != '{')
                            return "NO";


                    }
                }


            }
            if (stack.Count == 0)
                return "YES";
            else
                return "NO";

        }
        static void Main(string[] args)
        {
            string exp = "{()}[]";
            Console.WriteLine(IsBalanced(exp));

        }
    }
}
