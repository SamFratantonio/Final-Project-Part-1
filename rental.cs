using System;
using System.Collections.Generic;

class Rental 
{
  public Book book {get; set;}
  public DateTime DateRented {get; set;}
  public DateTime DateDue {get; set;}
  public Rental(Book b, DateTime dr, DateTime dd)
  {
    book = b;
    DateRented = dr;
    DateDue = dd;
  }
}