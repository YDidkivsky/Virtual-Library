using Trying;
using System;

namespace Trying
{
    public class Program
    {
        static void Main()
        {
            Library library = new Library();

            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("\nLibrary menu:");
                Console.WriteLine("1. Add book");
                Console.WriteLine("2. Edit Book");
                Console.WriteLine("3. Delete book");
                Console.WriteLine("4. Search book");
                Console.WriteLine("5. List of books");
                Console.WriteLine("6. Exit!");

                if (int.TryParse(Console.ReadLine(), out int option))
                {
                    switch (option)
                    {
                        case 1:
                            AddBook(library);
                            break;
                        case 2:
                            EditBook(library);
                            break;
                        case 3:
                            RemoveBook(library);
                            break;
                        case 4: 
                            SearchBook(library);
                            break;
                        case 5 :
                            ListBooks(library);
                            break;
                        case 6:
                            return;
                        default:
                            Console.WriteLine("Invalid option! Please try again!");
                            break;
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Invalid input. Please, enter a number!");
                }
            }
        }

        static void AddBook(Library library)
        {
            Console.WriteLine("Enter book title: ");
            string title = Console.ReadLine();
            Console.WriteLine("Enter book author");
            string author = Console.ReadLine();
            Console.WriteLine("Enter book year");
            int year = int.Parse(Console.ReadLine());

            Book book = new Book(title, author, year);
            Library.AddBook(book);
        }

        static void EditBook(Library library)
        {
            Console.WriteLine("Enter book title to edit: ");
            string title = Console.ReadLine();
            Console.WriteLine("Enter new title");
            string newTitle = Console.ReadLine();
            Console.WriteLine("Enter new author");
            string newAuthor = Console.ReadLine();
            Console.WriteLine("Enter new book year");
            int newYear = int.Parse(Console.ReadLine());
            
            Library.EditBook(title,newTitle, newAuthor, newYear);
        }

        static void RemoveBook(Library library)
        {
            Console.WriteLine("Enter book title to remove: ");
            string title = Console.ReadLine();
            
            Library.RemoveBook(title);
        }

        static void SearchBook(Library library)
        {
            Console.WriteLine("Enter book title to search: ");
            string title = Console.ReadLine();
            
            Library.SearchBook(title);
        }

        static void ListBooks(Library library)
        {  
            Library.ListBooks();
        }
    }
}