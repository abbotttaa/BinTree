using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Tree t = new Tree();

            t.insert(50);
            t.insert(75);
            t.insert(25);
            t.insert(80);
            t.insert(20);
            t.insert(70);
            t.insert(30);
            t.insert(51);
            t.insert(49);
            t.insert(99);
            t.insert(1);

            t.display();
            bool isInTree = t.search(30);
            Console.Write("\n " + isInTree);
            Console.ReadLine();
        }
    }
}
