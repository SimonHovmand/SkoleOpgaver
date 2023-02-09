namespace library
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Book> books = new List<Book>(); //Make a list of books

            Stack<Book> lent = new Stack<Book>(); //Make a stack of lent

            //Add books to the list of books
            books.Add(new Book("Harry_Potter_1", "J.K.Rowling", 200, 1));
            books.Add(new Book("Harry_Potter_2", "J.K.Rowling", 434, 2));
            books.Add(new Book("Harry_Potter_3", "J.K.Rowling", 546, 3));
            books.Add(new Book("Harry_Potter_4", "J.K.Rowling", 673, 4));
            books.Add(new Book("Harry_Potter_5", "J.K.Rowling", 763, 5));
            books.Add(new Book("Harry_Potter_6", "J.K.Rowling", 787, 6));

            while (true)
            {
                Console.WriteLine("Ønsker du at indsmale bøger? Tast: 1");
                Console.WriteLine("Ønsker du at se dine lånte bøger? Tast: 2");
                Console.WriteLine("Ønsker du at låne dine bøger? Tast: 3\n");

                if (Byte.TryParse(Console.ReadLine(), out byte choice)) //Convert ReadLine to byte
                {
                    switch (choice)
                    {
                        case 1: //If choice is 1
                            Console.WriteLine("\nBøger til rådighed:");
                            Console.WriteLine("Name , Author , Pages , Id");
                            Console.ForegroundColor = ConsoleColor.Blue;
                            foreach (Book book in books) //Write all books in book
                            {
                                Console.WriteLine(book.Tittle + " , " + book.Author + " , " + book.Pages + " , " + book.id);
                            }
                            Console.ResetColor();
                            Console.WriteLine("Hvilen bog ønsker du at låne");
                            Console.WriteLine("Skriv ID'et på den bog du ønsker at låne!\n");

                            if (Byte.TryParse(Console.ReadLine(), out byte input)) //Convert ReadLine to byte
                            {
                                Book placeholder = null;
                                foreach (Book book in books)  //Foreach book in books
                                {
                                    if (book.id == input)
                                    {
                                        lent.Push(book); //Push the book to lent

                                        placeholder = book; //Set placeholder to book

                                    }
                                }
                                books.Remove(placeholder); //Remove the book/placeholder from books.
                            }
                            break;
                        case 2: //If choice is 1
                            foreach (Book book in lent) //Write all books in lent
                            {
                                Console.WriteLine(book.Tittle + " " + book.Author + " " + book.Pages + " " + book.id);
                            }
                            Console.WriteLine(" ");
                            break;
                        case 3: //If choice is 1
                            foreach (Book book in lent)
                            {
                                Console.WriteLine("Ønsker du at låne denne bog?");
                                Console.WriteLine(lent.Peek());

                                string choice2 = Console.ReadLine();

                                if (choice2.ToUpper() == "Y")
                                {
                                    lent.Pop(); //Remove the first book from lent
                                }
                            }
                            break;
                        default:
                            Console.WriteLine("Fejl");
                            break;
                    }
                }
            }
        }
    }
}