using System;
class Book 
{
  public string ISBN { get; set; }
  public string Title { get; set; }
  public Author AuthorInfo { get; set; }
  public DateTime PublishedOn { get; set; }
  public string PublishedBy { get; set; }

  public Book(string isbn, string title, Author authorinfo) : this(isbn, title, authorinfo, DateTime.Today, "Unknown")
  {

  }
  
  public Book(string isbn, string title, Author authorinfo, DateTime publishedon, string publishedby)
  {
    ISBN = isbn;
    Title = title;
    AuthorInfo = authorinfo;
    PublishedOn = publishedon;
    PublishedBy = publishedby;
  }

  public void Display()
  {
    Console.WriteLine("Book: '" + Title + "' was written by " + AuthorInfo.FirstName + " " + AuthorInfo.LastName + " and was published on " + PublishedOn.Date.ToString("d")); 
  }
}