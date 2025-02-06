using System;
using System.Collections.Generic;
using System.Linq;

public class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public string ISBN { get; set; }
    public bool IsBorrowed { get; private set; }

    public Book(string title, string author, string isbn)
    {
        Title = title;
        Author = author;
        ISBN = isbn;
        IsBorrowed = false;
    }

    public void Borrow()
    {
        IsBorrowed = true;
    }

    public void Return()
    {
        IsBorrowed = false;
    }
}

public class Borrower
{
    public string Name { get; set; }
    public string LibraryCardNumber { get; set; }
    public List<Book> BorrowedBooks { get; private set; }

    public Borrower(string name, string libraryCardNumber)
    {
        Name = name;
        LibraryCardNumber = libraryCardNumber;
        BorrowedBooks = new List<Book>();
    }

    public void BorrowBook(Book book)
    {
        if (!book.IsBorrowed)
        {
            book.Borrow();
            BorrowedBooks.Add(book);
        }
    }

    public void ReturnBook(Book book)
    {
        if (BorrowedBooks.Contains(book))
        {
            book.Return();
            BorrowedBooks.Remove(book);
        }
    }
}

public class Library
{
    public List<Book> Books { get; private set; }
    public List<Borrower> Borrowers { get; private set; }

    public Library()
    {
        Books = new List<Book>();
        Borrowers = new List<Borrower>();
    }

    public void AddBook(Book book)
    {
        Books.Add(book);
        Console.WriteLine("Book added successfully.");
    }

    public void RegisterBorrower(Borrower borrower)
    {
        Borrowers.Add(borrower);
        Console.WriteLine("Borrower registered successfully.");
    }

    public void BorrowBook(string isbn, string libraryCardNumber)
    {
        Book book = Books.FirstOrDefault(b => b.ISBN == isbn && !b.IsBorrowed);
        Borrower borrower = Borrowers.FirstOrDefault(b => b.LibraryCardNumber == libraryCardNumber);

        if (book != null && borrower != null)
        {
            borrower.BorrowBook(book);
            Console.WriteLine("Book borrowed successfully.");
        }
        else
        {
            Console.WriteLine("Book is not available or borrower not found.");
        }
    }

    public void ReturnBook(string isbn, string libraryCardNumber)
    {
        Borrower borrower = Borrowers.FirstOrDefault(b => b.LibraryCardNumber == libraryCardNumber);
        Book book = borrower?.BorrowedBooks.FirstOrDefault(b => b.ISBN == isbn);

        if (book != null)
        {
            borrower.ReturnBook(book);
            Console.WriteLine("Book returned successfully.");
        }
        else
        {
            Console.WriteLine("Borrower or book not found.");
        }
    }

    public void ViewBooks()
    {
        foreach (var book in Books)
        {
            Console.WriteLine($"Title: {book.Title}, Author: {book.Author}, ISBN: {book.ISBN}, Status: {(book.IsBorrowed ? "Borrowed" : "Available")}");
        }
    }

    public void ViewBorrowers()
    {
        foreach (var borrower in Borrowers)
        {
            Console.WriteLine($"Name: {borrower.Name}, Card Number: {borrower.LibraryCardNumber}, Borrowed Books: {borrower.BorrowedBooks.Count}");
        }
    }
}
