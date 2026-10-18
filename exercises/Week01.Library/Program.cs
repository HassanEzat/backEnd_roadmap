//using Recap.Library;

//using Week01.Library;
////book
//var book = new Book("C# Basics", 100);
//Console.WriteLine(book.BookTitle);
//Console.WriteLine(book.Price);

//// test if null exprtion is space 
//try { var bad = new Book("   ", 10); }
//catch (ArgumentException ex) { Console.WriteLine(ex.Message); }
//// test price if accept negative numders
//try { var bad = new Book("C#", -5); }
//catch (ArgumentException ex) { Console.WriteLine(ex.Message); }
////book
//Console.WriteLine("=============================");
////member 

//var member = new Member(1, "hassan");
//Console.WriteLine(member.Name);
//Console.WriteLine(member.Id);
//// test if null exprtion is name 
//try { var bad = new Member(10, "   "); }
//catch (ArgumentException ex) { Console.WriteLine(ex.Message); }
//// test price if accept negative numders
//try { var bad = new Member(0, "Hassan"); }
//catch (ArgumentException ex) { Console.WriteLine(ex.Message); }

using Recap.Library;

using Week01.Library;

List<LibraryItem> list = new List<LibraryItem>();
list.Add(new Book("brocken haert",200));
list.Add(new Dvd("ss rank"));
list.Add(new Dvd("f rank"));
foreach (var item in list)
{
    Console.WriteLine(item.BookTitle);
}