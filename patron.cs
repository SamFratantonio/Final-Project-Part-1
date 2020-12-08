using System;
using System.Collections.Generic;

class Patron : Person
{
  public string LibraryId {get; set;}
  public DateTime StartDate {get; set;}
  public DateTime EndDate {get; set;}
  public bool IsAccountActive {get; set;}
  public List<Rental> RentalCart = new List<Rental>();
  public double FineAmountDue {get; set;}

  public Patron(string fname, string lname, string ID)
  :base(fname, lname, "Unknown")
  {
    FineAmountDue = 0;
    StartDate = DateTime.Today;
    LibraryId = ID;
    IsAccountActive = true;
  }

  public void Display()
  {
    Console.WriteLine("Patron ID: " + LibraryId + "\tName: " + FirstName + " " + LastName);
  }

  public void AddToRentalCart(Book book, DateTime dueDate)
  {
    RentalCart.Add(new Rental(book, DateTime.Today, dueDate));
    Console.WriteLine("Added To Rental Cart " + book.Title + " For Patron " + FirstName + " " + LastName);
  }
  public void RemoveFromRentalCart(Book book)
  {
    RentalCart.Remove(RentalCart.Find((r) => {return r.book.ISBN == book.ISBN;}));
    Console.WriteLine("Removed From Rental Cart " + book.Title + " For Patron " + FirstName + " " + LastName);
  }
}