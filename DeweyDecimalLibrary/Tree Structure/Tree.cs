using System;
using System.Collections.Generic;

namespace DeweyDecimalLibrary.Tree_Structure
{
    /// <summary>
    /// Represents a binary tree data structure with nodes of type T, where T must be comparable.
    /// </summary>
    /// <typeparam name="T">The type of data stored in each node, must be comparable.</typeparam>
    public class Tree<T> where T : IComparable<T>
    {
        // Property to store the root node of the tree.
        public TreeNode<T> Root { get; set; }

        // Property to store the size of the tree.
        public int Size { get; set; }

        /// <summary>
        /// Default constructor for the Tree class.
        /// </summary>
        public Tree() { }

        /// <summary>
        /// Overloaded constructor for the Tree class with initial data for the root node.
        /// </summary>
        /// <param name="data">The data for the root node.</param>
        public Tree(T data)
        {
            Root = new TreeNode<T>(data);
            Size++;
        }

        /// <summary>
        /// Performs an order traversal of the tree starting from the specified node.
        /// </summary>
        /// <param name="start">The starting node for the traversal.</param>
        public void OrderTraversal(TreeNode<T> start)
        {
            Queue<TreeNode<T>> queue = new Queue<TreeNode<T>>();
            queue.Enqueue(start);

            while (queue.Count != 0)
            {
                TreeNode<T> current = queue.Dequeue();

                foreach (TreeNode<T> child in current.Children)
                {
                    queue.Enqueue(child);
                }
            }
        }

        /// <summary>
        /// Searches for a node with the specified data in the binary tree.
        /// </summary>
        /// <param name="data">The data to search for.</param>
        /// <returns>The found node or null if not found.</returns>
        public TreeNode<T> SearchThrough(T data)
        {
            Queue<TreeNode<T>> queue = new Queue<TreeNode<T>>();
            queue.Enqueue(this.Root);

            while (queue.Count != 0)
            {
                TreeNode<T> current = queue.Dequeue();

                if (current.Data.Equals(data))
                {
                    return current;
                }

                foreach (TreeNode<T> child in current.Children)
                {
                    queue.Enqueue(child);
                }
            }
            return null;
        }

        /// <summary>
        /// Adds a list of children with the specified parent data to the binary tree structure.
        /// </summary>
        /// <param name="lstChildren">The list of children data to add.</param>
        /// <param name="parentData">The data of the parent node.</param>
        public void AddChildren(List<T> lstChildren, T parentData)
        {
            TreeNode<T> parent = SearchThrough(parentData);

            if (parent == null)
            {
                return;
            }
            else
            {
                foreach (T item in lstChildren)
                {
                    parent.AddChild(item);
                    Size++;
                }
            }
        }

        /// <summary>
        /// Gets a list representing the path to a randomly selected node at a specified level.
        /// </summary>
        /// <param name="start">The starting node for the path.</param>
        /// <param name="limit">The maximum depth of the path.</param>
        /// <returns>A list representing the path to a randomly selected node.</returns>
        public List<T> GetPathToRandom(TreeNode<T> start, int limit)
        {
            List<T> lstPath = new List<T>();
            return PathToRandom(start, 0, lstPath, limit);
        }

        /// <summary>
        /// Recursively generates a path to a randomly selected node at a specified level.
        /// </summary>
        /// <param name="start">The starting node for the path.</param>
        /// <param name="count">The current depth in the path.</param>
        /// <param name="path">The current path being generated.</param>
        /// <param name="limit">The maximum depth of the path.</param>
        /// <returns>A list representing the path to a randomly selected node.</returns>
        private List<T> PathToRandom(TreeNode<T> start, int count, List<T> path, int limit)
        {
            if (start.Children.Count < 1 || count >= limit)
            {
                return path;
            }
            else
            {
                TreeNode<T> current = start;

                Random r = new Random();
                int index = r.Next(current.Children.Count);

                path.Add(current.Children[index].Data);
                current = current.Children[index];

                count++;

                return PathToRandom(current, count, path, limit);
            }
        }

        /// <summary>
        /// Gets the data of a randomly selected node at the specified level.
        /// </summary>
        /// <param name="level">The level at which to select a random node.</param>
        /// <returns>The data of the randomly selected node.</returns>
        public T GetRandom(int level)
        {
            TreeNode<T> current = Root;

            for (int i = 0; i < level; i++)
            {
                Random r = new Random();
                int index = r.Next(current.Children.Count);

                current = current.Children[index];
            }
            return current.Data;
        }

        /// <summary>
        /// Gets the data of the children of a specified parent node.
        /// </summary>
        /// <param name="parent">The data of the parent node.</param>
        /// <returns>A list of data representing the children of the parent node.</returns>
        public List<T> GetChildren(T parent)
        {
            TreeNode<T> p = SearchThrough(parent);

            if (p != null)
            {
                List<T> response = new List<T>();
                p.Children.ForEach(x => response.Add(x.Data));
                return response;
            }
            else
            {
                return null;
            }
        }
    }
}
//--------------------------------------------------------------------Kaylox--------------------------------------------------//   
