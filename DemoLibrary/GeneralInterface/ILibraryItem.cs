namespace DemoLibrary.GeneralInterface
{
    /// <summary>
    /// Library item
    /// </summary>
    public interface ILibraryItem
    {
        /// <summary>
        /// Library Id
        /// </summary>
        string LibraryId { get; set; }

        /// <summary>
        /// Title
        /// </summary>
        string Title { get; set; }
    }
}