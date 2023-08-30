
namespace LibraryProject.Domain
{
    public class Book
    {
        public string ISBN { get; set; }
        public string Title { get; set; }
        public List<double> Prices { get; set; }

        public override string? ToString()
        {
            var bookAsString = $"ISBN: {ISBN},\nTitle: {Title},\n Prices available: ";
            foreach(var price in Prices)
            {
                bookAsString += price + " ";
            }  
            return bookAsString;
        }
    }
}
