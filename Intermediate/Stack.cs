using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intermediate
{
    internal class Stack
    {
        private readonly ArrayList _stack = new ArrayList();
        public void Push(object obj)
        {
            if (obj == null)
                throw new InvalidOperationException("Null cannot be added to the stack.");

            _stack.Add(obj);
        }
        public object Pop()
        {
            if (_stack.Count == 0)
                throw new InvalidOperationException("Cannot pop from an empty stack.");
            var count = _stack.Count-1;
            var current = _stack[count];
            _stack.RemoveAt(count);
            return current;
        }
        public void Clear()
        {
            _stack.Clear();
        }
    }
}
