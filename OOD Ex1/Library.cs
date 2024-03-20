using System;

namespace OOD_Ex1
{
    class Library
    {
        public List<Book> Books { get; }
        // Constructor
        public Library()
        {
            Books = new List<Book>();
        }

        public void AddBook(Book book)
        {
            // Add a book to list Books
            if (Books.Contains(book))
            {
                Console.WriteLine("This book is already in library!\n");
            }
            else
            {
                Books.Add(book);
                book.IsAvailable = true;
                Console.WriteLine($"'{book.Title}' is added.\n");
            }
        }

        public void RemoveBook(Book book)
        {
            // Remove a book out of list Books
            if (!Books.Contains(book))
            {
                Console.WriteLine($"'{book.Title}' is not in the library!\n");
            }
            else
            {
                Books.Remove(book);
                book.IsAvailable = false;
                Console.WriteLine($"'{book.Title}' is borrowed.\n");
            }
        }

        public Book SearchBook(string title)
        {
            // Use function Find() to complete this method
            return Books.Find(book => book.Title.ToLower() == title.ToLower());
        }

        public void DisplayAllBooks()
        {
            if (Books != null)
            {
                foreach (var book in Books)
                {
                    // Use method DisplayInfo() of book to complete this method
                    book.DisplayInfo();
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("The Library has no books!\n");
            }
        }
    }
}

