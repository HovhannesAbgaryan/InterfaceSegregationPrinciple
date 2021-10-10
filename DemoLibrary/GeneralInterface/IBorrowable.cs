using System;

namespace DemoLibrary.GeneralInterface
{
    /// <summary>
    /// Borrowable
    /// </summary>
    public interface IBorrowable
    {
        #region Properties

        /// <summary>
        /// Borrow date
        /// </summary>
        DateTime BorrowDate { get; set; }

        /// <summary>
        /// Borrower
        /// </summary>
        string Borrower { get; set; }

        /// <summary>
        /// Check out duration in days
        /// </summary>
        int CheckOutDurationInDays { get; set; }

        #endregion Properties

        #region Functions

        /// <summary>
        /// Check in
        /// </summary>
        void CheckIn();

        /// <summary>
        /// Check out
        /// </summary>
        /// <param name="borrower">Borrower</param>
        void CheckOut(string borrower);

        /// <summary>
        /// Get due date
        /// </summary>
        /// <returns>Due date</returns>
        DateTime GetDueDate();

        #endregion Functions
    }
}
