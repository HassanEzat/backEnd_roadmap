using weak1;
#region DAY1
//int? n = null; //nullble num
//Nullable<int> n2 = null;






//var a = new Student(1, "Ali", 3.5);
//var b = new Student(1, "Ali", 3.5);
//var c = new Student1(1, "Ali", 3.5);
//var d = new Student1(1, "Ali", 3.5);
//Console.WriteLine(a == b);// True  (record يقارن القيم)
//Console.WriteLine(c == d);// لو كانت class عادية: False (تقارن المرجع، أي هل هما نفس الكائن في الذاكرة)

//var e = a with { Gpa = 3.9 }; // نسخة جديدة، و a لم تتغير
//Console.WriteLine(a);// Student { Id = 1, Name = Ali, Gpa = 3.5 }
//Console.WriteLine(e);// Student { Id = 1, Name = Ali, Gpa = 3.9 }
//public record Student(int Id, string Name, double Gpa);
//class Student1
//{
//    public int Id; public string Name; public double Gpa;

//    public Student1(int id, string name, double gpa)
//    {
//        Id = id;
//        Name = name;
//        Gpa = gpa;
//    }
//}
#endregion
#region DAY2


//int[] numbers = new int[1];

//// أ
//int first = numbers[0]; // O(1)

//// ب
//foreach (var n in numbers) //O(n)
//    Console.WriteLine(n);

//// ج
//foreach (var a in numbers)//n
//    foreach (var b in numbers)//n*n
//        Console.WriteLine(a + b);//O(n^2)

#endregion
#region DAY3

//Book normal_book = new Book("maintlist","hassan",120, 4);
//Book page_book = new Book("maintlist", "hassan", -120);//throw ArgumentOutOfRangeException
//Book title_book = new Book("", "hassan", 120); //throw ArgumentException
//Book Author_book = new Book("maintlist", "", 120);//throw ArgumentException



//Console.WriteLine(normal_book.IsBorrowed);//false
//normal_book.Borrow();

//Console.WriteLine(normal_book.IsBorrowed);//true
//try
//{
//    normal_book.Borrow();// throw InvalidOperationException
//}
//catch (InvalidOperationException e) { Console.WriteLine(e); } //Book is already borrowed.
//normal_book.Return();
//Console.WriteLine(normal_book.IsBorrowed);//false

//normal_book.IsBorrowed = true; red error by private set

//var info = new Book_info(normal_book.Title, normal_book.Author);
//Console.WriteLine(info);
//public record Book_info(string Title,string Author);

//var mem = new Member("hassan", "");
//List<LibraryItem> Items = new List<LibraryItem>();
//Items.Add(normal_book);
//Items.Add(new Magazine("ss rank", 1));
//foreach (var item in Items)
//{
//    Console.WriteLine(item.Describe()+" "+item.LoanDays);
//}
/*
 maintlist hassan 14
ss rank 1 5
 */
//IBorrowable x = normal_book;
//x.Borrow();
//Console.WriteLine(x.Author);   // true
#endregion
#region DAY4 

#endregion
#region DAY5
//var repo = new Repository<LibraryItem>();
//repo.Add(normal_book);
//repo.Add(new Magazine("ss rank", 1));

//foreach (var item in repo.GetAll())
//    Console.WriteLine(item.Describe());
//var repo = new Repository<LibraryItem>();
//repo.Add(new Book("maintlist", "hassan", 120, 1));
//repo.Add(new Magazine("ss rank", 1, 2));

//Console.WriteLine(repo.GetById(2)?.Describe());
//Console.WriteLine(repo.GetById(99)?.Describe()); 

//repo.Update(new Magazine("updated magazine", 2, 2));
//repo.GetAll().ToList().ForEach(item => Console.WriteLine(item.Describe()));
#endregion
#region DAY6
string space = new string('-', 30);
Console.WriteLine("welocme in Sakta library");
Repository<LibraryItem> RepoLibraryItems = new Repository<LibraryItem>();
bool exit = true;
while (exit)
{
invalid:
    Console.WriteLine(space);
    Console.WriteLine("1. Add a new book");
    Console.WriteLine("2. List all items");
    Console.WriteLine("3. Borrow an item");
    Console.WriteLine("4. Return an item");
    Console.WriteLine("5. Delete an item");
    Console.WriteLine("9. clear");
    Console.WriteLine("0. Exit");
    Console.Write("Enter your choice: ");
    int choice = int.Parse(Console.ReadLine());
    Console.WriteLine(space);
    switch (choice)
    {
        case 1:
        case 6:
            Console.WriteLine(space);
            AddItem(choice);
            Console.WriteLine(space);
            break;
        case 2:
            Console.WriteLine(space);
            listAllItems(RepoLibraryItems);
            Console.WriteLine(space);
            break;
        case 3:
            Console.WriteLine(space);
            BorrowItem(RepoLibraryItems);
            Console.WriteLine(space);
            break;
        case 4:
            Console.WriteLine(space);
            ReturnItem(RepoLibraryItems);
            Console.WriteLine(space);
            break;
        case 5:
            Console.WriteLine(space);
            DeleteItem(RepoLibraryItems);
            Console.WriteLine(space);
            break;
        case 9:
            Console.Clear();
            break;
        case 0:
            exit = false;
            break;
        default:
            Console.WriteLine("Invalid choice");
            goto invalid;
    }
}
 void AddItem(int i)
{
    if (i == 1)
        AddBook();
    else if (i == 6)
        AddMagazine();
}
void AddBook()
{
    Console.Write("Enter item title: ");
    string title = Console.ReadLine();
    Console.Write("Enter item author: ");
    string author = Console.ReadLine();
    Console.Write("Enter number of pages: ");
    int pages = int.Parse(Console.ReadLine());
    var book = new Book(title, author, pages, LibraryItem.static_id);
    RepoLibraryItems.Add(book);
}
void AddMagazine()
{
    Console.Write("Enter item title: ");
    string title = Console.ReadLine();
    Console.Write("Enter issue number: ");
    int issue = int.Parse(Console.ReadLine());
    var magazine = new Magazine(title,issue, LibraryItem.static_id);
    RepoLibraryItems.Add(magazine);
}
void listAllItems(IRepository<LibraryItem> repo)
{
    foreach (var item in repo.GetAll())
        Console.WriteLine(item.Describe());
}
void BorrowItem(IRepository<LibraryItem> repo) {
    Console.WriteLine("enter item id to borrow:");
    int id = int.Parse(Console.ReadLine());
    var item = repo.GetById(id);
    if (item != null) {
        try
        {
            item.Borrow();
            Console.WriteLine("Item borrowed successfully.");
        }
        catch (InvalidOperationException e)
        {
            Console.WriteLine(e.Message);
        }
    }
    else Console.WriteLine("Item not found");
}
void ReturnItem(IRepository<LibraryItem> repo)
{
    Console.WriteLine("enter item id to return:");
    int id = int.Parse(Console.ReadLine());
    var item = repo.GetById(id);
    if (item != null)
    {
        try
        {
            item.Return();
            Console.WriteLine("Item returned successfully.");
        }
        catch (InvalidOperationException e)
        {
            Console.WriteLine(e.Message);
        }
    }
    else Console.WriteLine("Item not found");
}
void DeleteItem(IRepository<LibraryItem> repo)
{
    Console.Write("Enter item id to delete:");
    int id = int.Parse(Console.ReadLine());
    if(repo.Delete(id))
        Console.WriteLine("Item deleted successfully.");
    else
        Console.WriteLine("Item not found");
}

#endregion