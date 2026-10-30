using System;
using System.Collections.Generic;
using System.Text;

namespace weak1;


internal interface IRepository<T>where T : IEntity
{
    
    void Add(T item);
    bool Delete(int id);
    bool Update(T item);
    IEnumerable<T> GetAll();
    T? GetById(int id);
}
