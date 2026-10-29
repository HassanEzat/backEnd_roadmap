using System;
using System.Collections.Generic;
using System.Text;

namespace weak1;


internal interface IRepository<T>where T : IEntity
{
    void Add(T item);
    bool Delete(int id);
    IEnumerable<T> GetAll();
    T? GetById(int id);
}

internal class Repository<T> : IRepository<T> where T : IEntity
{

    List<T> values = new List<T>();
    public bool Delete(int id)  {
    var item = GetById(id);
        if (item != null) { values.Remove(item);return true; }
        return false;
    }
    public bool Update(T item)
    {
        for (int i = 0; i < values.Count; i++)
        {
            if (values[i].Id == item.Id)
            {
                values[i] = item;
                return true;
            }
        }
        return false; 
    }
    public void Add(T item) { values.Add(item); }
     public IEnumerable<T> GetAll() { return values; }
    public T? GetById(int id) {
        foreach (var item in values)
        {
            if (item.Id == id) return item;
        }
        return default;
    }
}
