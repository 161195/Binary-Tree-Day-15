using System;

namespace BinaryTreeDay15
{
    class Program
    {
        static void Main(string[] args)
        {
            createBST<int> binarySearchTree = new createBST<int>(56);
            binarySearchTree.Insert(30);
            binarySearchTree.Insert(70);
            binarySearchTree.Insert(20);
            binarySearchTree.Insert(50);
            binarySearchTree.Insert(60);
            binarySearchTree.Insert(80);
            binarySearchTree.display();
            binarySearchTree.GetSize();

            Console.ReadLine();
        }
    }
}
