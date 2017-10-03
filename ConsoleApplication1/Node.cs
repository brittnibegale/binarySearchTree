using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Node
    {
        public int data;
        public Node leftChild;
        public Node rightChild;
       public Node(int data)
        {
            this.data = data;
            rightChild = null;
            leftChild = null;
        }
       

       

    }
}
