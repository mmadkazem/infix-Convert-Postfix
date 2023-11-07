using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace infix
{
  
    public class MyStack<Type>
    {
        private Type[] values;
        public int Count = 0;


        public MyStack()
        {
            values = new Type[10];
        }

        public void Push(Type value)
        {

            if (IsFull())
            {


                values = Expansion();
            }

            values[++Count] = value;
        }
        public Type Pop()
        {
            if (IsEmpty())
            {
                throw new IndexOutOfRangeException();
            }
            return values[Count--];
        }

        public bool IsFull()
        {
            return Count == values.Length - 1;
        }
        public bool IsEmpty()
        {
            return Count == 0;
        }

        public Type Peek()
        {
            return values[Count];
        }

        private Type[] Expansion()
        {
            var result = new Type[Count * 2];

            for (int i = 0; i < values.Length; i++)
            {
                result[i] = values[i];
            }
            return result;
        }

    }
}
