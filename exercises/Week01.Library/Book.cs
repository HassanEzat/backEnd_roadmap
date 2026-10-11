using System;
using System.Collections.Generic;
using System.Text;

namespace Week01.Library;

internal class Book
{
    
        public string Title { get; private set; }
        public decimal Price { get; private set; }

        public Book(string title, decimal price)
        {
            if (string.IsNullOrWhiteSpace(title)) throw new ArgumentException(message:nameof(title));
            if (price < 0) throw new ArgumentOutOfRangeException(nameof(price)+"cannot be negative");
            this.Title = title.Trim();
            this.Price = price;
        }
    
}
