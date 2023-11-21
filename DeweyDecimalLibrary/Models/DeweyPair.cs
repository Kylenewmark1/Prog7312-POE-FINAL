using System;

namespace DeweyDecimalLibrary.Models
{
    // Define a class for representing Dewey Decimal pairs (Number and Description)
    public class DeweyPair : IComparable<DeweyPair>
    {
        // Properties to store the Dewey Decimal Number and its Description
        public string Number { get; set; }
        public string Description { get; set; }

        // Default constructor
        public DeweyPair()
        {
            // You can add any additional initialization logic here if needed
        }

        // Implementation of the IComparable interface to enable sorting of DeweyPair objects
        public int CompareTo(DeweyPair other)
        {
            // Compare this Dewey Decimal Number to another Dewey Decimal Number
            return this.Number.CompareTo(other.Number);
        }
    }
}
//--------------------------------------------------------------------Kaylox--------------------------------------------------//   
