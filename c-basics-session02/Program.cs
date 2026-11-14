using System.Runtime.Intrinsics.X86;

namespace c_basics_session02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question 1
            //Create a Book class with a Title (string) and Pages (int). Create a Book object and store it in a variable of type object.Print it

            Book book1 = new Book();

            book1.Title = "Test";
            book1.Pages = 464;

            object mahmoud_book = book1;

            Console.WriteLine(mahmoud_book);
            #endregion

            #region Question 2 
            //Using the Book class above, print the result of calling ToString(), Equals() (compare book with itself), GetHashCode(), and GetType() on book.

            Console.WriteLine(book1.ToString());
            Console.WriteLine(book1.Equals(book1));
            Console.WriteLine(book1.GetHashCode());
            Console.WriteLine(book1.GetType());
            #endregion

            #region Question 3 
            //Look at the line below. Is it a compile-time error, a runtime error, or a logical error? Fix it.int pages = "464";
            //Compile-time Error

            int pages = 464;
            Console.WriteLine(pages);

            #endregion

            #region Question 4
            //Write code that divides 10 by 0 inside a try block, catches the exception, prints "Cannot divide by zero", and then prints "Done" in a finally block.

            int num1 = 0;
            int num2 = 10;
            try
            {
                int result_ = num2 / num1;
            }

            catch
            {
                Console.WriteLine("Cannot divide by zero");

            }
            finally
            {
                Console.WriteLine("Done");
            }

            #endregion

            #region Question 5 
            //Q05. Declare an int pages = 300; then store it in a double variable without using a cast.

            int Pages = 300;
            double Pages2 = Pages;
            Console.WriteLine(Pages2);

            #endregion

            #region Question 6

            //Q06. Declare a double price = 49.99; then convert it into an int using a cast.
            double price = 49.99;
            int price2 = (int)price;
            Console.WriteLine(price2);

            #endregion

            #region Question 7
            //Q07. Given string pagesText = "464";, convert it into an int using the Convert class.

            string pagesText = "464";
            int pagesText2 = Convert.ToInt32(pagesText);
            Console.WriteLine(pagesText2);
            #endregion

            #region Question 8
            //Given string yearText = "2023";, convert it using int.Parse(). Then given string badText = "abc"; use int.TryParse() to safely try converting it, and print "Invalid number" if it fails.

            string yearText = "2023";
            int yearText2 = int.Parse(yearText);
            Console.WriteLine(yearText2);


            string badText = "abc";

            bool result = int.TryParse(badText, out int badText2);

            if (result == false)
            {
                Console.WriteLine("Invalid number");
            }



            #endregion

            #region Question 9 
            // Given int pages = 464;, convert it into a string using ToString() and print its type using GetType() to prove it's now a string.

            string convertPages = pages.ToString();
            Console.WriteLine(convertPages);
            Console.WriteLine(convertPages.GetType());

            #endregion

            #region Question 10
            //Declare int copies = 100;. Box it into an object variable, then unbox it back into a new int variable, and print both.

            int copies = 100;

            object obj = copies;
            int copies2 = (int)obj;

            Console.WriteLine(copies);
            Console.WriteLine(copies2);

            #endregion

            #region Question 11
            //Q11. Declare an int? year = null;. Print whether it has a value, then assign it 2023 and print its value.

            int? year = null;

            Console.WriteLine(year.HasValue);

            year = 2023;

            Console.WriteLine(year.Value);

            #endregion
        }
    }
}
