using System;
using System.Collections.Generic;

namespace AlgorithmsDataStructures
{

    public class Node
    {
        public int value;
        public Node next;
        public Node prev;
        public Node(int _value) { value = _value; }
    }

    public class LinkedList
    {
        public Node head;
        public Node tail;

        public LinkedList()
        {
            head = null;
            tail = null;
        }

        public void AddInTail(Node _item)
        {
            if (_item != null) _item.prev = tail ?? head;
            if (head == null) head = _item;
            else              tail.next = _item;
            tail = _item;

            if (_item != null && _item.next != null)
            {
                AddInTail(_item.next);
            }
        }

        public Node Find(int _value)
        {
            Node node = head;
            while (node != null)
            {
                if (node.value == _value) return node;
                node = node.next;
            }
            return null;
        }

        public List<Node> FindAll(int _value)
        {
            List<Node> nodes = new List<Node>();
            Node node = head;
            while (node != null)
            {
                if (node.value == _value) nodes.Add(node);
                node = node.next;
            }
            return nodes;
        }

        public bool Remove(int _value)
        {
            Node prev = null;
            Node node = head;
            while (node != null)
            {
                if (node.value == _value)
                {
                    if (prev == null) head = node.next;
                    else              prev.next = node.next;
                    if (tail == node) tail = tail.prev;
                    return true;
                }
                prev = node;
                node = node.next;
            }
            return false;
        }

        public void RemoveAll(int _value)
        {
            Node prev = null;
            Node node = head;
            while (node != null)
            {
                if (node.value == _value)
                {
                    if (prev == null)
                    {
                        head = node.next; 
                        node = head;
                        tail = node;
                        continue; 
                    }
                    else
                    {
                        prev.next = node.next;
                        node = node.next;
                        continue;
                    }
                }
                tail = node;

                prev = node;
                node = node.next;
            }
        }

        public void Clear()
        {
            head = null;
            tail = null;
        }

        public int Count()
        {
            int count = 0;
            Node node = head;
            while (node != null)
            {
                count ++;
                node = node.next;
            }

            return count;
        }

        public void InsertAfter(Node _nodeAfter, Node _nodeToInsert)
        {
            if (_nodeAfter == null) head = _nodeToInsert;
            else
            {
                Node node = head;
                while (node != null)
                {
                    if (_nodeAfter.value == node.value)
                    {
                        _nodeToInsert.next = node.next;
                        node.next = _nodeToInsert;
                        break;
                    }
                    node = node.next;
                }
            }
        }

        public static LinkedList Merge(LinkedList left, LinkedList right)
        {
            LinkedList result = new LinkedList();
            if (left?.Count() == right?.Count())
            {
                Node l = left.head;
                Node r = right.head;

                while (l != null && r != null)
                {
                    result.AddInTail(new Node(l.value + r.value));
                    
                    l = l.next;
                    r = r.next;
                }
            }

            return result;
        }
    }
}