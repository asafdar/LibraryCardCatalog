using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Card
{
    [Serializable]
    public class CardCatalog
    {
        private string _filename { get; set; }
        private SortedSet<Book> books { get; set; }

        public CardCatalog(string fileName)
        {
            books = new SortedSet<Book>();
           _filename = fileName;
        }

        public void ListBooks()
        {
            foreach (Book book in books){
                Console.WriteLine("Author: " + book.author + ", Title: " + book.title + ", ISBN: " + book.ISBN);
            }
        }

        public void AddBook(string author, string title, string ISBN)
        {
            Book newBook = new Book(author, title, ISBN);
            books.Add(newBook);
        }

        public void Save(string filename)
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(filename, FileMode.Create, FileAccess.Write, FileShare.None);
            formatter.Serialize(stream, this);
            stream.Close();
        }


    }
}
