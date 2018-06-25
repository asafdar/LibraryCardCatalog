using System;

namespace Card
{
    [Serializable]
    class Book
    {

        public string title { get; set; }

        public string author { get; set; }

        public string ISBN { get; set;  }
         
        public Book(string _title, string _author, string _isbn)
        {
            title = _title;
            author = _author;
            ISBN = _isbn;
        }
    }
}
