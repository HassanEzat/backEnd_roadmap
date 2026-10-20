using System;
using System.Collections.Generic;
using System.Text;

namespace weak1;

public class Member
{
    public string Email { get;}
    public string Name { get; }
    public Member(string name, string email)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(name);
        ArgumentException.ThrowIfNullOrWhiteSpace(email);
        if (!email.Contains('@')) throw new ArgumentException("email must contain @", nameof(email));

        Name = name;
        Email = email;
    }
}
