using System.Drawing;
using System;
using System.Security.Cryptography;
using System.Text;

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
        }
    }
}
