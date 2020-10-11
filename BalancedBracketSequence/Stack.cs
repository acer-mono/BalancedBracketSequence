using System;

namespace BalancedBracketSequence
{
    public class Stack<T>
    {
        private readonly T[] _elements;
        private int _currentElement = -1;

        public T Top
        {
            get
            {
                if (_currentElement < 0)
                {
                    throw new InvalidOperationException("Вершина стека не инициализирована");
                }
                return _elements[_currentElement];
            }
        }
        
        public bool Empty => _currentElement < 0;

        public Stack(int n)
        {
            if (n < 0)
            {
                throw new ArgumentException("Количество элементов может быть только положительным числом!");
            }
            _elements = new T[n];
        }

        public bool Push(T newItem)
        {
            if (_currentElement >= _elements.Length)
            {
                return false;
            }
            _currentElement++;
            _elements[_currentElement] = newItem;
            return true;
        }

        public bool Pop()
        {
            if (_currentElement < 0)
            {
                return false;
            }
            _currentElement--;
            return true;
        }
    }
}