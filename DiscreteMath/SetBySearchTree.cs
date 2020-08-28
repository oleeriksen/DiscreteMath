using System;
namespace DiscreteMath
{
    public class SetBySearchTree : ISet
    {
        Node root;

        public SetBySearchTree()
        {
            root = null;
        }

        public void Add(int v)
        {
            root = Add(root, v);
        }

        private Node Add(Node n, int v) {
            if (n == null) return new Node(v);
            if (n.Value == v) return n;
            if (v < n.Value)
                n.left = Add(n.left, v);
            else
                n.right = Add(n.right, v);
            return n;
        }

        public void All(Action<int> f)
        {
            All(root, f);
           
        }

        private void All(Node n, Action<int> f)
        {
            if (n == null) return;
            All(n.left, f);
            f(n.Value);
            All(n.right, f);
        }

        private bool Contains(Node n, int v)
        {
            if (n == null) return false;
            if (n.Value == v) return true;
            if (v < n.Value)
                return Contains(n.left, v);

            return Contains(n.right, v);
        }

        public bool Contains(int v) {
            return Contains(root, v);
        }


    }

    class Node {

        int value;
        public Node left, right;

        public Node(int v)
        { value = v; }

        public Node(int v, Node l, Node r)
        { value = v; left = l; right = r; }

        public int Value { get { return value; } }


    }
}
