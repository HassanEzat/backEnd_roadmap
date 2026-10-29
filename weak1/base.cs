using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace weak1;

abstract class LibraryItem: IBorrowable , IEntity
{
    public static int static_id = 1;
    public string Title {get;  }
    public bool IsBorrowed { get; private set; }
    public int Id { get; }
    protected LibraryItem(string title,int id)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(title);
        Title = title;
        if (id <= 0)
            throw new ArgumentOutOfRangeException(nameof(id), "ID must be positive.");
        Id = id;
        static_id++;
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