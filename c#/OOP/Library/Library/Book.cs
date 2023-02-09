namespace library
{
    public class Book
    {
        private string _tittle;
        private string _author;
        private int _pages;
        private byte _id;

        public string Tittle
        {
            get { return _tittle; }
            set { _tittle = value; }
        }
        public string Author
        {
            get { return _author; }
            set { _author = value; }
        }
        public int Pages
        {
            get { return _pages; }
            set { _pages = value; }
        }

        public byte id
        {
            get { return _id; }
            set { _id = value; }
        }

        public Book(string tittle, string author, int pages, byte id)
        {
            _tittle = tittle;
            _author = author;
            _pages = pages;
            _id = id;
        }
    }
}