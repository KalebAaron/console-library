using System;
using console_library.Models;

namespace console_library
{
    class Program
    {
        static void Main(string[] args)
        {
            //WHERE THE APPLICATION STARTS (ENTRY POINT!!!!)
            var x = new Library();
            var mobyDick = new Book("Moby Dick", "Herman Melville", "x");
            x.Books.Add(mobyDick);

            var myBooks = new Library();
            
            var playing = true;

            while (playing)
            {
                Console.WriteLine("What would you like to do?");
                Console.WriteLine(@"
                1. View Library
                2. Look at your own books
                3. Quit
                ");

                var userChoice = Console.ReadLine();
                if(userChoice == "1")
                {
                    x.ShowBooks();
                }
                if(userChoice == "2")
                {
                    myBooks.ShowBooks();
                }
                if(userChoice == "3")
                {
                    playing = false;
                }


            }

        }
    }
}
