using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using infix;

namespace infix
{
    public static class ConvetInfix
    {
        private static int Precedence(char op)
        {
            switch (op)
            {
                case '+':
                case '-':
                    return 1;
                case '*':
                case '/':
                    return 2;
                default:
                    return -1;
            }
        }

        public static string ConvertToPostfix(string txt)
        {
            if (!Expertion.isBallance(txt))
            {
                return "string Not banlance";
            }
            string postfix = "";
            MyStack<char> myStack = new MyStack<char>();

            for (int i = 0; i < txt.Length; i++)
            {
                char c = txt[i];
                if (c == ' ')
                {
                    continue;
                }
                if (char.IsLetterOrDigit(c))
                {
                    postfix += c;
                }
                else if (c == '(')
                {
                    myStack.Push(c);
                }
                else if (c == ')')
                {
                    while (myStack.Count > 0 && myStack.Peek() != '(')
                    {
                        postfix += myStack.Pop();
                    }
                    
                    myStack.Pop();
                }
                else
                {
                    while (myStack.Count > 0 && Precedence(c) <= Precedence(myStack.Peek()))
                    {
                        postfix += myStack.Pop();                      
                    }
                    myStack.Push(c);
                }

            }
            while (!myStack.IsEmpty())
            {
                postfix += myStack.Pop();
            }
            return postfix;
        }
    }
}