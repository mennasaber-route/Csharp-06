using System.Drawing;
using System.Runtime.InteropServices;

namespace Assignment_5
{
    internal class Program
    {

        enum Genre { 
            Fiction, 
            NonFiction, 
            Science 
        }


        class Book
        {
         public Genre Genre { get; set; }
        }

        static void Main(string[] args)
        {

            // **********     Part 2 from assignment 5     **********

            #region Question4
            ////4-Declare an enum Genre { Fiction, NonFiction, Science }. Add a Genre
            ////property to Book, assign it Genre.Science, and print it.

            //Book book = new Book();
            //book.Genre = Genre.Science;
            //Console.WriteLine(book.Genre);

            #endregion


            #region Question5
            ////5-Using the Genre enum above, print the underlying int value of
            ////Genre.Fiction, Genre.NonFiction, and Genre.Science by casting each to int.


            //Console.WriteLine((int)Genre.Fiction);
            //Console.WriteLine((int)Genre.NonFiction);
            //Console.WriteLine((int)Genre.Science);

            #endregion


            #region Question6
            ////6-Given int genreNumber = 1;, cast it into a Genre value and print the result

            //int genreNumber = 1;
            //Genre genreValue = (Genre)genreNumber;
            //Console.WriteLine(genreValue);

            #endregion


            #region Question7
            ////7-Given string genreText = "Science";, convert it into a Genre value using
            ////Enum.Parse() and print the result


            //string genreText = "Science";
            //Genre genreValueFromString = (Genre)Enum.Parse(typeof(Genre), genreText);
            //Console.WriteLine(genreValueFromString);

            #endregion

        }
    }
}
