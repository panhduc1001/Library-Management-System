using System;

namespace OOD_Ex1
{
	public class Book
	{
        public string Title { get; }
        public string Author { get; }
        public string ISBN { get; }
        public bool IsAvailable { get; set; }

        // Constructor
        public Book(string title, string author, string isbn)
        {
            Title = title;
            Author = author;
            ISBN = isbn;
            IsAvailable = true;
        }

        public void DisplayInfo()
        {
            // Print all info of a Book
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Author: {Author}");
            Console.WriteLine($"ISBN: {ISBN}");
            Console.WriteLine("Available:" + IsAvailable);
        }
    }
}

