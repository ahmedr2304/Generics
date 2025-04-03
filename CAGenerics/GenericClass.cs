using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAGenerics
{
    internal class GenericClass<T>
    {
        private T[] _items;

        public void Add(T item) 
        {
            if (_items is null)
            {
                _items = new T[] { item };
            }
            else 
            {
                var length = _items.Length;
                var dest = new T[length + 1];
                for (int i = 0; i < length; i++) 
                {
                    dest[i] = _items[i];
                }
                dest[dest.Length-1]= item;

                _items = dest;

                        
            }
        }
        public void RemoveAt(int position) 
        {
            if (position < 0 || position > _items.Length - 1) 
            return;
            var index = 0;
            var dest  = new T[_items.Length - 1];
            for (int i = 0; i < _items.Length; i++) 
            {
                if (position == i)
                    continue;
                dest[index++] = _items[i];
            }
            _items = dest;
        }

        public bool IsEmpty =>_items is null || _items.Length == 0;

        public int Count => _items is null ? 0: _items.Length;

        public void DisplayList() 
        {
            Console.Write("[");
            for (int i = 0; i < _items.Length; i++)
            {
                Console.Write(_items[i]);
                if (i < _items.Length - 1)
                {
                    Console.Write(',');
                }

            }
            Console.Write("]");
        }

    }
}
