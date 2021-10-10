using DemoLibrary.GeneralInterface;

namespace DemoLibrary.Book
{
    /// <summary>
    /// Borrowable book
    /// </summary>
    public interface IBorrowableBook : IBorrowable, IBook
    {
    }
}
