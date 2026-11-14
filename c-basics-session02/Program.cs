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

            #endregion

        }
    }
}
