using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeweyDecimalLibrary.Tree_Structure
{
    /// <summary>
    /// Represents a node in a tree data structure.
    /// </summary>
    /// <typeparam name="T">The type of data stored in the node.</typeparam>
    public class TreeNode<T>
    {
        // Property to store the data of the node.
        public T Data { get; set; }

        // List to store child nodes.
        public List<TreeNode<T>> Children { get; set; }

        /// <summary>
        /// Default constructor for the TreeNode class.
        /// </summary>
        public TreeNode()
        {
            Children = new List<TreeNode<T>>();
        }

        /// <summary>
        /// Constructor with data parameter for the TreeNode class.
        /// </summary>
        /// <param name="data">The data to be stored in the node.</param>
        public TreeNode(T data)
        {
            Data = data;
            Children = new List<TreeNode<T>>();
        }

        /// <summary>
        /// Adds a child node with the specified data to the current node.
        /// </summary>
        /// <param name="data">The data for the child node.</param>
        public void AddChild(T data)
        {
            this.Children.Add(new TreeNode<T>(data));
        }
    }
}
//--------------------------------------------------------------------Kaylox--------------------------------------------------//   
