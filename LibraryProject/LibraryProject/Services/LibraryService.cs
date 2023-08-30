using LibraryProject.Domain;
using LibraryProject.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.Services
{
    public class LibraryService
    {
        private List<Book> Books;
        private List<BookLend> Lends;
        public LibraryService()
        {
        }

        public List<Book> GetAllLibraryBooks()
        {
            return Books;
        }

        public void AddBookToLibrary(BookDetailsDTO bookDetailsDTO)
        {
            CheckIfBookIsValid(bookDetailsDTO);

            var existingBook = Books.FirstOrDefault(book => book.ISBN == bookDetailsDTO.ISBN);

            if (existingBook != null)
            {
                existingBook.Prices.Add(bookDetailsDTO.Price);
            }
            else
            {
                Books.Add(new Book
                {
                    ISBN = bookDetailsDTO.ISBN,
                    Title = bookDetailsDTO.Title,
                    Prices = new List<double>() { bookDetailsDTO.Price },
                });
            }
        }

        public int CheckNumberOfBooksAvailable(string iSBN)
        {
            try
            {
                //trateaza cazul in care nu exista cartea!!!
                var bookCount = Books.First(book => book.ISBN == iSBN).Prices.Count;

                return bookCount - Lends.Where(lend => lend.BookISBN.Equals(iSBN)).Count();
            }
            catch (ArgumentNullException ex)
            {
                throw new Exception("No such book with this ISBN");
            }
        }

        private void CheckIfBookIsValid(BookDetailsDTO bookDetailsDTO)
        {
            if (string.IsNullOrEmpty(bookDetailsDTO.Title.Trim()))
                throw new Exception("The Title cannot be empty");

            if (string.IsNullOrEmpty(bookDetailsDTO.ISBN.Trim()))
                throw new Exception("The ISBN cannot be empty");

            if (bookDetailsDTO.Price <= 0)
                throw new Exception("You have to add a price");
        }
    }
}
