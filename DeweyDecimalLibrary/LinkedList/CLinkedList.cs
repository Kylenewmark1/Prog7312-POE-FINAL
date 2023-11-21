using System.Collections;

namespace DeweyDecimalLibrary.LinkedList
{
    public class CLinkedList<T> : IEnumerable<T> where T : IComparable<T>
    {
        #region Properties
        public Node<T> Head { get; set; }
        public Node<T> Tail { get; set; }
        public int Size { get; set; }
        #endregion

        public CLinkedList()
        {
            // Initialize the head, tail, and size
            Head = null;
            Tail = null;
            Size = 0;
        }

        // Check if the list is empty
        public bool IsEmpty()
        {
            return Size < 1;
        }

        // Access an item at a specified position in the collection
        public T this[int index]
        {
            get
            {
                // Check if the index is out of range or if the list is empty
                if (index < 0 || index > Size - 1 || Size == 0)
                {
                    throw new IndexOutOfRangeException();
                }
                else
                {
                    if (index == 0)
                    {
                        return Head.Data;
                    }
                    else
                    {
                        if (index == Size - 1)
                        {
                            return Tail.Data;
                        }
                        else
                        {
                            int middle = Size / 2;
                            if (index < middle)
                            {
                                Node<T> current = Head.Next;
                                for (int i = 1; i < index; i++)
                                {
                                    current = current.Next;
                                }
                                return current.Data;
                            }
                            else
                            {
                                Node<T> current = Tail.Previous;
                                for (int i = Size - 2; i > index; i--)
                                {
                                    current = current.Previous;
                                }
                                return current.Data;
                            }
                        }
                    }
                }
            }
        }

        // Add data to the start of the list
        public void Prepend(T data)
        {
            Node<T> n = new Node<T>(data);

            if (Size == 0)
            {
                Head = n;
                Tail = n;
            }
            else
            {
                n.Previous = null;
                n.Next = Head;
                Head.Previous = n;
                Head = n;
            }
            Size++;
        }

        // Add data to the end of the list
        public void Append(T data)
        {
            Node<T> n = new Node<T>(data);

            if (Size == 0)
            {
                Head = n;
                Tail = n;
            }
            else
            {
                n.Next = null;
                n.Previous = Tail;
                Tail.Next = n;
                Tail = n;
            }
            Size++;
        }

        // Traverse the linked list and write the ToString of each node to the console
        public void Traverse(Node<T> n)
        {
            if (n == null)
            {
                return;
            }
            else
            {
                Console.WriteLine(n.Data.ToString());
                Traverse(n.Next);
            }
        }

        // Convert the linked list to a list
        public List<T> ToList()
        {
            List<T> list = new List<T>();
            foreach (T item in this)
            {
                list.Add(item);
            }
            return list;
        }

        #region SORTING
        // QuickSort: Sorts the linked list
        // (Implementation adapted from geeksforgeeks.org)
        // This section implements the QuickSort algorithm for the linked list

        // Find the last node in the linked list
        private Node<T> LastNode(Node<T> node)
        {
            while (node.Next != null)
                node = node.Next;
            return node;
        }

        // Partitioning for QuickSort
        private Node<T> Partition(Node<T> last, Node<T> head)
        {
            T pivot = head.Data;
            Node<T> i = last.Previous;
            T temp;
            for (Node<T> j = last; j != head; j = j.Next)
            {
                if (j.Data.CompareTo(pivot) <= 0)
                {
                    i = i == null ? last : i.Next;
                    temp = i.Data;
                    i.Data = j.Data;
                    j.Data = temp;
                }
            }
            i = i == null ? last : i.Next;
            temp = i.Data;
            i.Data = head.Data;
            head.Data = temp;
            return i;
        }

        // Recursive QuickSort for the linked list
        private void RecursiveQuickSort(Node<T> last, Node<T> head)
        {
            if (head != null && last != head && last != head.Next)
            {
                Node<T> temp = Partition(last, head);
                RecursiveQuickSort(last, temp.Previous);
                RecursiveQuickSort(temp.Next, head);
            }
        }

        // Main QuickSort function for the linked list
        public void QuickSort(Node<T> node)
        {
            Node<T> head = LastNode(node);
            RecursiveQuickSort(node, head);
        }
        #endregion

        #region ENUMERATOR
        // Enumerator for the linked list
        public class LinkedListEnumerator : IEnumerator<T>
        {
            private Node<T> current;

            public LinkedListEnumerator(Node<T> current)
            {
                this.current = current;
            }

            public T Current => current.Data;

            object IEnumerator.Current => Current;

            public bool MoveNext()
            {
                if (current == null)
                {
                    return false;
                }
                else
                {
                    if (current.Next == null)
                    {
                        return false;
                    }
                    current = current.Next;
                    return true;
                }
            }

            public void Dispose()
            {
            }

            public void Reset()
            {
                throw new NotImplementedException();
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            return new LinkedListEnumerator(new Node<T> { Next = Head });
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        #endregion
    }
}
//--------------------------------------------------------------------Kaylox--------------------------------------------------//   
