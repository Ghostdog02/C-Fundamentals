using System;

namespace CheckBrackets
{
    public class Program
    {
        static void Main()
        {
            string expression = "((a+b)/5-d)";
            CheckExpression(expression);
        }

        static bool CheckExpression(string expression)
        {
            int counter = 0;
            for (int i = 0; i < expression.Length; i++)
            {
                if (expression[i] == '(')
                {
                    counter++;
                }

                if (expression[i] == ')')
                {
                    counter--;
                }
            }

            return counter == 0 ? true : false;
        }
    }
}
