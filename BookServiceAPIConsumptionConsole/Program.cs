using BookServiceAPIConsumptionConsole.BookClass;
using System;
using System.Configuration;

namespace BookServiceAPIConsumptionConsole
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var apiClient = new WebAPIClient(ConfigurationManager.AppSettings["BaseURL"]);
            var bookClass = new BookDetail();

            //Create Book

            Console.WriteLine("Please enter the New Book Details \n\n\n");
            Console.WriteLine("Book Name: ");
            bookClass.BookName = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Author Name: ");
            bookClass.Author = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Category Name: ");
            bookClass.Category = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Description: ");
            bookClass.Description = Convert.ToString(Console.ReadLine());
            apiClient.Create(bookClass);

            Console.ReadKey();

            //Update Book

            Console.WriteLine("Update Book \n\n\n");

            Console.WriteLine("Book ID: ");
            var bookID = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Book Name: ");
            bookClass.BookName = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Author Name: ");
            bookClass.Author = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Category Name: ");
            bookClass.Category = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Description: ");
            bookClass.Description = Convert.ToString(Console.ReadLine());
            apiClient.Update(bookClass, bookID);

            Console.ReadKey();
        }
    }
}