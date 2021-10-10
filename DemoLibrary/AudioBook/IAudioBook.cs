using DemoLibrary.GeneralInterface;

namespace DemoLibrary.AudioBook
{
    /// <summary>
    /// Audio book
    /// </summary>
    public interface IAudioBook : ILibraryItem
    {
        /// <summary>
        /// Runtime in minutes
        /// </summary>
        int RuntimeInMinutes { get; set; }
    }
}
