using System;
using System.Collections.Generic;
public class Node
{
    public int data;
    public Node left, right;
    public Node(int item)
    {
        data = item;
        left = right = null;
    }
}
public class Tree

{
    public Node root;
    public virtual void inorder()//используется для изменения объектов и разрешения их переопределения в производном классе.
    {
        if (root == null)
        {
            return;
        }
        Stack<Node> s = new Stack<Node>();
        Node curr = root;
        while (curr != null || s.Count > 0)
        {
            while (curr != null)
            {
                s.Push(curr);
                curr = curr.left;
            }
           curr = s.Pop();
            Console.Write(curr.data + " ");
            curr = curr.right;
        }
    }
    public static void Main(string[] args)
    {
        Tree tree = new Tree();
        tree.root = new Node(1);
        tree.root.left = new Node(5);
        tree.root.right = new Node(9);
        tree.root.left.left = new Node(14);
        tree.root.left.right = new Node(10);
        tree.inorder();
        Console.ReadKey();
    }
}
