using System;
using System.Collections.Generic;
using System.Text;

namespace weak1;

//internal interface IBorrowable
//{

//        bool IsBorrowed { get; }
//        void Borrow();
//        void Return();

//}
public interface IBorrowable
{
    void Borrow();
}

public class Laptop : IBorrowable
{
}