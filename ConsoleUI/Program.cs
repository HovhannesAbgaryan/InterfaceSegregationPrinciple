using DemoLibrary.AudioBook;
using DemoLibrary.Book;
using DemoLibrary.Movie;
using System;
using System.Collections.Generic;

namespace ConsoleUI
{
    class Program
    {
        /// <summary>
        /// Welcome message
        /// </summary>
        static void WelcomeMessage()
        {
            Console.WriteLine("SOLID Principles");
            Console.WriteLine("The I in SOLID - Interface Segregation Principle (ISP)");
            Console.WriteLine("Welcome to ISPDemo application!");
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            //Display welcome message
            WelcomeMessage();

            #region Book

            //Create a book
            IBorrowableBook book = new Book()
            {
                 LibraryId = "1",
                 Title = "Sherlock Holmes",
                 Author = "Arthur Conan Doyle",
                 Pages = 1000,
            };

            #region Check out

            //Display message about book check out
            Console.WriteLine("BOOK CHECK OUT");

            //Check out the book for reader
            book.CheckOut("Hovhannes Abgaryan");

            //Print information about the book
            Console.WriteLine($"Book title: {book.Title}. Borrower: {book.Borrower}. Borrow date: {book.BorrowDate.ToShortDateString()}");
            Console.WriteLine($"Due date: {book.GetDueDate().ToShortDateString()}");
            Console.WriteLine();

            #endregion Check out

            #region Check in

            //Display message about book check in
            Console.WriteLine("BOOK CHECK IN");

            //Check in the book
            book.CheckIn();

            //Print information about the book
            Console.WriteLine($"Book title: {book.Title}. Borrower: returned to library.");
            Console.WriteLine();

            #endregion Check in

            #endregion Book

            #region Audio book

            //Create an audio book
            IBorrowableAudioBook audioBook = new AudioBook()
            {
                LibraryId = "2",
                Title = "The Alchemist",
                Author = "Paulo Coelho",
                RuntimeInMinutes = 500
            };

            #region Check out

            //Display message about audio book check out
            Console.WriteLine("AUDIO BOOK CHECK OUT");

            //Check out the audio book for listener
            audioBook.CheckOut("Hovhannes Abgaryan");

            //Print information about the audio book
            Console.WriteLine($"Audio book title: {audioBook.Title}. Borrower: {audioBook.Borrower}. Borrow date: {audioBook.BorrowDate.ToShortDateString()}");
            Console.WriteLine($"Due date: {audioBook.GetDueDate().ToShortDateString()}");
            Console.WriteLine();

            #endregion Check out

            #region Check in

            //Display message about audio book check in
            Console.WriteLine("AUDIO BOOK CHECK IN");

            //Check in the audio book
            audioBook.CheckIn();

            //Print information about the audio book
            Console.WriteLine($"Audio book title: {audioBook.Title}. Borrower: returned to library.");
            Console.WriteLine();

            #endregion Check in

            #endregion Audio book

            #region DVD

            //Create a DVD
            IBorrowableMovie dvd = new DVD()
            {
                LibraryId = "3",
                Title = "Iron Man",
                Actors = new List<string>() { "Robert Downey Jr.", "Gwyneth Paltrow", "Samuel L. Jackson" },
                RuntimeInMinutes = 126
            };

            #region Check out

            //Display message about DVD check out
            Console.WriteLine("DVD CHECK OUT");

            //Check out the DVD for watcher
            dvd.CheckOut("Hovhannes Abgaryan");

            //Print information about the DVD
            Console.WriteLine($"DVD title: {dvd.Title}. Borrower: {dvd.Borrower}. Borrow date: {dvd.BorrowDate.ToShortDateString()}");
            Console.WriteLine($"Due date: {dvd.GetDueDate().ToShortDateString()}");
            Console.WriteLine();

            #endregion Check out

            #region Check in

            //Display message about DVD check in
            Console.WriteLine("DVD CHECK IN");

            //Check in the DVD
            dvd.CheckIn();

            //Print information about the DVD
            Console.WriteLine($"DVD title: {dvd.Title}. Borrower: returned to library.");
            Console.WriteLine();

            #endregion Check in

            #endregion DVD

            #region Digital movie

            //Create a digital movie
            IBorrowableMovie digitalMovie = new DigitalMovie()
            {
                LibraryId = "4",
                Title = "Pirates of the Caribbean: The Curse of the Black Pearl",
                Actors = new List<string>() { "Johnny Depp", "Geoffrey Rush", "Orlando Bloom", "Keira Knightley" },
                RuntimeInMinutes = 143
            };

            #region Check out

            //Display message about digital movie check out
            Console.WriteLine("DIGITAL MOVIE CHECK OUT");

            //Check out the digital movie for watcher
            digitalMovie.CheckOut("Hovhannes Abgaryan");

            //Print information about the digital movie
            Console.WriteLine($"Digital movie title: {digitalMovie.Title}. Borrower: {digitalMovie.Borrower}. Borrow date: {digitalMovie.BorrowDate.ToShortDateString()}");
            Console.WriteLine($"Due date: {digitalMovie.GetDueDate().ToShortDateString()}");
            Console.WriteLine();

            #endregion Check out

            #region Check in

            //Display message about digital movie check in
            Console.WriteLine("DIGITAL MOVIE CHECK IN");

            //Check in the digital movie
            digitalMovie.CheckIn();

            //Print information about the digital movie
            Console.WriteLine($"Digital movie title: {digitalMovie.Title}. Borrower: returned to library.");
            Console.WriteLine();

            #endregion Check in

            #endregion Digital movie
        }
    }
}
