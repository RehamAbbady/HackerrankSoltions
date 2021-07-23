using System;

namespace LowestCommonAncestor
{
    class Node
    {
        int data;
        Node left;
        Node right;

        public Node(int data)
        {
            this.data = data;
        }

        public static Node insert(Node root, int data)
        {
            if (root == null)
            {
                return new Node(data);
            }
            else
            {
                Node cur;
                if (data <= root.data)
                {
                    cur = insert(root.left, data);
                    root.left = cur;
                }
                else
                {
                    cur = insert(root.right, data);
                    root.right = cur;
                }
                return root;
            }
        }
        public static Node lca(Node root, int v1, int v2)
        {
            if (v1 > root.data && v2 > root.data)
                return lca(root.right, v1, v2);
            if (v1 < root.data && v2 < root.data)
                return lca(root.left, v1, v2);

            return root;
        }
        static void Main(string[] args)
        {
        }
    }

}
