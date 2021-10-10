using System;

namespace DemoLibrary.AudioBook
{
    /// <summary>
    /// Audio book
    /// </summary>
    public class AudioBook : IBorrowableAudioBook
    {
        #region Properties

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
        /// Check out duration in days
        /// </summary>
        public int CheckOutDurationInDays { get; set; } = 14;

        /// <summary>
        /// Borrower
        /// </summary>
        public string Borrower { get; set; }

        /// <summary>
        /// Borrow date
        /// </summary>
        public DateTime BorrowDate { get; set; }

        /// <summary>
        /// Runtime in minutes
        /// </summary>
        public int RuntimeInMinutes { get; set; }

        #endregion Properties

        #region Functions

        /// <summary>
        /// Check out
        /// </summary>
        /// <param name="borrower">Borrower</param>
        public void CheckOut(string borrower)
        {
            if (string.IsNullOrEmpty(borrower))
                throw new ArgumentNullException("Borrower is null or empty");

            Borrower = borrower;
            BorrowDate = DateTime.Now;
        }

        /// <summary>
        /// Check in
        /// </summary>
        public void CheckIn()
        {
            Borrower = "";
        }

        /// <summary>
        /// Get due date
        /// </summary>
        /// <returns>Due date</returns>
        public DateTime GetDueDate()
        {
            return BorrowDate.AddDays(CheckOutDurationInDays);
        }

        #endregion Functions
    }
}
