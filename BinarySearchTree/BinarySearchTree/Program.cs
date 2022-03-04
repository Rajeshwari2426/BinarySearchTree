using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Binary Search Tree program");
            MyBinaryNode<int> binaryTree = new MyBinaryNode<int>(56);
            start:
            Console.WriteLine("Please choose an option:");
            Console.WriteLine("\n1. Create Binary Search Tree  \n2. Check Size of BST\n3.Search Element67");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    binaryTree.Insert(30);
                    binaryTree.Insert(70);
                    binaryTree.Display();
                    break;
                case 2:
                    binaryTree.Insert(30);
                    binaryTree.Insert(70);
                    binaryTree.Insert(22);
                    binaryTree.Insert(40);
                    binaryTree.Insert(60);
                    binaryTree.Insert(95);
                    binaryTree.Insert(11);
                    binaryTree.Insert(65);
                    binaryTree.Insert(3);
                    binaryTree.Insert(16);
                    binaryTree.Insert(6);
                   binaryTree.Insert(67);
                    binaryTree.Display();
                    binaryTree.GetSize();
                    break;
                    case 3:
                    binaryTree.Insert(30);
                    binaryTree.Insert(70);
                    binaryTree.Insert(22);
                    binaryTree.Insert(40);
                    binaryTree.Insert(60);
                    binaryTree.Insert(95);
                    binaryTree.Insert(11);
                    binaryTree.Insert(65);
                    binaryTree.Insert(3);
                    binaryTree.Insert(16);
                    binaryTree.Insert(6);
                    binaryTree.Insert(67);
                    int search = 67;
                    bool result = binaryTree.IfExists(search, binaryTree);
                    if (result == true)
                        Console.WriteLine("{0} is present in the Binary Search Tree", search);
                    else
                        Console.WriteLine("{0} is not present in the Binary Search Tree", search);
                    break;
                default:
                    Console.WriteLine("Please select the correct option");
                    goto start;
            }
                    Console.ReadLine();
        }
    }
}
