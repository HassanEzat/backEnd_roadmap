using System;
using System.Collections.Generic;
using System.Text;

namespace weak1;

internal interface IEntity
{
    static int static_id { get; }
    int Id { get; }
}
