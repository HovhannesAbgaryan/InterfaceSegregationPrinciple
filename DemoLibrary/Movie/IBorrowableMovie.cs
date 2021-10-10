using DemoLibrary.GeneralInterface;

namespace DemoLibrary.Movie
{
    /// <summary>
    /// Borrowable movie
    /// </summary>
    public interface IBorrowableMovie : IBorrowable, IMovie
    {
    }
}
