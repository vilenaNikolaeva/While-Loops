using System;

namespace Old_Books
{
    class Program
    {
        static void Main(string[] args)
        {
            string bookName = Console.ReadLine();
            int libraryBooks = int.Parse(Console.ReadLine());

            int count = 0;
            while (count <= libraryBooks)
            {
                string book = Console.ReadLine();

                if (book == bookName)
                {
                    Console.WriteLine($"You checked {count} books and found it.");
                    break;
                }

                if (count == libraryBooks)
                {
                    Console.WriteLine($"The book you search is not here!");
                    Console.WriteLine($"You checked {count} books.");
                }
                count++;
            }
        }
    }
}
