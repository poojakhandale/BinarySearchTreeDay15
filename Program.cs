// See https://aka.ms/new-console-template for more information
using BinarySearchTree;

class Program
{
    public static void Main(string[] args)
    {
        {
          BinarySearchTreeDay15 bst = new BinarySearchTreeDay15();
            bst.Insert(56);
            bst.Insert(30);
            bst.Insert(70);

            Console.WriteLine("Inorder Traversal of BST:");
            bst.InorderTraversal(bst.root);
        }
    }
}

