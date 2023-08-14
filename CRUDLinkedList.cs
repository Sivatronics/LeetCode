using System;

public class DoublyLinkedList
{
    public Node Head;
    public Node Tail;

    public void SetHead(Node node)
    {

        Head = node;
        // Write your code here.
        //Head. = node;
    }

    public void SetTail(Node node)
    {
        // Write your code here.

    }

    public void InsertBefore(Node node, Node nodeToInsert)
    {
        // Write your code here.
    }

    public void InsertAfter(Node node, Node nodeToInsert)
    {
        // Write your code here.
    }

    public void InsertAtPosition(int position, Node nodeToInsert)
    {
        // Write your code here.
    }

    public void RemoveNodesWithValue(int value)
    {
        // Write your code here.
    }

    public void Remove(Node node)
    {
        // Write your code here.
        //var current = node;
        Console.WriteLine("node value {0}", node.Value);
        if (node.Prev == null)
            Console.WriteLine("head");
        if (node.Next == null)
            Console.WriteLine("tail");
    }

    public bool ContainsNodeWithValue(int value)
    {
        // Write your code here.
        var currentNode = Head;
        while (currentNode != null && currentNode.Value != value)
            currentNode = currentNode.Next;

        return currentNode != null;

    }
    public DoublyLinkedList CreateALinkedList(int[] items)
    {
        var linkedList = new DoublyLinkedList();
        //Node PreviousNode = null;

        for (int i = 0; i < items.Length; i++)
        {
            var newNode = new Node(items[i]);
            if (linkedList.Tail != null)
            {
                linkedList.Tail.Next = newNode;
                newNode.Prev = linkedList.Tail;
            }
            else
            {
                linkedList.Head = newNode;
            }
            linkedList.Tail = newNode;
        }

        return linkedList;
    }
}

// Do not edit the class below.
public class Node
{
    public int Value;
    public Node Prev;
    public Node Next;

    public Node(int value)
    {
        this.Value = value;
    }
}
