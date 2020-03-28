using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    public class Tree<TItem> where TItem : IComparable<TItem>
    {
        public TItem NodeData { get; set; }
        public Tree<TItem> LeftTree { get; set; }
        public Tree<TItem> RightTree { get; set; }

        public Tree(TItem nodeValue)
        {
            this.NodeData = nodeValue;
            this.LeftTree = null;
            this.RightTree = null;
        }

        public void Insert(TItem newItem) //TItem is the value type 
        {
            TItem currentNodeValue = this.NodeData; // implements method 
            if (currentNodeValue.CompareTo(newItem) > 0)
            {
                // Insert the item into the left subtree
                if (LeftTree == null)
                    LeftTree = new Tree<TItem>(newItem);
                else
                    LeftTree.Insert(newItem);
            }
            else
            {
                if (RightTree == null)
                    RightTree = new Tree<TItem>(newItem);
                else
                   RightTree.Insert(newItem);
            }
        }
        // when you write a recurssive method you have to decide the stopping point and tell it what to do 

        public string WalkTree()
        {
            string result = "";

            if (this.LeftTree != null)
                result = this.LeftTree.WalkTree();

            result += $" {this.NodeData.ToString()} ";

            if (this.RightTree != null)
                result += this.RightTree.WalkTree();
            return result;
        }

    }
}
