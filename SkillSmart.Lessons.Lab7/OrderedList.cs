using System;
using System.Collections.Generic;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

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
        private bool _ascending;
        private int _order;

        public OrderedList(bool asc)
        {
            head = null;
            tail = null;

            _ascending = asc;
            _order = _ascending ? 1 : -1;
        }

        public int Compare(T v1, T v2)
        {
            int result = 0;
            if (typeof(T) == typeof(String))
            {
                result = string.Compare(v1?.ToString()?.Trim(), v2?.ToString()?.Trim(), StringComparison.InvariantCulture);
            }
            else if (typeof(IComparable).IsAssignableFrom(typeof(T)))
            {
                var c1 = v1 as IComparable;
                var c2 = v2 as IComparable;
                result = c1.CompareTo(v2);
            }

            return result;
            // -1 если v1 < v2
            // 0 если v1 == v2
            // +1 если v1 > v2
        }

        public void Add(T value)
        {
            var node = new Node<T>(value);

            if (head == null)
            {
                head = node;
                tail = node;

                return;
            }

            if (Compare(head.value, node.value) == _order && head != null)
            {
                node.next = head;
                head.prev = node;

                head = node;

                return;
            }

            if (Compare(node.value, tail.value) == _order && tail != null)
            {
                node.prev = tail;
                tail.next = node;

                tail = node;

                return;
            }

            Node<T> next = head;
            while (next != null)
            {
                if (Compare(node.value, next.value) != - _order && (next.next == null || Compare(next.next.value, node.value) != - _order))
                {
                    node.prev = next;
                    node.next = next.next;
                    
                    next.next.prev = node;
                    next.next = node;

                    if (next == tail)
                    {
                        tail = node;
                    }

                    break;
                }

                next = next.next;
            }
;       }

        public Node<T> Find(T val)
        {
            if (head == null && tail == null)
            {
                return default;
            }

            /// NOTE [sg]: 5. skip connection
            if (Compare(val, head.value) == - _order || Compare(tail.value, val) == - _order)
            {
                return default;
            }

            Node<T> find = head;
            while (find != null)
            {
                if (Compare(val, find.value) == 0)
                {
                    return find;
                }

                find = find.next;
            }

            return default;
        }

        public void Delete(T val)
        {
            Node<T> find = Find(val);
            if (find != null)
            {
                if (find.next != null && find.prev != null)
                {
                    find.next.prev = find.prev;
                    find.prev.next = find.next;
                }

                if (find.prev == null)
                {
                    head = find.next;

                    if (find.next != null) find.next.prev = null;
                }

                if (find.next == null)
                {
                    tail = find.prev;

                    if (find.prev != null) find.prev.next = null;
                }
            }
        }

        public void Clear(bool asc)
        {
            head = null;
            tail = null;
            
            _ascending = asc;
            _order = _ascending ? 1 : -1;
        }

        public int Count()
        {
            var count = 0;
            Node<T> find = head;
            while (find != null)
            {
                count++;

                find = find.next;
            }

            return count;
        }

        public List<Node<T>> GetAll() // выдать все элементы упорядоченного 
                               // списка в виде стандартного списка
        {
            List<Node<T>> r = new List<Node<T>>();
            Node<T> node = head;
            while (node != null)
            {
                r.Add(node);
                node = node.next;
            }
            return r;
        }
    }

}