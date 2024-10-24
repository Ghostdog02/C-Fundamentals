
namespace Library
{
    public class Library
    {
        private string libraryName = null;
        private List<Book> books = null;

        public string LibraryName { get => libraryName; set => libraryName = value; }

        public List<Book> Books { get => books; set => books = value; }

        public Library(string libraryName, List<Book> books)
        {
            this.LibraryName = libraryName;
            this.Books = books;
        }

        public void AddBook(Book book)
        {
            Books.Add(book);
        }

        public void SearchBook(string author, List<Book> books)
        {
            for (int i = 0; i < books.Count; i++)
            {
                if (books[i].Author == author)
                {
                    Console.WriteLine(books[i].Title);
                    break;
                }
            }
        }

        public void PrintInfo(Book book)
        {
            Console.WriteLine($"Auhtor of book is {book.Author}, the title is {book.Title}, the publisher is {book.Publisher}," +
                $" the publish year is {book.Year}");
        }

        public void RemoveBook(Book book)
        {
            Books.Remove(book);
        }
    }
}