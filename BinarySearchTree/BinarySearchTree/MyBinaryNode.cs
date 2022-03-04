using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    internal class MyBinaryNode<T> where T : IComparable<T>
    {
        public T nodeData { get; set; }
        public MyBinaryNode<T> leftTree { get; set; }
        public MyBinaryNode<T> rightTree { get; set; }
        public MyBinaryNode(T nodeData)
        {
            this.nodeData = nodeData;
            this.leftTree = null;
            this.rightTree = null;
        }
       public int leftCount = 0, rightCount = 0;
        public void Insert(T data)
        {
            T currentNodeValue = nodeData;
            if ((data.CompareTo(currentNodeValue)) < 0)
            {
                if (this.leftTree == null)
                {
                    this.leftTree = new MyBinaryNode<T>(data);
                }
                else
                    this.leftTree.Insert(data);
            }
            else
            {
                if (this.rightTree == null)
                {
                    this.rightTree = new MyBinaryNode<T>(data);
                }
                else
                    this.rightTree.Insert(data);
            }
        }
        public void Display()
        {
            if (this.leftTree != null)
            {
                this.leftCount++;
                this.leftTree.Display();
            }
            Console.Write(this.nodeData.ToString() + " ");
            if (this.rightTree != null)
            {
               this.rightCount++;
                this.rightTree.Display();
            }
        }
        public void GetSize()
        {
            Console.WriteLine("\nSize of Binary Tree is: " + (this.leftCount + this.rightCount + 1));
        }

    }
}
