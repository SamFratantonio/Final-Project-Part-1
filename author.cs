using System;
using System.Collections.Generic;
class Author : Person
{
  private List<Book> Books = new List<Book>();
  public Author() : base() {
    
  }
  public Author(string fname, string lname, string ssn) : base(fname, lname, ssn) {

  }
  public Author(string fname, string lname, string ssn, string addr1, string addr2, string cityname, string statename, string zipcode) 
  : base(fname, lname, ssn, addr1, addr2, cityname, statename, zipcode) {

  }

  public void DisplayInfo()
  {
    Console.WriteLine("First Name: " + FirstName + "\nLast Name: "
    + LastName + "\nEmail: " + Email + "\n");
    //extra space makes output easier to read
  }

  public void DisplayBooks()
  {
    foreach (Book book in Books)
    {
      book.Display();
    }
    Console.WriteLine();
  }

  public void AddBook(Book book)
  {
    book.AuthorInfo.FirstName = FirstName;
    book.AuthorInfo.LastName = LastName;
    Books.Add(book);
  }

  public void RemoveBook(string ISBN)
  {
    Books.Remove(Books.Find((b) => {return b.ISBN == ISBN;}));
  }
}