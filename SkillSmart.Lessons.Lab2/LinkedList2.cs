﻿using System;
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

    public class LinkedList2
    {
        public Node head;
        public Node tail;

        public LinkedList2()
        {
            head = null;
            tail = null;
        }

        public void AddInTail(Node _item)
        {
            if (head == null)
            {
                head = _item;

                if (_item != null)
                {
                    head.prev = null;
                    head.next = null;
                }
            }
            if (tail != null)
            {
                tail.next = _item;
            }
            if (_item != null)
            {
                _item.prev = tail;
            }
            tail = _item;
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
            if (_nodeAfter == null)
            {
                if (head != null) head.prev = _nodeToInsert;
                _nodeToInsert.next = head;
                head = _nodeToInsert;

                if (tail == null) tail = _nodeToInsert;
            }
            else
            {
                if (_nodeAfter.next != null)
                    _nodeAfter.next.prev = _nodeToInsert;

                _nodeToInsert.next = _nodeAfter.next;
                _nodeToInsert.prev = _nodeAfter;

                _nodeAfter.next = _nodeToInsert;
            }
            if (tail == _nodeAfter) tail = _nodeToInsert;
        }

        public static LinkedList2 Merge(LinkedList2 left, LinkedList2 right)
        {
            LinkedList2 result = new LinkedList2();

            if (left?.Count() > 0 && right?.Count() > 0 && left.Count() == right.Count())
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