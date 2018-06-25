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
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a filename: ");
            string fileName = Console.ReadLine();
            CardCatalog cardcatalog;

            try
            {
                using (Stream stream = File.Open(fileName, FileMode.Open))
                {
                    Console.WriteLine("Loading card catalog from file...");
                    IFormatter formatter = new BinaryFormatter();
                    cardcatalog = (CardCatalog)formatter.Deserialize(stream);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("File does not exist: instantiating new file/card catalog...");
                cardcatalog = new CardCatalog(fileName);
    
            }

            int input = 0;
            while (input != 3)
            {
                Console.WriteLine("\n1. Add a Book\n2. List all books\n3. Save and exit");

                input = int.Parse(Console.ReadLine());

                switch (input)
                {
                    case 1:
                        Console.WriteLine("Enter the book's title: ");
                        string title = Console.ReadLine();
                        Console.WriteLine("Enter the book's author: ");
                        string author = Console.ReadLine();
                        Console.WriteLine("Enter the book's ISBN: ");
                        string ISBN = Console.ReadLine();
                        cardcatalog.AddBook(author, title, ISBN);
                        continue;
                    case 2:
                        cardcatalog.ListBooks();
                        continue;
                    case 3:
                        cardcatalog.Save(fileName);
                        continue;
                    default:
                        Console.WriteLine("Not a valid input.");
                        break;
                }
            }
        }
    }
}
