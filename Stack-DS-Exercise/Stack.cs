using System;
using System.Collections.Generic;

namespace Stack_DS_Exercise
{
    class Stack 
    {
        List<object> Ls = new List<object>();

        public void Push(object obj)
        {
            Ls.Add(obj);
        }

        public object Pop()
        {
            if (Ls.Count == 0)
            {
                throw new InvalidOperationException("The stack is empty.");
            }

            object removedObj = Ls[Ls.Count - 1];
            Ls.RemoveAt(Ls.Count - 1);

            return removedObj;
        }

        public void Clear()
        {
            Ls.Clear();
        }
    }
}
