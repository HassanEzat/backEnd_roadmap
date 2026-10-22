using System;
using System.Collections.Generic;
using System.Text;

namespace weak1;

internal class Box<T>
{
    public T Value;
    public Box(T value)
    {
        Value = value;
    }
}
