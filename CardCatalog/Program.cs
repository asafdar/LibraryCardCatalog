using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardCatalog
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a file name: ");
            string fileName = Console.ReadLine();
            List<Book> books = new List<Book>();

            int input = 0;

            while (input != 3)
            {
                Console.WriteLine("\n1. Add a Book\n2. List all books\n3. Save and exit");
                input = int.Parse(Console.ReadLine());

                switch (input)
                {
                    case 1:
                        CardCatalog.AddBook(books);
                        continue;
                    case 2:
                        CardCatalog.ListBooks(books);
                        continue;
                    case 3:
                        CardCatalog.Save(books);
                        break;
                    default:
                        break;
                }
            }
            Console.ReadLine();
        }
    }
    
    [Serializable]
    public class CardCatalog
    {
        private string _filename { get; set; }
        private SortedSet<Book> books;

        public CardCatalog(string fileName)
        {
           _filename = fileName;
        }

        public static void ListBooks(List<Book> books)
        {
            foreach (var book in books)
            {
                Console.WriteLine("Author: " + book.Author + "\t\tTitle: " + book.Title + "\t\tISBN: " + book.ISBN);
                Console.Clear();
            }

        }

        public static List<Book> AddBook(List<Book> books)
        {
            Console.Write("\nEnter the title: ");
            string title = Console.ReadLine();

            Console.Write("Enter the author: ");
            string author = Console.ReadLine();

            Console.Write("Enter the ISBN: ");
            string isbn = Console.ReadLine();

            books.Add(new Book(title, author, isbn));
            Console.Clear();

            return books;
        }
        
        public static void Save(List<Book> books)
        {

        }
    }
}
