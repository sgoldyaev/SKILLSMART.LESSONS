using System;
using System.Collections.Generic;

namespace AlgorithmsDataStructures
{

    public class Node<T>
    {
        public T value;
        public Node<T> next, prev;

        public Node(T _value)
        {
            value = _value;
            next = null;
            prev = null;
        }
    }

    public class OrderedList<T>
    {
        public Node<T> head, tail;
        private bool ascending;
        private int leftGtRight;

        public OrderedList(bool asc)
        {
            head = null;
            tail = null;

            ascending = asc;
            leftGtRight = ascending ? 1 : -1;
        }

        public int Compare(T leftValue, T rightValue)
        {
            var comparision = 0;
            
            if (typeof(T) == typeof(String))
            {
                var leftValueAsString = leftValue?.ToString();
                var rightValueAsString = rightValue?.ToString();

                comparision = string.Compare(leftValueAsString?.Trim(), rightValueAsString?.Trim(), StringComparison.InvariantCulture);
            }
            else if (typeof(IComparable).IsAssignableFrom(typeof(T)))
            {
                var leftValueAsComparable = leftValue as IComparable;
                var rightValueAsComparable = rightValue as IComparable;
                comparision = leftValueAsComparable.CompareTo(rightValueAsComparable);
            }

            return comparision;
            // -1 если v1 < v2
            // 0 если v1 == v2
            // +1 если v1 > v2
        }

        public void Add(T value)
        {
            var newNode = new Node<T>(value);

            if (head == null)
            {
                head = newNode;
                tail = newNode;

                return;
            }

            var isLThead = Compare(head.value, newNode.value) == leftGtRight;

            if (isLThead)
            {
                newNode.next = head;
                head.prev = newNode;

                head = newNode;

                return;
            }

            var isGTtail = Compare(newNode.value, tail.value) == leftGtRight;

            if (isGTtail)
            {
                newNode.prev = tail;
                tail.next = newNode;

                tail = newNode;

                return;
            }

            Node<T> nextNode = head;
            while (nextNode != null)
            {
                var isGTEnext = Compare(nextNode.value, newNode.value) != leftGtRight;
                var isLTEafterNext = Compare(newNode.value, nextNode.next.value) != leftGtRight;
                var isTail = nextNode.next == null;
                
                if (isGTEnext && (isTail || isLTEafterNext))
                {
                    newNode.prev = nextNode;
                    newNode.next = nextNode.next;
                    
                    nextNode.next.prev = newNode;
                    nextNode.next = newNode;

                    if (nextNode == tail)
                    {
                        tail = newNode;
                    }

                    break;
                }

                nextNode = nextNode.next;
            }
;       }

        public Node<T> Find(T val)
        {
            if (head == null && tail == null)
            {
                return default;
            }

            /// NOTE [sg]: 5. skip connection
            if (Compare(head.value, val) == leftGtRight || Compare(val, tail.value) == leftGtRight)
            {
                return default;
            }

            Node<T> nextNode = head;
            while (nextNode != null)
            {
                if (Compare(val, nextNode.value) == 0)
                {
                    return nextNode;
                }

                nextNode = nextNode.next;
            }

            return default;
        }

        public void Delete(T val)
        {
            Node<T> foundNode = Find(val);
            if (foundNode != null)
            {
                if (foundNode.next != null && foundNode.prev != null)
                {
                    foundNode.next.prev = foundNode.prev;
                    foundNode.prev.next = foundNode.next;
                }

                if (foundNode.prev == null)
                {
                    head = foundNode.next;

                    if (foundNode.next != null) foundNode.next.prev = null;
                }

                if (foundNode.next == null)
                {
                    tail = foundNode.prev;

                    if (foundNode.prev != null) foundNode.prev.next = null;
                }
            }
        }

        public void Clear(bool asc)
        {
            head = null;
            tail = null;
            
            ascending = asc;
            leftGtRight = ascending ? 1 : -1;
        }

        public int Count()
        {
            var count = 0;
            Node<T> nextNode = head;
            while (nextNode != null)
            {
                count++;

                nextNode = nextNode.next;
            }

            return count;
        }

        public List<Node<T>> GetAll() // выдать все элементы упорядоченного 
                               // списка в виде стандартного списка
        {
            List<Node<T>> nodes = new List<Node<T>>();
            Node<T> nextNode = head;
            while (nextNode != null)
            {
                nodes.Add(nextNode);
                nextNode = nextNode.next;
            }
            return nodes;
        }
    }

}