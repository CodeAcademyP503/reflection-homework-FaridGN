using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cardsystem.Models;

namespace Cardsystem.Core
{
    public class InMemoryDBset<T>:IDBset<T> where T:Entity
    {
        private static List<T> _items;

        static InMemoryDBset()
        {
            _items = new List<T>();
        }

        public T Add(T item)
        {
            if (Exists(item) != null)
                throw new EntityExistException("Entity already exists");
            _items.Add(item);
            return item;
        }

        public T Exists(Func<T, bool> predicate)
        {
            T newitem = null;
            foreach (T _item in _items)
            {
                if (predicate(_item))
                {
                    newitem = _item;
                }
            }
            return newitem;
        }

        public T Exists (T item)
        {
            T newitem = null;
            foreach(T _item in _items)
            {
                if (_item.Equals(item))
                {
                    newitem = _item;
                }
            }
            return newitem;
        }

        public void Remove(T item)
        {
            _items.Remove(item);
        }

        public void Update(T item)
        {
            var existeditem = Exists(item);
            if(existeditem == null)
            {
                throw new EntityNotExisted("Entity is not existed for Update");
            }
        }

        public T GetById(int id)
        {
            T item = null;
            foreach(T _item in _items)
            {
                 if(_item.Id == id)
                {
                    item = _item;
                }
            }
            return item;
        }

        public IEnumerable<T> GetAll()
        {
            return _items;
        }

    }
}
