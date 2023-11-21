namespace DeweyDecimalLibrary.LinkedList
{
    public class Node<T>
    {
        public Node<T> Next { get; set; }       // Reference to the next node in the list.
        public Node<T> Previous { get; set; }   // Reference to the previous node in the list.
        public T Data { get; set; }             // The data stored in the node.

        // Default constructor (no-argument constructor)
        public Node() { }

        // Constructor that initializes the node with data
        public Node(T n)
        {
            Next = null;      // By default, set the Next reference to null.
            Previous = null;  // By default, set the Previous reference to null.
            Data = n;         // Initialize the node's data with the provided value 'n'.
        }
    }
}
//--------------------------------------------------------------------Kaylox--------------------------------------------------//   
