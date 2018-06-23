namespace CardCatalog
{
    class Book
    {

        public string title { get; set; }

        public string author { get; set; }
         
        public Book(string _title, string _author)
        {
            title = _title;
            author = _author;
        }
    }
}