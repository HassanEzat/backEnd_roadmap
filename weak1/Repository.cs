using System;
using System.Collections.Generic;
using System.Text;

namespace weak1;


internal class Repository<T> : IRepository<T> where T : IEntity
{
    public static int IdCounter = 0;

    Dictionary<int, T> _keyValues = new Dictionary<int, T>();
    public bool Delete(int id)
    {
        var item = GetById(id);
        if (item != null) { _keyValues.Remove(id); return true; }
        return false;
    }
    public bool Update(T item)
    {
        if (_keyValues.ContainsKey(item.Id))
        {
            _keyValues[item.Id] = item;
            return true;
        }
        return false;
    }
    public void Add(T item) { _keyValues[item.Id] = item    ; }
    public IEnumerable<T> GetAll() { return _keyValues.Values; }
    public T? GetById(int id)
    {
        if (_keyValues.TryGetValue(id, out T item))
        {
            return item;
        }
        return default ;
    }
    
}
