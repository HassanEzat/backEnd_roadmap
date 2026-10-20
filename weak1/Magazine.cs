using System;
using System.Collections.Generic;
using System.Text;

namespace weak1;

internal class Magazine:LibraryItem
{
    public int Issue { get;}
    public Magazine(string title,int issue):base(title)
    {
        if (issue <= 0)
            throw new ArgumentOutOfRangeException(nameof(issue), "Issue must be positive.");
        Issue = issue;
    }
    public override int LoanDays => 5;
    public override string Describe() => $"{Title} {Issue}";
}
