using DemoLibrary.GeneralInterface;

namespace DemoLibrary.Book
{
    /// <summary>
    /// Book
    /// </summary>
    public interface IBook : ILibraryItem
    {
        /// <summary>
        /// Author
        /// </summary>
        string Author { get; set; }

        /// <summary>
        /// Pages
        /// </summary>
        int Pages { get; set; }
    }
}
