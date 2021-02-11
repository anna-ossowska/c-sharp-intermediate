using System;
using System.Collections.Generic;

namespace Exercise1
{
    public class Stack
    {
        private readonly List<object> list = new List<object>();

        public void Push(object obj)
        {
            if (obj != null)
            {
                list.Add(obj);
            }
            else
            {
                throw new InvalidOperationException("Null objects are not accepted.");
            }
        }

        public object Pop()
        {
            if (list.Count > 0)
            {
                var popped = list[list.Count - 1];
                list.RemoveAt(list.Count - 1);
                return popped;
            }
            else
            {
                throw new InvalidOperationException("Operation cannot be performed on an empty list.");
            }
        }

        public void Clear()
        {
            if (list.Count > 0)
            {
                list.Clear();
            }
            else
            {
                throw new InvalidOperationException("Operation cannot be performed on an empty list.");
            }
        }
    }
}
