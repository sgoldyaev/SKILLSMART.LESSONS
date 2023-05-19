using AlgorithmsDataStructures;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SkillSmart.Lessons.Tests.LinkedList2Tests
{
    [TestClass]
    public class LinkedListRemoveTests
    {
        private LinkedList2 linkedList;

        [TestInitialize]
        public void Init() 
        {
            this.linkedList = new LinkedList2();
        }

        [TestMethod]
        public void AddNullNodeInTailTest()
        {
            this.linkedList.AddInTail(null);

            var removed = this.linkedList.Remove(5);

            Assert.AreEqual(false, removed);
            Assert.AreEqual(0, this.linkedList.Count());
            Assert.AreEqual(null, this.linkedList.head);
            Assert.AreEqual(null, this.linkedList.tail);
        }

        [TestMethod]
        public void AddSingleNodeInTailTest()
        {
            this.linkedList.AddInTail(new Node(5));

            var removed = this.linkedList.Remove(5);

            Assert.AreEqual(true, removed);
            Assert.AreEqual(0, this.linkedList.Count());
            Assert.AreEqual(null, this.linkedList.head);
            Assert.AreEqual(null, this.linkedList.tail);
        }

        [TestMethod]
        public void AddSingleNodeInTailNegativeTest()
        {
            this.linkedList.AddInTail(new Node(5));

            var removed = this.linkedList.Remove(6);

            Assert.AreEqual(false, removed);
            Assert.AreEqual(1, this.linkedList.Count());
            Assert.AreEqual(5, this.linkedList.head.value);
            Assert.AreEqual(5, this.linkedList.tail.value);
        }

        [TestMethod]
        public void AddThreeNodesInTailTest()
        {
            var n1 = new Node(5);
            var n2 = new Node(15);
            var n3 = new Node(25);

            this.linkedList.AddInTail(n1);
            this.linkedList.AddInTail(n2);
            this.linkedList.AddInTail(n3);

            var removed = this.linkedList.Remove(5);

            Assert.AreEqual(true, removed);
            Assert.AreEqual(2, this.linkedList.Count());
            Assert.AreEqual(n2, this.linkedList.head);
            Assert.AreEqual(n3, this.linkedList.tail);
        }

        [TestMethod]
        public void AddThreeNodesInTail2Test()
        {
            var n1 = new Node(15);
            var n2 = new Node(5);
            var n3 = new Node(25);

            this.linkedList.AddInTail(n1);
            this.linkedList.AddInTail(n2);
            this.linkedList.AddInTail(n3);

            var removed = this.linkedList.Remove(5);

            Assert.AreEqual(true, removed);
            Assert.AreEqual(2, this.linkedList.Count());
            Assert.AreEqual(n1, this.linkedList.head);
            Assert.AreEqual(n3, this.linkedList.tail);
        }

        [TestMethod]
        public void AddThreeNodesInTail3Test()
        {
            var n1 = new Node(15);
            var n2 = new Node(25);
            var n3 = new Node(5);

            this.linkedList.AddInTail(n1);
            this.linkedList.AddInTail(n2);
            this.linkedList.AddInTail(n3);

            var removed = this.linkedList.Remove(5);

            Assert.AreEqual(true, removed);
            Assert.AreEqual(2, this.linkedList.Count());
            Assert.AreEqual(n1, this.linkedList.head);
            Assert.AreEqual(n2, this.linkedList.tail);
        }

        [TestMethod]
        public void AddDoublicatedNodesInTailTest()
        {
            var n1 = new Node(5);
            var n2 = new Node(5);
            var n3 = new Node(25);

            this.linkedList.AddInTail(n1);
            this.linkedList.AddInTail(n2);
            this.linkedList.AddInTail(n3);

            var removed = this.linkedList.Remove(5);

            Assert.AreEqual(true, removed);
            Assert.AreEqual(2, this.linkedList.Count());
            Assert.AreEqual(n2, this.linkedList.head);
            Assert.AreEqual(n3, this.linkedList.tail);
        }

        [TestMethod]
        public void AddDoublicatedNodesInTailNegativeTest()
        {
            var n1 = new Node(5);
            var n2 = new Node(5);
            var n3 = new Node(25);

            this.linkedList.AddInTail(n1);
            this.linkedList.AddInTail(n2);
            this.linkedList.AddInTail(n3);

            var removed = this.linkedList.Remove(6);

            Assert.AreEqual(false, removed);
            Assert.AreEqual(3, this.linkedList.Count());
            Assert.AreEqual(n1, this.linkedList.head);
            Assert.AreEqual(n3, this.linkedList.tail);
        }

        [TestMethod]
        public void AddLinkedNodesInTailTest()
        {
            var n1 = new Node(5);
            var n2 = new Node(15);

            var node = n1;
            node.next = n2;

            this.linkedList.AddInTail(node);

            var removed = this.linkedList.Remove(5);

            Assert.AreEqual(true, removed);
            Assert.AreEqual(0, this.linkedList.Count());
            Assert.AreEqual(null, this.linkedList.head);
            Assert.AreEqual(null, this.linkedList.tail);
        }

        [TestMethod]
        public void AddLinkedNodesInTail2Test()
        {
            var node = new Node(5);
            node.next = new Node(15);

            this.linkedList.AddInTail(node);

            var removed = this.linkedList.Remove(15);

            Assert.AreEqual(false, removed);
            Assert.AreEqual(1, this.linkedList.Count());
            Assert.AreEqual(5, this.linkedList.head.value);
            Assert.AreEqual(5, this.linkedList.tail.value);
        }
    }
}