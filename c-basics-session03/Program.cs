using System.Drawing;
using System;
using System.Security.Cryptography;
using System.Text;
using System.Net.NetworkInformation;

namespace c_basics_session03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question 1
            //Declare string title = "clean code"; Call title.ToUpper() and store it in a new variable upperTitle.Print both title and upperTitle to show that title did not change

            string title = "clean code";
            string upperTitle = title.ToUpper();

            Console.WriteLine(title);
            Console.WriteLine(upperTitle);

            #endregion

            #region Question 2
            //Declare two separate string variables, both set to the literal "Clean Code". Use ReferenceEquals() to check if they point to the same object in memory.

            string code1 = "clean code";
            string code2 = "clean code";

            Console.WriteLine(object.ReferenceEquals(code1, code2));


            #endregion

            #region Question 3
            //Create a StringBuilder, Append() the text "Book List", then Append() " - Updated" onto the same object.Print the final result.

            StringBuilder s_B = new StringBuilder();
            s_B.Append("Book List");
            s_B.Append("_Updated");

            Console.WriteLine(s_B);


            #endregion

            #region Question 4
            //Using the StringBuilder from the question above, use Replace() to change "Book List" into "Library". Print the result.

            s_B.Replace("Book List", "Library");
            Console.WriteLine(s_B);


            #endregion

            #region Question 5 
            //Given string title = "Clean Code"; and int pages = 464;, build the sentence "Book: Clean Code, Pages: 464" using the + operator.

            // String title in Question 1 
            int pages = 464;

            Console.WriteLine("Book is :"  + title + " , Pages is : " + pages);

            #endregion

            #region Question 6
            //Build the same sentence as above, but using string interpolation ($"...").

            Console.WriteLine($"Book: {title} , Pages: {pages}");

            #endregion

            #region Question 7 
            //Build the same sentence again, but using string.Format().

            Console.WriteLine(string.Format("Book: {0} , Pages: {1}", title, pages));

            #endregion

            #region Question 8 
            //Given int pages = 464;, write an if / else statement that prints "Long Book" if pages is greater than300, otherwise prints "Short Book".

            if(pages > 300) { Console.WriteLine("Long Book"); }
            else { Console.WriteLine("Short Book"); }

            #endregion

            #region Question 9
            //Given int pages = 464; and bool isAvailable = true;, print "You can borrow this book" only if pages is greater than 300 and isAvailable is true.Use the && operator
            
            bool isAvailable = true;

            if(pages>300 && isAvailable) { Console.WriteLine("You can borrow this book"); }

            #endregion
        }
    }
}
