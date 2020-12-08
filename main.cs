using System;

class MainClass {
  public static void Main (string[] args) {
    Book b1 = new Book("1", "How To Come Up With Names", new Author());
    Book b2 = new Book("2", "My Dog Ate My Computer", new Author());
    Book b3 = new Book("3", "Random Book", new Author());
    Book b4 = new Book("4", "How To Build A Computer", new Author(), DateTime.Parse("5/6/2008"), "Bob Jones Publishing");
    Book b5 = new Book("5", "How To Tie A Knot", new Author(), DateTime.Parse("6/4/2004"), "Publishing Co.");
    Book b6 = new Book("6", "How To Train A Dog", new Author(),DateTime.Parse("3/7/1994"), "Bob Jones Publishing");
    
    Author bobJones = new Author("Bob", "Jones", "999-99-9999");
    bobJones.Email = "bobjones@gmail.com";
    Author johnDoe = new Author("John", "Doe", "888-88-8888");
    johnDoe.Email = "johndoe@outlook.com";
    bobJones.DisplayInfo();
    johnDoe.DisplayInfo();
    bobJones.AddBook(b1);
    bobJones.AddBook(b3);
    bobJones.AddBook(b5);
    bobJones.DisplayBooks();
    johnDoe.AddBook(b2);
    johnDoe.AddBook(b4);
    johnDoe.AddBook(b6);
    johnDoe.DisplayBooks();
    bobJones.RemoveBook("1");
    bobJones.DisplayBooks();

    /*
    Part 2
    */
    Patron p1 = new Patron("Alex", "McDonald", "11");
    Patron p2 = new Patron("Robert", "Carpenter", "12");
    Patron p3 = new Patron("James", "Parker", "13");
    Patron p4 = new Patron("Bob", "McDonald", "14");
    Patron p5 = new Patron("Janie", "Wright", "15");
    p1.AddToRentalCart(b1, DateTime.Today);
    p1.AddToRentalCart(b3, DateTime.Today);
    p1.RemoveFromRentalCart(b3);
    p1.Display();
  }
}