using System;
using System.Collections.Generic;
using System.Text;

namespace _16._10
{
    internal class Reader: Person
    {
        public Reader(string firstName, string lastName)
        : base(firstName, lastName)
        {
        }

        public void BorrowBook(Book book, List<Book> availableBooks)
        {
            if (availableBooks.Remove(book))
            {
                Console.WriteLine(
                    $"{GetFullName()} взе книгата \"{book.title}\".");
            }
            else
            {
                Console.WriteLine(
                    $"Книгата \"{book.title}\" не е налична.");
            }
        }

        public void ReturnBook(Book book, List<Book> availableBooks)
        {
            if (!availableBooks.Contains(book))
            {
                availableBooks.Add(book);

                Console.WriteLine(
                    $"{GetFullName()} върна книгата \"{book.title}\".");
            }
            else
            {
                Console.WriteLine("Книгата вече е налична.");
            }
        }
    }
}
