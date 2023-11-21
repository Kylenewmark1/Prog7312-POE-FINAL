using System;

namespace DeweyDecimalLibrary.Models
{
    // Define a class for representing book objects
    public class BookModel : IComparable<BookModel>
    {
        // Property to store the call number of the book
        public string CallNumber { get; set; }

        // Constructor to initialize the BookModel with a call number
        public BookModel(string callNumber)
        {
            CallNumber = callNumber;
        }

        // Implementation of the IComparable interface to enable sorting of BookModel objects
        public int CompareTo(BookModel other)
        {
            // Compare this book's call number to another book's call number
            return this.CallNumber.CompareTo(other.CallNumber);
        }
    }
}
//--------------------------------------------------------------------Kaylox--------------------------------------------------//   
