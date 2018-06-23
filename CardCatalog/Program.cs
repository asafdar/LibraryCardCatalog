using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardCatalog
{
    [Serializable]
    public class CardCatalog
    {
        private string _filename { get; set; }
        private SortedSet<Book> books;

        public CardCatalog(string fileName)
        {
           _filename = fileName;
        }

        public void ListBooks()
        {
            foreach (Book book in books){
                Console.WriteLine("Author: " + book.author + ", Title: " + book.title);
            }
        }

        public void AddBook(string author, string title)
        {
            Book newBook = new Book(author, title);
            books.Add(newBook);
        }


    }
}
