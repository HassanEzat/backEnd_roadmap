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
int[] numbers = new int[1];

// أ
int first = numbers[0]; // O(1)

// ب
foreach (var n in numbers) //O(n)
    Console.WriteLine(n);

// ج
foreach (var a in numbers)//n
    foreach (var b in numbers)//n*n
        Console.WriteLine(a + b);//O(n^2)

#endregion