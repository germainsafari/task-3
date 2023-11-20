// See https://aka.ms/new-console-template for more information
using System;

public class Program
{
    static void Main(string[] args)
    {
        LinkedStateNodes linkedStateNodes = new LinkedStateNodes();
        StateNode node1 = new StateNode(1);
        StateNode node2 = new StateNode(2);
        StateNode node3 = new StateNode(3);
        StateNode node4 = new StateNode(4);
        StateNode node5 = new StateNode(5);
        StateNode node6 = new StateNode(6);
        StateNode node7 = new StateNode(7);
        StateNode node8 = new StateNode(8);
        StateNode node9 = new StateNode(9);

        linkedStateNodes.AddFirst(node1);
        linkedStateNodes.AddLast(node2);
        linkedStateNodes.AddAfter(node1, node3);
        linkedStateNodes.AddFirst(node4);
        linkedStateNodes.AddLast(node5);
        linkedStateNodes.AddLast(node6);
        linkedStateNodes.AddLast(node7);
        linkedStateNodes.AddLast(node8);
        linkedStateNodes.AddLast(node9);
        linkedStateNodes.RemoveLast();
        linkedStateNodes.RemoveAfter(node5);
        Console.WriteLine(linkedStateNodes.GetStateNodeAtIndex(1)?.code); // 1
        linkedStateNodes.PrintAllLinkedStateNodes(); // 4-1-3-2-5-7-8
    }
}

class StateNode
{
    public int code { get; }
    public StateNode? nextStateNode { get; set; }

    public StateNode(int code)
    {
        this.code = code;
        this.nextStateNode = null;
    }
}

class LinkedStateNodes
{
    StateNode? tail, head;
    int length = 0;

    public LinkedStateNodes()
    {
        this.tail = null;
        this.head = null;
    }


    public StateNode? First()
    {
        return head;
    }


    public StateNode? Last()
    {
        return tail;
    }


    public void AddLast(StateNode newStateNode)
    {
        if (tail == null)
        {
            head = newStateNode;
            tail = newStateNode;
        }
        else
        {
            tail.nextStateNode = newStateNode;
            tail = newStateNode;
        }

        length++;
    }

    public void AddFirst(StateNode newStateNode)
    {
        if (head == null)
        {
            head = newStateNode;
            tail = newStateNode;
        }
        else
        {
            newStateNode.nextStateNode = head;
            head = newStateNode;
        }

        length++;
    }


    public void AddAfter(StateNode prevStateNode, StateNode newStateNode)
    {
        StateNode? current = head;
        while (current != null)
        {
            if (current == prevStateNode)
            {
                newStateNode.nextStateNode = current.nextStateNode;
                current.nextStateNode = newStateNode;
                length++;
                if (current == tail)
                    tail = newStateNode;
                break;
            }
            current = current.nextStateNode;
        }
    }


    public StateNode? RemoveFirst()
    {
        if (head == null)
            return null;

        StateNode? removedNode = head;
        head = head.nextStateNode;
        if (head == null)
            tail = null;

        removedNode.nextStateNode = null;
        length--;

        return removedNode;
    }


    public StateNode? RemoveAfter(StateNode prevStateNode)
    {
        StateNode? current = head;
        while (current != null)
        {
            if (current == prevStateNode)
            {
                if (current.nextStateNode == null)
                    return null;

                StateNode? removedNode = current.nextStateNode;
                current.nextStateNode = current.nextStateNode.nextStateNode;
                if (current.nextStateNode == null)
                    tail = current;

                removedNode.nextStateNode = null;
                length--;

                return removedNode;
            }
            current = current.nextStateNode;
        }

        return null;
    }


    public void PrintAllLinkedStateNodes()
    {
        StateNode? current = head;
        while (current != null)
        {
            Console.Write(current.code + "-");
            current = current.nextStateNode;
        }
        Console.WriteLine();
    }


    public StateNode? GetStateNodeAtIndex(int n)
    {
        if (n < 0 || n >= length)
            return null;

        StateNode? current = head;
        int index = 0;
        while (current != null && index < n)
        {
            current = current.nextStateNode;
            index++;
        }

        return current;
    }


    public StateNode? RemoveLast()
    {
        if (tail == null)
            return null;

        if (head == tail)
            return RemoveFirst();

        StateNode? current = head;
        while (current?.nextStateNode != tail)
        {
            current = current?.nextStateNode;
        }

        StateNode? removedNode = tail;
        current.nextStateNode = null;
        tail = current;
        length--;

        return removedNode;
    }
}

