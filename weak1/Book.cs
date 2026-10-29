using System;
using System.Collections.Generic;
using System.Text;

namespace weak1;

internal class Book:LibraryItem
{
    
    public string Author { get; }
    public int Pages { get;  }
    
    public Book(string title, string author, int pages,int id):base(title,id)
    {
        
        ArgumentException.ThrowIfNullOrWhiteSpace(author);
        if (pages <= 0)
            throw new ArgumentOutOfRangeException(nameof(pages), "Pages must be positive.");

        
        Pages = pages;
        Author = author;
    }

    public override string Describe() => $"{Title} {Author}";
}
