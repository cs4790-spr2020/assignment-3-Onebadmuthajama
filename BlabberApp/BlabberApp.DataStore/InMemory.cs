using System;
using System.Collections;
using BlabberApp.Domain;

namespace BlabberApp.DataStore
{
    public class InMemory : IDataStore
    {
        private ArrayList _items = new ArrayList();
        public bool Create(IDatum datum)
        {
            var idx = this._items.Add(datum);
            if (idx < 0)
            {
                throw new ArgumentOutOfRangeException("Can't contain negitive objects");
            }
            return true;
        }
        public IDatum Read(int idx)
        {
            return this._items[idx];
        }
        public bool Update(IDatum datum)
        {
            return true;
        }
        public bool Delete(int idx)
        {
            try
            {
                this._items.RemoveAt(idx);

            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.Message());
                throw e;
            }
            return true;
        }

    }
}