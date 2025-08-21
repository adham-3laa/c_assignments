namespace ADV_Task_4
{
    


    internal class Program
    {
       
       
        private static void Main(string[] args)
        {
            List<Book> books = new List<Book>
            {
                new Book("978-3-16-148410-0", "C# Programming",new[]{ "John Doe"},
                    new DateTime(2020, 1, 1), 29.99m),
                new Book("978-1-23-456789-7", "Advanced C#",
                    new[] { "Alice Johnson" },
                    new DateTime(2021, 5, 15), 39.99m)
            };
            //BookFunctionDelegate titleDelegate = BookFunctions.GetTitle;
            //BookFunctionDelegate authorsDelegate = BookFunctions.GetAuthors;
            //BookFunctionDelegate priceDelegate = BookFunctions.GetPrice;
            //Console.Write("Book Titles:");
            //LibraryEngine.ProcessBooks(books, titleDelegate);
            //Console.Write("\nBook Authors:");
            //LibraryEngine.ProcessBooks(books, authorsDelegate);
            //Console.Write("\nBook Prices:");
            //LibraryEngine.ProcessBooks(books, priceDelegate);
            //c)	Anonymous Method(GetISBN).
            LibraryEngine.ProcessBooks(books, delegate (Book book)
            {
                return book.ISBN;
            });
            //d)	Lambda Expression (GetPublicationDate).
            LibraryEngine.ProcessBooks(books, book => book.PublicationDate.ToShortDateString());

        }
    }
}