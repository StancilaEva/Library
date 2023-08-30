
namespace LibraryProject.Domain
{
    public class BookLend
    {
        public string BookISBN { get; set; }
        public Book Book { get; set; }
        public DateTime StartDate { get; set; }
    }
}
