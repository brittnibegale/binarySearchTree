using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class BinarySearchTree
    {
        private Node root;

        public BinarySearchTree()
        {
            root = null;
        }
        public Node Root
        {
            get
            {
                return root;
            }
            set
            {
                root = value;
            }
        }

        public void Insert(int number)
        {
            Node newNode = new Node(number);
            if (root == null)
            {
                this.root = newNode;
            }
            else
            {
                Node current = root;
                while (true)
                {
                    Node tempParent = current;         
                    if (tempParent.data < number)
                    {
                        current = current.rightChild;
                        if(current == null)
                        {
                            tempParent.rightChild = newNode;
                            return;
                        }

                    }
                    else if (tempParent.data > number)
                    {
                        current = current.leftChild;
                        if(current == null)
                        {
                            tempParent.leftChild = newNode;
                            return;
                        }
                    }
                }
            }
        }

        public void Search(int number)
        {
            if(root == null)
            {
                Console.WriteLine("There is not a tree to search");
            }
            else
            {
                Node current = root;
                while (true)
                {
                    Node tempParent = current;
                    if (tempParent.data < number)
                    {
                        current = current.rightChild;
                        if (current == null)
                        {
                            Console.WriteLine(number + " is not in the tree.");
                            return;
                        }
                        else if (current.data == number)
                        {
                            Console.WriteLine("The tree contains " + number + ".");
                            return;
                        }
                    }
                    else if (tempParent.data > number)
                    {
                        current = current.leftChild;
                        if (current == null)
                        {
                            Console.WriteLine(number + " is not in the tree.");
                            return;
                        }
                        else if(current.data == number)
                        {
                            Console.WriteLine("The tree contains " + number + ".");
                            return;
                        }
                    }
                }
            }
        }

        
        
       
    }
}
