using System;
using System.Collections.Generic;
using Cardsystem.Models;

namespace Cardsystem.Core
{
    public interface IDBset<T> where T :Entity
    {
        T Add(T item);
        T Exists(T item);
        IEnumerable<T> GetAll();
        T GetById(int item);
        void Remove(T item);
        void Update(T item);
        T Exists(Func<T, bool> predicate);
    }
}