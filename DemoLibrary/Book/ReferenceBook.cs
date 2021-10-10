namespace DemoLibrary.Book
{
    /// <summary>
    /// Reference book
    /// </summary>
    public class ReferenceBook : IBook
    {
        /// <summary>
        /// Library Id
        /// </summary>
        public string LibraryId { get; set; }

        /// <summary>
        /// Title
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Author
        /// </summary>
        public string Author { get; set; }

        /// <summary>
        /// Pages
        /// </summary>
        public int Pages { get; set; }
    }
}
