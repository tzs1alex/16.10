using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Channels;

namespace _16._10
{
    internal class Book
    {
        public string title;
        public string genre;
        public int number;
        public string author;

        public Book(string title, string genre, int number, string author)
        {
            this.title = title;
            this.genre = genre;
            this.number = number;
            this.author = author;
        }

        public override string ToString()
        {
            return $"№{number} | {title} | {genre} | Автор: {author}";
        }
    }
}
