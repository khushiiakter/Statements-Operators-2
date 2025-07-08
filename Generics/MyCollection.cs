using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
   
    internal class MyCollection<T>
    {
        private List<T> _items = new List<T>();
        //public List<T> _items = new List<T>();
        public void AddItem(T item)
        {
            _items.Add(item);
        }

        // Generic Method with Constraints
        public K GetItems<K>() where K : ICollection<T>, new()
        {
            var items = new K();
            foreach (var item in _items)
            {
                items.Add(item);
            }
            return items;
        }
    }
}
