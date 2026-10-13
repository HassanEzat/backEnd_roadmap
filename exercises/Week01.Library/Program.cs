using Recap.Library;
using Week01.Library;
//book
var book = new Book("C# Basics", 100);
Console.WriteLine(book.Title);
Console.WriteLine(book.Price);

// test if null exprtion is space 
try { var bad = new Book("   ", 10); }
catch (ArgumentException ex) { Console.WriteLine(ex.Message); }
// test price if accept negative numders
try { var bad = new Book("C#", -5); }
catch (ArgumentException ex) { Console.WriteLine(ex.Message); }
//book
Console.WriteLine("=============================");
//member 

var member = new Member(1,"hassan");
Console.WriteLine(member.Name);
Console.WriteLine(member.Id);
// test if null exprtion is name 
try { var bad = new Member(10,"   "); }
catch (ArgumentException ex) { Console.WriteLine(ex.Message); }
// test price if accept negative numders
try { var bad = new Member(0,"Hassan"); }
catch (ArgumentException ex) { Console.WriteLine(ex.Message); }

