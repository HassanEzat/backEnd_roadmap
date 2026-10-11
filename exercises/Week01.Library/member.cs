using System;
using System.Collections.Generic;
using System.Text;

namespace Recap.Library;

internal class member
{
    public int Id { get; private set; }
    public string Name { get; private set; }
    public member(int id,string name )
    {
        if (id < 1) throw new ArgumentOutOfRangeException(nameof(Name),"can not be below 1");
        if (string.IsNullOrWhiteSpace(name)) throw new ArgumentException(nameof(Id),"can not be space or empty");
        this.Id = id;
        this.Name = name.Trim();
    }

}
