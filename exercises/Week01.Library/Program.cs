using Week01.Library;

var book = new Book("C# Basics", 100);
Console.WriteLine(book.Title);
Console.WriteLine(book.Price);
try { var bad = new Book("   ", 10); }
catch (ArgumentException ex) { Console.WriteLine(ex.Message); }

try { var bad = new Book("C#", -5); }
catch (ArgumentException ex) { Console.WriteLine(ex.Message); }