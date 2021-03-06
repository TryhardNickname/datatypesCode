using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ds;

/// <summary>
/// Data Type Stack implemented by Data Structure Array
/// </summary>
namespace dtstack_dsarr
{
    class Stack<T>
    {
        private Array<T> arr;
        int top;
        public Stack(int maxSize)
        {
            arr = new ds.Array<T>(maxSize);
            top = 0;
        }
        public void Push(T val)
        {
            arr.Set(top, val);
            top++;
        }
        public T Pop()
        {
            top--;
            return arr.Get(top);
        }
        public int Length()
        {
            return top;
        }
        public bool isFull()
        {         
            return top == arr.Length() ? true : false;
                
        }
        public bool isEmpty()
        {
            return top == 0 ? true : false;
        }
        /*
        public override string ToString()
        {
            string res = "{";
            bool first = true;
            for (int ix = Length() - 1; ix >= 0; ix--)
            {
                if (first)
                    first = false;
                else
                    res += ", ";
                res += $"{arr.Get(ix)}";
            }
            res += "}";
            return res;
        }
        */
    }
}
