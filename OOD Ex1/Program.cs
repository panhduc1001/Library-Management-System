using System;

namespace OOD_Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a menu for user can choose an options. The menu has:
            //      1. Add book
            //      2. Remove book
            //      3. Search book by title
            //      4. Display all book
            //      5. Borrow a Book
            //      6. Return a Book
            //      7. Exit

            Library library = new Library();

            // Create some books
            Book book1 = new Book("The Great Gasby", "F. Scott Fitzerald", "000001");
            Book book2 = new Book("The Great Shelby", "F. Scott McTominay", "000002");
            Book book3 = new Book("The Great Mickey", "M. Luke Hobbs", "000003");
            Book book4 = new Book("The Great Libby", "F. Lucas Hoho", "000004");

            // Create some patrons
            Patron patron1 = new Patron("John Doe", 1123);

            int option = 0;
            while (option != 7)
            {
                Console.WriteLine("*** MENU ***");
                Console.WriteLine("1. Add book");
                Console.WriteLine("2. Remove book");
                Console.WriteLine("3. Search book by title");
                Console.WriteLine("4. Display all book");
                Console.WriteLine("5. Borrow a book");
                Console.WriteLine("6. Return a book");
                Console.WriteLine("7. Exit");
                Console.WriteLine();

                string input = Console.ReadLine();
                bool isValid = int.TryParse(input, out option);

                if (isValid)
                {
                    switch (option)
                    {
                        case 1:
                            Console.WriteLine("Enter your book: ");
                            string bookInput = Console.ReadLine();
                            switch (bookInput.ToLower())
                            {
                                case "book1":
                                    library.AddBook(book1);
                                    break;

                                case "book2":
                                    library.AddBook(book2);
                                    break;

                                case "book3":
                                    library.AddBook(book3);
                                    break;

                                case "book4":
                                    library.AddBook(book4);
                                    break;
                                default:
                                    Console.WriteLine(bookInput + " is not exist");
                                    break;

                            }
                            break;

                        case 2:
                            Console.WriteLine("Enter your book: ");
                            string bookInputToRemove = Console.ReadLine();
                            switch (bookInputToRemove.ToLower())
                            {
                                case "book1":
                                    library.RemoveBook(book1);
                                    break;

                                case "book2":
                                    library.RemoveBook(book2);
                                    break;

                                case "book3":
                                    library.RemoveBook(book3);
                                    break;

                                case "book4":
                                    library.RemoveBook(book4);
                                    break;
                                default:
                                    Console.WriteLine(bookInputToRemove + " is not exist");
                                    break;
                            }
                            break;

                        case 3:
                            Console.WriteLine("Enter your book: ");
                            string bookTitle = Console.ReadLine();
                            Book foundBook = library.SearchBook(bookTitle);

                            if (foundBook != null)
                            {
                                foundBook.DisplayInfo();
                            }
                            else
                            {
                                Console.WriteLine($"'{bookTitle}' is not found!");
                            }
                            break;

                        case 4:
                            library.DisplayAllBooks();
                            break;

                        case 5:
                            Console.WriteLine("Enter book title you want to borrow: ");
                            string bookInputToBorrow = Console.ReadLine();
                            Book foundBookToBorrow = library.SearchBook(bookInputToBorrow);

                            if (foundBookToBorrow != null)
                            {
                                // Check if book is available
                                if (foundBookToBorrow.IsAvailable)
                                {
                                    patron1.BorrowBook(foundBookToBorrow);
                                }
                                else
                                {
                                    Console.WriteLine("This book is not available");
                                }
                            }
                            else
                            {
                                Console.WriteLine($"'{bookInputToBorrow}' is not found!");
                            }
                            break;

                        case 6:
                            Console.WriteLine("Enter book title you want to return: ");
                            string bookInputToReturn = Console.ReadLine();
                            Book foundBookToReturn = patron1.BorrowedBooks.Find(book => book.Title.ToLower() == bookInputToReturn.ToLower());

                            if (foundBookToReturn != null)
                            {
                                patron1.ReturnBook(foundBookToReturn);
                            }
                            else
                            {
                                Console.WriteLine($"'{bookInputToReturn}' is not found!");
                            }
                            break;

                        case 7:
                            Console.WriteLine("Exiting...");
                            break;

                        default:
                            Console.WriteLine("Your choice is not valid");
                            break;

                    }
                }
                else
                {
                    Console.WriteLine("Your choice is not valid");
                    option = 0;
                }
            }
        }
    }
}
