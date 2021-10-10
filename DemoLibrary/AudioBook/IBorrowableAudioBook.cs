using DemoLibrary.GeneralInterface;

namespace DemoLibrary.AudioBook
{
    /// <summary>
    /// Borrowable audio book
    /// </summary>
    public interface IBorrowableAudioBook : IBorrowable, IAudioBook
    {
    }
}
