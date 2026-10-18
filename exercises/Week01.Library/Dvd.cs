using System;
using System.Collections.Generic;
using System.Text;

namespace Recap.Library;

internal class Dvd : LibraryItem
{
    public  Dvd(string title) : base(title)
    {

    }
    public override int GetLoanDays() => 3;
}