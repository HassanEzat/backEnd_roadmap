\# Library Console

&#x20;

A console application for managing a small library (books and magazines), built with C# and .NET 10 while learning object-oriented design and generics.

&#x20;

\## Features

&#x20;

\- Add books and magazines

\- List all items

\- Borrow and return items (with state validation)

\- Delete items by Id

\- Clear the console

\## Concepts Practiced

&#x20;

\- \*\*Encapsulation:\*\* read-only properties and `private set` so an item protects its own state (`IsBorrowed`).

\- \*\*Validation in constructors:\*\* invalid objects can never be created (`ArgumentException`, `ArgumentOutOfRangeException`).

\- \*\*Inheritance and polymorphism:\*\* `Book` and `Magazine` inherit from the abstract `LibraryItem`; each overrides `LoanDays` and implements `Describe()`.

\- \*\*Interfaces:\*\* `IBorrowable` and `IEntity` describe capabilities and contracts.

\- \*\*Generics:\*\* `Repository<T>` implements `IRepository<T>` with a `where T : IEntity` constraint, so one class manages any entity type.

\- \*\*Exception handling:\*\* specific `catch` blocks (`InvalidOperationException`) so the program keeps running on invalid operations.

\## Project Structure

&#x20;

```

LibraryItem   (abstract)  -> Id, Title, IsBorrowed, Borrow(), Return(), LoanDays, Describe()

├── Book                  -> Author, Pages

└── Magazine              -> Issue

&#x20;

IEntity                   -> Id

IBorrowable               -> IsBorrowed, Borrow(), Return()

IRepository<T>            -> Add, GetAll, GetById, Update, Delete

Repository<T>             -> in-memory implementation backed by List<T>

```

&#x20;

\## Getting Started

&#x20;

Requirements: \[.NET 10 SDK](https://dotnet.microsoft.com/download)

&#x20;

```bash

git clone <repository-url>

cd <project-folder>

dotnet run

```

&#x20;

\## Possible Improvements

&#x20;

\- Safer input handling (`int.TryParse` instead of `int.Parse`)

\- Generate Ids inside the repository instead of the caller

\- Persist data (JSON file, then a database with EF Core)

\- Use the `Member` class to track who borrowed which item

\- Add unit tests for the models and the repository

&#x20;

