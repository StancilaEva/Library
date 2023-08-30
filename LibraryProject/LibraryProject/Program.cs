// See https://aka.ms/new-console-template for more information
using LibraryProject.Domain;

Console.WriteLine("Hello, World!");


List<Book> books = new List<Book>()
{
    new Book()
    {
        ISBN = "isbn 1",
        Title = "A Little Life",
        Prices = new List<double>()
        { 1, 4 }
     //   Quantity = 2
    },
    new Book()
    {
        ISBN = "isbn 2",
        Title = "Sharks in time of saviors",
        Prices = new List<double>
        { 1.5 }
       // Quantity = 1
    },
    new Book()
    {
        ISBN = "isbn 3",
        Title = "Night Circus",
        Prices = new List<double>
        { 2.4, 6.4, 2.4 }
     //   Quantity = 4
    },
    new Book()
    {
        ISBN = "isbn 4",
        Title = "Anansi Brothers",
        Prices = new List<double>
        { 1.5 }
     //   Quantity = 2
    }
};