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
            binarySearchTree.display();

            bool resutl = binarySearchTree.IFExits(63, binarySearchTree);
            Console.WriteLine("\n result:" + resutl);
            
            binarySearchTree.GetSize();

            Console.ReadLine();
        }
    }
}
