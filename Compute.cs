using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace infix
{
    public static class Compute
    {
    public static int CalculatePostfix(string expression)
    {
        Stack<int> stack = new Stack<int>();

        foreach (char c in expression)
        {
            if (Char.IsLetter(c))
            {
                Console.Write($"{c}: ");
                stack.Push(Convert.ToInt32(Console.ReadLine()));
            }
            else if (IsOperator(c))
            {
                int operand2 = stack.Pop();
                int operand1 = stack.Pop();
                int result = PerformOperation(operand1, operand2, c);
                stack.Push(result);
            }
        }

        return stack.Pop();
    }

    static bool IsOperator(char c)
    {
        return c == '+' || c == '-' || c == '*' || c == '/';
    }

    static int PerformOperation(int operand1, int operand2, char op)
    {
        switch (op)
        {
            case '+':
                return operand1 + operand2;
            case '-':
                return operand1 - operand2;
            case '*':
                return operand1 * operand2;
            case '/':
                return operand1 / operand2;
            default:
                throw new ArgumentException("Invalid operator");
        }
    }
    }
}