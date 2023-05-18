using AlgorithmsDataStructures;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SkillSmart.Lessons.Tests
{
    [TestClass]
    public class LinkedListRemoveTests
    {
        private LinkedList linkedList;

        [TestInitialize]
        public void Init() 
        {
            linkedList = new LinkedList();
        }

        [TestMethod]
        public void AddNullNodeInTailTest()
        {
            linkedList.AddInTail(null);

            var removed = linkedList.Remove(5);

            Assert.AreEqual(false, removed);
            Assert.AreEqual(0, linkedList.Count());
            Assert.AreEqual(null, linkedList.head);
            Assert.AreEqual(null, linkedList.tail);
        }

        [TestMethod]
        public void AddSingleNodeInTailTest()
        {
            linkedList.AddInTail(new Node(5));

            var removed = linkedList.Remove(5);

            Assert.AreEqual(true, removed);
            Assert.AreEqual(0, linkedList.Count());
            Assert.AreEqual(null, linkedList.head);
            Assert.AreEqual(null, linkedList.tail);
        }

        [TestMethod]
        public void AddSingleNodeInTailNegativeTest()
        {
            linkedList.AddInTail(new Node(5));

            var removed = linkedList.Remove(6);

            Assert.AreEqual(false, removed);
            Assert.AreEqual(1, linkedList.Count());
            Assert.AreEqual(5, linkedList.head.value);
            Assert.AreEqual(5, linkedList.tail.value);
        }

        [TestMethod]
        public void AddThreeNodesInTailTest()
        {
            var n1 = new Node(5);
            var n2 = new Node(15);
            var n3 = new Node(25);

            linkedList.AddInTail(n1);
            linkedList.AddInTail(n2);
            linkedList.AddInTail(n3);

            var removed = linkedList.Remove(5);

            Assert.AreEqual(true, removed);
            Assert.AreEqual(2, linkedList.Count());
            Assert.AreEqual(n2, linkedList.head);
            Assert.AreEqual(n3, linkedList.tail);
        }

        [TestMethod]
        public void AddThreeNodesInTail2Test()
        {
            var n1 = new Node(15);
            var n2 = new Node(5);
            var n3 = new Node(25);

            linkedList.AddInTail(n1);
            linkedList.AddInTail(n2);
            linkedList.AddInTail(n3);

            var removed = linkedList.Remove(5);

            Assert.AreEqual(true, removed);
            Assert.AreEqual(2, linkedList.Count());
            Assert.AreEqual(n1, linkedList.head);
            Assert.AreEqual(n3, linkedList.tail);
        }

        [TestMethod]
        public void AddThreeNodesInTail3Test()
        {
            var n1 = new Node(15);
            var n2 = new Node(25);
            var n3 = new Node(5);

            linkedList.AddInTail(n1);
            linkedList.AddInTail(n2);
            linkedList.AddInTail(n3);

            var removed = linkedList.Remove(5);

            Assert.AreEqual(true, removed);
            Assert.AreEqual(2, linkedList.Count());
            Assert.AreEqual(n1, linkedList.head);
            Assert.AreEqual(n2, linkedList.tail);
        }

        [TestMethod]
        public void AddDoublicatedNodesInTailTest()
        {
            var n1 = new Node(5);
            var n2 = new Node(5);
            var n3 = new Node(25);

            linkedList.AddInTail(n1);
            linkedList.AddInTail(n2);
            linkedList.AddInTail(n3);

            var removed = linkedList.Remove(5);

            Assert.AreEqual(true, removed);
            Assert.AreEqual(2, linkedList.Count());
            Assert.AreEqual(n2, linkedList.head);
            Assert.AreEqual(n3, linkedList.tail);
        }

        [TestMethod]
        public void AddDoublicatedNodesInTailNegativeTest()
        {
            var n1 = new Node(5);
            var n2 = new Node(5);
            var n3 = new Node(25);

            linkedList.AddInTail(n1);
            linkedList.AddInTail(n2);
            linkedList.AddInTail(n3);

            var removed = linkedList.Remove(6);

            Assert.AreEqual(false, removed);
            Assert.AreEqual(3, linkedList.Count());
            Assert.AreEqual(n1, linkedList.head);
            Assert.AreEqual(n3, linkedList.tail);
        }

        [TestMethod]
        public void AddLinkedNodesInTailTest()
        {
            var n1 = new Node(5);
            var n2 = new Node(15);

            var node = n1;
            node.next = n2;

            linkedList.AddInTail(node);

            var removed = linkedList.Remove(5);

            Assert.AreEqual(true, removed);
            Assert.AreEqual(0, linkedList.Count());
            Assert.AreEqual(null, linkedList.head);
            Assert.AreEqual(null, linkedList.tail);
        }

        [TestMethod]
        public void AddLinkedNodesInTail2Test()
        {
            var node = new Node(5);
            node.next = new Node(15);

            linkedList.AddInTail(node);

            var removed = linkedList.Remove(15);

            Assert.AreEqual(false, removed);
            Assert.AreEqual(1, linkedList.Count());
            Assert.AreEqual(5, linkedList.head.value);
            Assert.AreEqual(5, linkedList.tail.value);
        }
    }
}