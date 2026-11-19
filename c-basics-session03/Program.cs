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

            #region Question 10 
            //Given string title = "Refactoring";, write a switch statement that prints "Great choice!" if the title is "Clean Code", "Nice pick!" if it's "Refactoring", and "Never heard of it" for anything else

            string title2 = "Refactoring";

            switch(title2)
            {
                case  "Clean Code" :
                    Console.WriteLine("Great choice");
                            break;

                case "Refactoring":
                    Console.WriteLine("Nice pick!");
                    break;

                default: Console.WriteLine("Never heard of it");
                    break;
            }

            #endregion

            #region Question 11 
            //Given int pages = 464;, use the ternary operator to store "Long Book" or "Short Book" into a variable sizeLabel(same rule as question 8: long if pages > 300).

            string sizeLabel = pages > 300 ? "Long Book" : "Short Book";

            Console.WriteLine(sizeLabel);
            #endregion

            #region Question 12 
            //Given string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };, use a for loop to print each book with its position number, like 1.Clean Code.

            string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };

            for (int m = 0; m < books.Length; m++)
            {
                Console.WriteLine($"{m + 1}. {books[m]}");
            }

            #endregion

            #region Question 13 
            //Using the same books array, use a while loop to print every book title.

           int i = 0;

            while (i < books.Length)
            {
                Console.WriteLine(books[i]);
                i++;
            }
            #endregion

            #region Question 14 
            //Write a do-while loop that prints "Checking book..." exactly 3 times.

            int counter = 0;

            do
            {
                Console.WriteLine("Checking book");
                counter++;
            }
            while (counter < 3);
            #endregion

            #region Question 15
            //Using the same books array, use a foreach loop to print every book title.

            foreach (string book in books) 
            {
                Console.WriteLine(book);
            }
            #endregion

            #region Question 16
            //Using the same books array, loop through it and print each title, but stop completely (break) once you reach "Refactoring".
           
            foreach (string book in books)
            {
                if (book == "Refactoring")
                {
                    break;
                }

                Console.WriteLine(book);
            }
            #endregion
        }
    }
}
