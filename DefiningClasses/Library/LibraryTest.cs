using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class LibraryTest
    {
        static void Main()
        {
            List<Book> books = new();
            Library library = new("Dogshit", books);
            var book1 = new Book("dfs", "Steven King", "IDK", "1969", "0249304092403904");
            var book2 = new Book("dfs", "Steven King", "kh", "1969", "0909789987978898");
            var book3 = new Book("dfs", "LPOLS", "IDK", "1969", "5490560406490604");
            var book4 = new Book("dfs", "DSDSLP", "IDK", "1969", "5490560406490604");
            var book5 = new Book("dfs", "Steven King", "IDK", "1969", "5490560406490604");
            library.AddBook(book1);
            library.AddBook(book2);
            library.AddBook(book3);
            library.AddBook(book4);
            library.AddBook(book5);

            foreach (Book book in library.Books)
            {
                library.PrintInfo(book);
            }
                     

            for (int i = 0; i < library.Books.Count; i++)
            {
                var book = library.Books[i];
                if (book.Author == "Steven King")
                {
                    library.RemoveBook(book);
                    i--;
                }
            }

            Console.WriteLine();
            foreach (Book book in library.Books)
            {
                library.PrintInfo(book);
            }
        }
    }
}
