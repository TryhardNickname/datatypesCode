using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ds;

/// <summary>
/// Data Type Stack implemented by Data Structure Array
/// </summary>
namespace dtstack_dsll
{
    class Stack<T>
    {

        private SLList<T> sllist;
        int top, size;

        public Stack(int maxSize)
        {
            sllist = new ds.SLList<T>(maxSize);
            top = 0;
            size = maxSize;
        }
        public void Push(T val)
        {
            sllist = new SLList<T>(val, sllist);
            top++;
        }
        public T Pop()
        {
            T popElement = sllist.GetVal();
            sllist = sllist.GetNext();
            top--;
            return popElement;
        }
        public int Length()
        {
            return top;
        }
        public bool isFull()
        {
            return top == size;
                
        }
        public bool isEmpty()
        {
            return top == 0;
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
