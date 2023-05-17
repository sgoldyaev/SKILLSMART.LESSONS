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
            // здесь будет ваш код поиска всех узлов по заданному значению
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
            // здесь будет ваш код удаления одного узла по заданному значению
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
            return false; // если узел был удалён
        }

        public void RemoveAll(int _value)
        {
            // здесь будет ваш код удаления всех узлов по заданному значению
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
                        tail = tail.prev;
                        continue; 
                    }
                    else
                    {
                        prev.next = node.next;
                    }
                }
                prev = node;
                node = node.next;
            }
        }

        public void Clear()
        {
            // здесь будет ваш код очистки всего списка
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

            return count; // здесь будет ваш код подсчёта количества элементов в списке
        }

        public void InsertAfter(Node _nodeAfter, Node _nodeToInsert)
        {
            // здесь будет ваш код вставки узла после заданного

            // если _nodeAfter = null , 
            // добавьте новый элемент первым в списке 
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

    }
}