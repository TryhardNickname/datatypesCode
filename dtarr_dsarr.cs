using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ds;

/// <summary>
/// Data Type Array implemented by Data Structure Array
/// </summary>
namespace dtarr_dssll
{
    public class Array<T>
    {
        private ds.Array<T> arr;
        //==== Constructors ====
        /// <summary>
        /// Constructor that allocates an array of elements with the
        /// </summary>
        /// <param name="size">desired size</param>
        /// <exception cref="ArgumentOutOfRangeException">if size ≤ 0</exception>
        public Array(int size)
        {
            if (size < 1) throw new ArgumentOutOfRangeException("size must be greater than 0");
            arr = new ds.Array<T>(size);
        }
        public Array(T[] rawArray)
        {
            arr = new ds.Array<T>(rawArray.Length);
            for (int ix = 0; ix < rawArray.Length; ix++)
            {
                arr.Set(ix, rawArray[ix]);
            }
        }
        /// <summary>
        /// Change element at a certain index to a new value
        /// </summary>
        /// <param name="ix">the index</param>
        /// <param name="val">the new value</param>
        /// <exception cref="IndexOutOfRangeException">if index &lt; 0 or Length() ≤ index</exception>
        public void Set(int ix, T val)
        {
            if (ix < 0)
                throw new IndexOutOfRangeException("index must be within range 0 to Length()");
            if (Length() <= ix)
                throw new IndexOutOfRangeException("index must be within range 0 to Length()");
            arr.Set(ix, val);
        }
        // Access:
        /// <summary>
        /// Access element at certain index
        /// </summary>
        /// <param name="ix">the index</param>
        /// <returns>the element at a certain index in the array</returns>
        /// <exception cref="IndexOutOfRangeException">if index &lt; 0 or Length() ≤ index</exception>
        public T Get(int ix)
        {
            if (ix < 0)
                throw new IndexOutOfRangeException("index must be within range 0 to Length()");
            if (Length() <= ix)
                throw new IndexOutOfRangeException("index must be within range 0 to Length()");
            return arr.Get(ix);
        }
        /// <summary>
        /// Get the length of the Array
        /// </summary>
        /// <returns>the length</returns>
        public int Length()
        {
            return arr.Length();
        }
        public T this[int ix]
        {
            get => Get(ix);
            set => Set(ix, value);
        }
        public override string ToString()
        {
            string res = "{";
            bool first = true;
            for (int ix = 0; ix < Length(); ix++)
            {
                if (first)
                    first = false;
                else
                    res += ", ";
                res += $"{Get(ix)}";
            }
            res += "}";
            return res;
        }
    }
}
