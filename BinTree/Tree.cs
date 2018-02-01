using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinTree
{
    class Tree
    {
        private Node root;

        public Tree()
        {
            root = null;

        }
        public bool isEmpty()
        {
            if (root == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void insert(int d)
        {
            if (isEmpty())
            {
                root = new Node(d);
            }
            else
            {
                insertData(ref root, d);
            }
        }

        public bool search(int s)
        {
            return search(root, s);
        }

        public void display()
        {
            if (!isEmpty())
                display(root);
        }

        public void insertData(ref Node node, int data)
        {
            if (node == null)
            {
                node = new Node(data);

            }
            else if (node.item < data)
            {
                insertData(ref node.rightLeaf, data);
            }

            else if (node.item > data)
            {
                insertData(ref node.leftLeaf, data);
            }
        }

        public bool search(Node node, int i)
        {
            if (node == null)
                return false;

            if (node.item == i)
            {
                return true;
            }
            else if (node.item < i)
            {
                return search(node.rightLeaf, i);
            }
            else if (node.item > i)
            {
                return search(node.leftLeaf, i);
            }

            return false;
        }

        public void display(Node n)
        {
            if (n == null)
            {
                return;
            }

            display(n.leftLeaf);
            Console.Write(" " + n.item);
            display(n.rightLeaf);
        }

    }
}

