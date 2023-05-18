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
            if (head == null) head = _item;
            else tail.next = _item;
            if (_item != null) _item.prev = tail;
            tail = _item;
            
            ///  NOTE [sg]: Disable nested Nodes
            /// if (_item?.next != null) _item.next = null;
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
            var found = Find(_value);
            if (found != null)
            {
                if (found.next == null) tail = found.prev;
                else found.next.prev = found.prev;
                if (found.prev == null) head = found.next;
                else found.prev.next = found.next;
                return true;
            }
            return false;
        }

        public void RemoveAll(int _value)
        {
            Node node = head;
            while (node != null)
            {
                if (node.value == _value)
                {
                    if (node.next == null) tail = node.prev;
                    else node.next.prev = node.prev;
                    if (node.prev == null) head = node.next;
                    else node.prev.next = node.next;
                }
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
                count++;
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