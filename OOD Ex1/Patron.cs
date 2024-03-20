using System;

namespace OOD_Ex1
{
	public class Patron
	{
        public string Name { get; }
        public int LibraryCardNumber { get; }
        public List<Book> BorrowedBooks { get; }

        // Constructor
        public Patron(string name, int libraryCardNumber)
        {
            Name = name;
            LibraryCardNumber = libraryCardNumber;
            BorrowedBooks = new List<Book>();
        }

        public void BorrowBook(Book book)
        {
            if (book.IsAvailable)
            {
                // Add a book to list BorrowBooks
                BorrowedBooks.Add(book);
                book.IsAvailable = false;
                Console.WriteLine($"{Name} borrowed '{book.Title}'.");
            }
            else
            {
                Console.WriteLine($"Sorry, the book {book.Title} is not available.");
            }
        }

        public void ReturnBook(Book book)
        {
            if (BorrowedBooks.Contains(book))
            {
                // Remove book out of list BorrowedBooks
                BorrowedBooks.Remove(book);
                book.IsAvailable = true;
                Console.WriteLine($"{Name} returned '{book.Title}'");
            }
            else
            {
                Console.WriteLine($"You have not borrowed the book {book.Title}.");
            }
        }
    }
}

