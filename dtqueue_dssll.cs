using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ds;

/// <summary>
/// Data Type Stack implemented by Data Structure Array
/// </summary>
namespace dtqueue_dssll.cs
{
    class Queue<T>
    {
        private SLList<T> sllist;
        public int top, size;

        public Queue(int maxSize)
        {
            //sllist = new ds.SLList<T>();
            sllist = null;
            top = 0;
            size = maxSize;
        }
        public void Enqueue(T val)
        {
            //Console.WriteLine($"({val}) [{sllist.GetVal()}]");
            sllist = new SLList<T>(val, sllist);
            top++;
        }
        public T Dequeue()
        {
            SLList<T> temp = sllist;
            T returnValue;
            while (temp.GetNext().GetNext() != null)
            {     
                //case where only one left do something
                temp = temp.GetNext();
            }
            top--;
            returnValue = temp.GetNext().GetVal();

            temp.SetNext(null);
            return returnValue;
        }
        public T Peek()
        {
            T returnValue = default;
            SLList<T> temp = sllist;
            for (int i = 0; i < top; i++)
            {
                temp = temp.GetNext();
                returnValue = temp.GetVal();
            }
            return returnValue;
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
