using System;
using System.Collections;
using System.Collections.Generic;

namespace BalancedBracketSequence.Stack
{
    public class StackEnumerator<T> : IEnumerator<T>
    {
        private readonly T[] _elements;
        private int _position = -1;
        private readonly int _length;
        
        public StackEnumerator(T[] elements, int length)
        {
            _elements = elements;
            _length = length;
        }
        
        public bool MoveNext()
        {
            if (_position >= _length - 1)
            {
                return false;
            }
            _position++;
            return true;
        }

        public void Reset()
        {
            _position = -1;
        }

        public T Current 
        {
            get
            {
                if (_position == -1 || _position >= _length)
                {
                    throw new InvalidOperationException("Текущий индекс вышел за границы массива");
                }
                return _elements[_position];
            }
        }

        object IEnumerator.Current => Current;

        public void Dispose()
        {
            
        }
    }
}