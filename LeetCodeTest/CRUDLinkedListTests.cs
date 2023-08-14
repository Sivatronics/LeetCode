using NUnit.Framework;
using System;

namespace DoublyLinkedListTests;
[TestFixture]
public class DoublyLinkedListTests
{
    [Test]
    public void TestSetHead()
    {
        var linkedList = new DoublyLinkedList();
        var node = new Node(1);
        linkedList.SetHead(node);
        Assert.AreEqual(node, linkedList.Head);
    }

    [Test]
    public void TestSetTail()
    {
        var linkedList = new DoublyLinkedList();
        var node = new Node(1);
        linkedList.SetTail(node);
        Assert.AreEqual(node, linkedList.Tail);
    }

    [Test]
    public void TestInsertBefore()
    {
        // You'll need to write this test based on the implementation of InsertBefore.
    }

    [Test]
    public void TestInsertAfter()
    {
        // You'll need to write this test based on the implementation of InsertAfter.
    }

    [Test]
    public void TestInsertAtPosition()
    {
        // You'll need to write this test based on the implementation of InsertAtPosition.
    }

    [Test]
    public void TestRemoveNodesWithValue()
    {
        // You'll need to write this test based on the implementation of RemoveNodesWithValue.
    }

    [Test]
    public void TestRemove()
    {
        // You'll need to write this test based on the implementation of Remove.
    }

    [Test]
    public void TestContainsNodeWithValue()
    {
        // Similar to the previous examples
        var linkedList = new DoublyLinkedList();
        var node1 = new Node(1);
        linkedList.Head = node1;
        bool result = linkedList.ContainsNodeWithValue(1);
        Assert.IsTrue(result);
    }

    [Test]
    public void TestCreateALinkedList()
    {
        var ll = new DoublyLinkedList();
        //var intArr = new int[] { 1};
        //var intArr = new int[] { 1,2};
        //var intArr = new int[] { 1,1,1};
        var intArr = new int[] { 1, 2, 3, 4, 5, 6 };
        var linkedList = ll.CreateALinkedList(intArr);
        Assert.AreEqual(intArr[0], linkedList.Head.Value);
        Assert.AreEqual(intArr[intArr.Length - 1], linkedList.Tail.Value);
    }
}

