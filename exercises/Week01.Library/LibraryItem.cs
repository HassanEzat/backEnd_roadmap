using System;
using System.Collections.Generic;
using System.Text;

namespace Recap.Library;

abstract class LibraryItem
{
 public string BookTitle { get; private set; }
    protected LibraryItem(string title)
    {
        if (string.IsNullOrWhiteSpace(title)) {  throw new ArgumentException("title cannot be empty or white space",nameof(title)); } 
        this.BookTitle = title.Trim();
    }
    public abstract int GetLoanDays();
}
