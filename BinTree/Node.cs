using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinTree
{
    class Node
    {
        public int item;
        public Node rightLeaf;
        public Node leftLeaf;

        public Node(int value)
        {
            item = value;
            rightLeaf = null;
            leftLeaf = null;
        }
    }
}
