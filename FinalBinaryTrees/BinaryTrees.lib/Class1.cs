using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTrees.Lib
{
    public class TreeNode
    {  
        private int data;
        public int Data
        {
            get { return data; }
        }

        private TreeNode rightNode;
        public TreeNode RightNode
        {
            get { return rightNode; }
            set { rightNode = value; }
        }

        private TreeNode leftNode;
        public TreeNode LeftNode
        {
            get { return leftNode; }
            set { leftNode = value; }
        }

       

        
        public TreeNode(int value)
        {
            data = value;
        }

        
        

        public TreeNode IsPresent(int value)
        {
            
            TreeNode currentNode = this;

          
            while (currentNode != null)
            {
               
                if (value == currentNode.data )
                {
                    Console.WriteLine("Value is present");
                    return currentNode; //if the value whose presence is being checked is returned then it is present.
                    
                }
                else if (value > currentNode.data)
                {
                    currentNode = currentNode.rightNode;
                }
                else
                {
                    currentNode = currentNode.leftNode;
                }
            }
            Console.WriteLine("Value is not present");
            return null; //if null is returned then the value is not present within the binary tree.
        }

        


        
        public void Add(int value)
        {
            
            if (value >= data)
            {   
                if (rightNode == null)
                {
                    rightNode = new TreeNode(value);
                }
                else
                {
                    rightNode.Add(value);
                }
            }
            else
            {
                if (leftNode == null)
                {
                    leftNode = new TreeNode(value);
                }
                else
                {
                    leftNode.Add(value);
                }
            }
        }

        public Nullable<int> SmallestValue()
        {
            
            if (leftNode == null)
            {
                return data;
            }
            else
            {
                return leftNode.SmallestValue();
            }
        }

        internal Nullable<int> LargestValue()
        {  
            if (rightNode == null)
            {
                return data;
            }
            else
            {
                return rightNode.LargestValue();
            }
        }

        


        public int depth()
        {
           
            if (this.leftNode == null && this.rightNode == null)
            {
                return 1; 
            }

            int left = 0;
            int right = 0;

            
            if (this.leftNode != null)
                left = this.leftNode.depth();
            if (this.rightNode != null)
                right = this.rightNode.depth();

            
            if (left > right)
            {
                return (left + 1);
            }
            else
            {
                return (right + 1);
            }

        }

        

        
    }





    public class BinaryTree
    {
        private TreeNode root;
        public TreeNode Root
        {
            get { return root; }
        }


        
        public TreeNode IsPresent(int data)
        {
            
            if (root != null)
            {
               
                return root.IsPresent(data);
            }
            else
            {
                return null;
            }
        }

      
       
        
        public void Add(int data)
        {
            
            if (root != null)
            {
                root.Add(data);
            }
            else
            {
                root = new TreeNode(data);
            }
        }

       
        public void Remove(int data)
        {
          
            TreeNode current = root;
            TreeNode parent = root;
            bool isLeftChild = false;

           
            if (current == null)
            {
                return;
            }

            
            while (current != null && current.Data != data)
            {
               
                parent = current;

                
                if (data < current.Data)
                {
                    current = current.LeftNode;
                    isLeftChild = true;
                }
                else
                {
                    current = current.RightNode;
                    isLeftChild = false;
                }
            }

            
            if (current == null)
            {
                return;
            }

            
            if (current.RightNode == null && current.LeftNode == null)
            {
                
                if (current == root)
                {
                    root = null;
                }
                else
                {
                   
                    if (isLeftChild)
                    {
                       
                        parent.LeftNode = null;
                    }
                    else
                    {  
                        parent.RightNode = null;
                    }
                }
            }
            else if (current.RightNode == null)
            {
               
                if (current == root)
                {
                    root = current.LeftNode;
                }
                else
                {
                   
                    if (isLeftChild)
                    {
                        
                        parent.LeftNode = current.LeftNode;
                    }
                    else
                    {   
                        parent.RightNode = current.LeftNode;
                    }
                }
            }
            else if (current.LeftNode == null)
            {
                
                if (current == root)
                {
                    root = current.RightNode;
                }
                else
                {
                    
                    if (isLeftChild)
                    { 
                        parent.LeftNode = current.RightNode;
                    }
                    else
                    {   
                        parent.RightNode = current.RightNode;
                    }
                }
            }
            else
            {
               
                TreeNode successor = GetSuccessor(current);
               
                if (current == root)
                {
                    root = successor;
                }
                else if (isLeftChild)
                {
                    parent.LeftNode = successor;
                }
                else
                {
                    parent.RightNode = successor;
                }

            }

        }

        private TreeNode GetSuccessor(TreeNode node)
        {
            TreeNode parentOfSuccessor = node;
            TreeNode successor = node;
            TreeNode current = node.RightNode;

          
            while (current != null)
            {
                parentOfSuccessor = successor;
                successor = current;
                current = current.LeftNode;
            }
          
            if (successor != node.RightNode)
            {
               
                parentOfSuccessor.LeftNode = successor.RightNode;
                
                successor.RightNode = node.RightNode;
            }
           
            successor.LeftNode = node.LeftNode;

            return successor;
        }
        

        

       
        public Nullable<int> Smallest()
        {
            
            if (root != null)
            {
                return root.SmallestValue();
            }
            else
            {
                return null;
            }
        }

        
        public Nullable<int> Largest()
        {
          
            if (root != null)
            {
                return root.LargestValue();
            }
            else
            {
                return null;
            }
        }




        public int depth()
        {
            
            if (root == null)
            { return 0; }

            return root.depth();
        }


       
        






    }
}
