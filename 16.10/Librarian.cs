using System;
using System.Collections.Generic;
using System.Reflection.PortableExecutable;
using System.Text;

namespace _16._10
{
    internal class Librarian: Person
    {
        private List<Book> books;
        private List<Reader> readers;
        private int nextCardNumber;

        public Librarian(string firstName, string lastName)
            : base(firstName, lastName)
        {
            books = new List<Book>();
            readers = new List<Reader>();
            nextCardNumber = 1001;
        }

        public void AddBook(Book book)
        {
            books.Add(book);
            Console.WriteLine($"Добавена е книга: {book.title}");
        }

        public Reader RegisterReader(string firstName, string lastName)
        {
            Reader reader = new Reader(firstName, lastName);

            CreateLibraryCard(reader);
            readers.Add(reader);

            Console.WriteLine(
                $"Регистриран читател: {reader.GetFullName()}, " +
                $"карта №{reader.GetLibraryCardNumber()}");

            return reader;
        }

        public void CreateLibraryCard(Reader reader)
        {
            reader.SetLibraryCardNumber(nextCardNumber);
            nextCardNumber++;
        }

        public void ShowAvailableBooks()
        {
            Console.WriteLine("\n--- Налични книги ---");

            if (books.Count == 0)
            {
                Console.WriteLine("Няма налични книги.");
                return;
            }

            foreach (Book book in books)
            {
                Console.WriteLine(book);
            }
        }

        public List<Book> GetAvailableBooks()
        {
            return books;
        }
    }
}
