using DemoLibrary.GeneralInterface;
using System.Collections.Generic;

namespace DemoLibrary.Movie
{
    /// <summary>
    /// Movie
    /// </summary>
    public interface IMovie : ILibraryItem
    {
        /// <summary>
        /// Actors
        /// </summary>
        List<string> Actors { get; set; }

        /// <summary>
        /// Runtime in minutes
        /// </summary>
        int RuntimeInMinutes { get; set; }
    }
}
