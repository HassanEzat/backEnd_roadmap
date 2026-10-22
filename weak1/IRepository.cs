using System;
using System.Collections.Generic;
using System.Text;

namespace weak1;


public interface IRepository<T>
{
    void Add(T item);
    IEnumerable<T> GetAll();
}

//internal class Repository<T> : IRepository() { 

//    List<T> values = new List<T>();
//    public void Add(T item) { }
//    IEnumerable<T> GetAll() { return values; }
//}
