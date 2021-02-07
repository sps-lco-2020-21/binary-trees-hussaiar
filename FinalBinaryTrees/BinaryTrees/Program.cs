using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BinaryTrees.Lib;

namespace BinaryTreesCode.App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Binary Search Tree\n");

            BinaryTree binaryTree = new BinaryTree();

            binaryTree.Add(7);
            binaryTree.Add(6);
            binaryTree.Add(5);

            binaryTree.IsPresent(6);
            Console.WriteLine(binaryTree.depth());
            
            

               

            Console.ReadKey();
        }
    }
}
