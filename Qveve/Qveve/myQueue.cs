using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    public class myQueue<Type>
    {
        private Type[] _values;
        private int front = 0;
        private int rear = 0;

        public myQueue()
        {
            _values = new Type[5];
        }


        public void enQueue(Type value)
        {
            if (isFull())
            {
                _values = Expansion();
            }
            _values[rear++] = value;
        }

        public Type deQueue()
        {
            if(isEmty())
            {
                throw new IndexOutOfRangeException();
            }
            return _values[front++];
        }
        public Type Peek()
        {
            return _values[front];
        }
        private bool isEmty()
        {
            return front == rear;
        }
        private bool isFull()
        {
           return rear == _values.Length - 1;
        }
        private Type[] Expansion()
        {
            var result = new Type[rear * 2];

            for (int i = 0; i < _values.Length; i++)
            {
                result[i] = _values[i];
            }
            return result;
        }
    }
}
