using System;
using System.Collections.Generic;
class LibraryCollection
{
  private List<Patron> PatronList = new List<Patron>();
  public List<Book> BookList = new List<Book>();
  public void AddPatron(Patron p)
  {
    PatronList.Add(p);
    Console.WriteLine("Successfully Added " + p.FirstName + " " + p.LastName);
  }
  public void RemovePatron(Patron p)
  {
    PatronList.Remove(PatronList.Find((r) => {return r.LibraryId == p.LibraryId;}));
    Console.WriteLine("Successfully Removed " + p.FirstName + " " + p.LastName);
  }
  public void DisplayPatronInfo()
  {
    foreach (Patron p in PatronList)
    {
      p.Display();
    }
  }
  public void AddToCollection(Book book)
  {
    BookList.Add(book);
    Console.WriteLine("Added book successfully!");
  }
  public void RemoveFromCollection(Book book)
  {
    BookList.Remove(BookList.Find((r) => {return r.ISBN == book.ISBN;}));
    Console.WriteLine("Successfully Removed Book: " + book.Title);
  }
  public void DisplayCollection()
  {
    foreach (Book b in BookList)
    {
      b.Display();
    }
  }
  public void ProcessRental(Patron p)
  {
    foreach (Rental r in p.RentalCart)
    {
      RemoveFromCollection(r.book);
      Console.WriteLine("Processed Rental For " + r.book.Title);
    }
  }
  public void ProcessReturns(Patron p, Book b)
  {
    Rental temp = p.RentalCart.Find((r) => {return r.book.ISBN == b.ISBN;});
    if (DateTime.Compare(DateTime.Today, temp.DateDue) > 0)
    {
      p.FineAmountDue += 10;
      Console.WriteLine("Late: Fine of $10");
    }
    p.RemoveFromRentalCart(b);
    BookList.Add(b);
    Console.WriteLine("Processed Return For " + b.Title);
  }
}