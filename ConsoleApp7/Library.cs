namespace Trying
{

    class Library
    {
        private static List<Book> books = new List<Book>();

        public static void AddBook(Book book)
        {
            books.Add(book);
            Console.WriteLine("Book added successfully! :) ");
        }

        public static void EditBook(string title, string newTitle, string newAuthor, int newYear)
        {
            Book book = null;

            foreach (Book b in books)
            {
                if (b.Title.Equals(title, StringComparison.OrdinalIgnoreCase))
                {
                    book = b;
                    break;
                }
            }

            if (book != null)
            {
                book.Title = newTitle;
                book.Author = newAuthor;
                book.Year = newYear;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Congrats! Book updated!");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Book not found");
            }
        }

        public static void RemoveBook(string title)
        {
            Book book = null;

            foreach (Book b in books)
            {
                if (b.Title.Equals(title, StringComparison.OrdinalIgnoreCase))
                {
                    book = b;
                    break;
                }
            }

            if (book != null)
            {
                books.Remove(book);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Congrats! Book removed!");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Book not found");
            }
        }

        public static void SearchBook(string title)
        {
            Book book = null;

            foreach (Book b in books)
            {
                if (b.Title.Equals(title, StringComparison.OrdinalIgnoreCase))
                {
                    book = b;
                    break;
                }
            }

            if (book != null)
            {
                Console.WriteLine(book);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Book not found");
            }
        }

        public static void ListBooks()
        {
            foreach (var book in books)
            {
                Console.WriteLine(book);
            }
        }
    }
}