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
                int result = num2 / num1;
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

        }
    }
}
