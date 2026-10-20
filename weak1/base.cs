using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace weak1;

public class @base
{
}

public class Inherit_child:@base { 

}


abstract class LibraryItem:IBorrowable
{
    public string Title {get;}
    public bool IsBorrowed { get; private set; }
    protected LibraryItem(string title)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(title);
        Title = title;
    }
    public virtual int LoanDays => 14;
    public void Borrow()
    {
        if (IsBorrowed) throw new InvalidOperationException("Item is already borrowed.");
        IsBorrowed = true;
    }
    public void Return()
    {
        if (!IsBorrowed) throw new InvalidOperationException("Item is already not borrowed.");
        IsBorrowed = false;
    }
    public abstract string Describe();
}