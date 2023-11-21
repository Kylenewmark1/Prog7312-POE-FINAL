using DeweyDecimalLibrary.LinkedList;
using DeweyDecimalLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DeweyDecimalLibrary.Logic
{
    public class ReplacingTheBooks
    {
        #region Generate Game Call Numbers
        public List<string> GenerateCallNos()
        {
            string period = ""; // Declare a string to hold a period value.

            Random rnd = new Random(); // Instantiate a random number generator.

            CLinkedList<BookModel> books = new CLinkedList<BookModel>(); // Initialize a custom linked list to store book models.
            List<string> callnums = new List<string>(); // Initialize a list to store call numbers.

            for (int i = 0; i < 10; i++)
            {
                int number = rnd.Next(1, 1000); // Generate a random number between 1 and 999.

                int reCheck = rnd.Next(1, 11); // Generate a random number between 1 and 10.

                // Check for uniqueness.
                if (reCheck > 4)
                {
                    period = $".{rnd.Next(1, 100)}"; // If the random number is greater than 4, add a period with a random number between 1 and 99.
                }

                string author = RandomString(3); // Generate a random string of length 3.

                // Create a BookModel with a call number composed of a number, period (if applicable), and author.
                BookModel b = new BookModel($"{number.ToString().PadLeft(3, '0')}{period} {author}");

                books.Append(b); // Add the book to the linked list.
            }

            books.QuickSort(books.Head); // Sort the linked list of books using quicksort.

            foreach (BookModel book in books)
            {
                callnums.Add(book.CallNumber); // Iterate through the linked list and add call numbers to the list.
            }

            return callnums;
        }
        #endregion

        #region Generate Random String
        public string RandomString(int size)
        {
            Random rnd = new Random(); // Instantiate a random number generator.

            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"; // Define a character set for generating random strings.

            // Generate a random string of the specified size by selecting random characters from the character set.
            return new string(Enumerable.Repeat(chars, size).Select(s => s[rnd.Next(s.Length)]).ToArray());
        }
        #endregion

        #region Shuffle List
        public List<string> ShuffleList(List<string> myList)
        {
            Random rnd = new Random(); // Instantiate a random number generator.

            // Shuffle the elements of the list by ordering them randomly.
            return myList.OrderBy(item => rnd.Next()).ToList();
        }
        #endregion
    }
}
//--------------------------------------------------------------------Kaylox--------------------------------------------------//   
