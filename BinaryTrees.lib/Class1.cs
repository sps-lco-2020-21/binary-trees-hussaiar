using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTrees.Lib
{
    public class BinaryTree
    {
        
        BinaryTreeNode _root;

        public BinaryTree()
        {
            
            
        }

        public BinaryTree(int rootValue)
        {
           
            _root = new BinaryTreeNode(rootValue);
        }

        public void Add(int newValue)
        {
            
            if (_root == null)
                _root = new BinaryTreeNode(newValue);
            else
                _root.Add(newValue);
        }



        public int Count
        {
            get
            { 
                return _root == null ? 0 : _root.Count;
            }
        }
        public int Sum
        {
            get
            {
               
                return _root == null ? 0 : _root.Sum;
            }
        }

        public int Depth
        {
            get
            {
                 
                return _root == null ? 0 : _root.Depth;
            }
        }

        public override string ToString()
        {
            if (_root == null)
                return "count = 0";
            return $"Count = {_root.Count} [Root = {_root}]";
        }
    }

    internal class BinaryTreeNode
    {

        int _value;
        BinaryTreeNode _left;
        BinaryTreeNode _right;

        internal BinaryTreeNode(int value)
        {
            _value = value;

        }

        internal bool Present(int value)
        {
            foreach(BinaryTreeNode in _left)
            {

            }
        }

        internal void Add(int value)
        {
            if (value < _value && _left == null)
            {
                _left = new BinaryTreeNode(value);
                return;
            }
            if (value >= _value && _right == null)
            {
                _right = new BinaryTreeNode(value);
                return;
            }

            (value < _value ? _left : _right).Add(value);

        }

        internal int Count { get { return 1 + (_left == null ? 0 : _left.Count) + (_right == null ? 0 : _right.Count); } }
        internal int Sum { get { return _value + (_left == null ? 0 : _left.Sum) + (_right == null ? 0 : _right.Sum); } }

        internal int Depth
        {
            get
            {
                if (_left == null && _right == null)
                    return 1;
                int l = _left == null ? 0 : _left.Depth;
                int r = _right == null ? 0 : _right.Depth;
                return 1 + System.Math.Max(l, r);
            }
        }

        public override string ToString()
        {
            return $"Value = {_value}";
        }
    }
    
}
