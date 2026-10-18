using System;
using System.Collections.Generic;
using System.Text;

using Recap.Library;

namespace Week01.Library;

internal class Book: LibraryItem
{
    
        
        public decimal Price { get; private set; }

        public Book(string title, decimal price):base(title)
        {
            
            if (price < 0) throw new ArgumentOutOfRangeException(nameof(price), "cannot be negative");
            
            this.Price = price;
        }
    public override int GetLoanDays() => 14;
}
