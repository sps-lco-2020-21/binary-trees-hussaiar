using System;
using System.Collections.Generic;
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
            
            Random r = new Random();

            
            IList<int> numbers = Enumerable.Range(1, 100).Select(i => r.Next(1, 1000)).ToList();
            BinaryTree bt = new BinaryTree();

            foreach (int i in numbers)
                bt.Add(i);

            Console.WriteLine(bt.Depth);

            
            Debug.Assert(numbers.Count == bt.Count, "count is wrong");

            Debug.Assert(numbers.Sum() == bt.Sum, "sum is wrong");

            Console.WriteLine($"The tree has {bt.Count} items.");

            Console.ReadKey();
        }
    }
}
