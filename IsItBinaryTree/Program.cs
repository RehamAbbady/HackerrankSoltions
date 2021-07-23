using System;
using System.Collections.Generic;

namespace IsItBinaryTree
{
    public class Node
    {
        int data;
        Node left;
        Node right;
        bool checkBST(Node root)
        {
            Stack<Node> stack = new Stack<Node>();
            double left = -Double.MaxValue;
            while (stack.Count == 0 || root != null)
            {
                while (root != null)
                {
                    stack.Push(root);
                    root = root.left;
                }
                root = stack.Pop();
                if (root.data <= left) return false;
                left = root.data;
                root = root.right;
            }
            return true;
        }
    }
    class Program
    {
       
        static void Main(string[] args)
        {

        }
    }
}
//boolean checkBST(Node root)
//{
//    Stack<Node> stack = new Stack();
//    double left = -Double.MAX_VALUE;
//    while (!stack.isEmpty() || root != null)
//    {
//        while (root != null)
//        {
//            stack.push(root);
//            root = root.left;
//        }
//        root = stack.pop();
//        if (root.data <= left) return false;
//        left = root.data;
//        root = root.right;
//    }
//    return true;
//}