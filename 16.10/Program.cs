using System.Text;

namespace _16._10
{
    internal class Program
    {
        static void ShowAvailableBooks(List<Book> books)
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
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            Librarian librarian =
            new Librarian("Мария", "Иванова");

            Console.WriteLine(
                $"Библиотекар: {librarian.GetFullName()}");

            Book book1 = new Book(
                "Под игото", "Роман", 101, "Иван Вазов");

            Book book2 = new Book(
                "Бай Ганьо", "Сатира", 102, "Алеко Константинов");

            Book book3 = new Book(
                "Малкият принц", "Приказка", 103,
                "Антоан дьо Сент-Екзюпери");

            librarian.AddBook(book1);
            librarian.AddBook(book2);
            librarian.AddBook(book3);

            Reader reader1 =
                librarian.RegisterReader("Иван", "Петров");

            Reader reader2 =
                librarian.RegisterReader("Елена", "Георгиева");

            Console.WriteLine("\n--- Вземане на книга ---");

            reader1.BorrowBook(
                book1, librarian.GetAvailableBooks());

            librarian.ShowAvailableBooks();

            Console.WriteLine("\n--- Връщане на книга ---");

            reader1.ReturnBook(
                book1, librarian.GetAvailableBooks());

            librarian.ShowAvailableBooks();

            Console.WriteLine("\nКрай на програмата.");
        }
    }
    
}
