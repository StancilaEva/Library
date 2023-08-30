using LibraryProject.DTOs;
using LibraryProject.Services;

namespace LibraryProject.Menu
{
    public class Menu
    {
        private LibraryService libraryService;

        public void ShowChoices()
        {
            Console.WriteLine("1. Add new book to the library");
            Console.WriteLine("2. List all the library books");
            Console.WriteLine("3. Show me how many are left of this book");
            Console.WriteLine("4. Lend me a book");
            Console.WriteLine("5. Give back book");
            Console.WriteLine("6. Exit");
            Console.WriteLine("Enter your choice: ");
        }

        public void RunMenu()
        {
            while (true)
            {
                ShowChoices();
                var choice = ReadUserChoiceInput();

                switch (choice)
                {
                    case 1:
                        AddNewBookToLibraryChoice();
                        break;
                    case 2:
                        ListAllTheBooks();
                        break;
                    default:
                        {

                        }
                }
            }
        }

        private void ListAllTheBooks()
        {
            Console.WriteLine();
        }

        private void AddNewBookToLibraryChoice()
        {
            double price; string isbn; string title;

            Console.WriteLine("ISBN: ");
            isbn = Console.ReadLine();

            Console.WriteLine("Title: ");
            title = Console.ReadLine();

            Console.WriteLine("Price (Please enter a number): ");
            var priceAsString = Console.ReadLine();

            if (!double.TryParse(priceAsString, out price))
            {
                throw new Exception("Please provide a number!");
            }

            libraryService.AddBookToLibrary(new BookDetailsDTO()
            {
                ISBN = isbn,
                Title = title,
                Price = price
            });
        }

        private int ReadUserChoiceInput()
        {
            int choiceNumber;
            string input = Console.ReadLine();

            while (!int.TryParse(input, out choiceNumber) || (choiceNumber < 0 && choiceNumber > 6))
            {
                Console.WriteLine("Please enter a number between 1 and 6)");
                input = Console.ReadLine();
            }

            return choiceNumber;
        }
    }
}
