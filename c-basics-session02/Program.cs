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

        }
    }
}
