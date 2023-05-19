using AlgorithmsDataStructures;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SkillSmart.Lessons.Tests.LinkedList2Tests
{
    [TestClass]
    public class LinkedListRemoveAllTests
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

            this.linkedList.RemoveAll(5);

            Assert.AreEqual(0, this.linkedList.Count());
        }

        [TestMethod]
        public void AddSingleNodeInTailTest()
        {
            this.linkedList.AddInTail(new Node(5));

            this.linkedList.RemoveAll(5);

            Assert.AreEqual(0, this.linkedList.Count());
            Assert.AreEqual(null, this.linkedList.head);
            Assert.AreEqual(null, this.linkedList.tail);
        }

        [TestMethod]
        public void AddThreeNodesInTailTest()
        {
            this.linkedList.AddInTail(new Node(5));
            this.linkedList.AddInTail(new Node(15));
            this.linkedList.AddInTail(new Node(25));

            this.linkedList.RemoveAll(5);

            Assert.AreEqual(2, this.linkedList.Count());
            Assert.AreEqual(15, this.linkedList.head.value);
            Assert.AreEqual(25, this.linkedList.tail.value);
        }

        [TestMethod]
        public void AddDoublicatedNodesInTailTest()
        {
            this.linkedList.AddInTail(new Node(5));
            this.linkedList.AddInTail(new Node(5));
            this.linkedList.AddInTail(new Node(25));

            this.linkedList.RemoveAll(5);

            Assert.AreEqual(1, this.linkedList.Count());
            Assert.AreEqual(25, this.linkedList.head.value);
            Assert.AreEqual(25, this.linkedList.tail.value);
        }

        [TestMethod]
        public void AddDoublicatedNodesInTail2Test()
        {
            this.linkedList.AddInTail(new Node(25));
            this.linkedList.AddInTail(new Node(5));
            this.linkedList.AddInTail(new Node(5));

            this.linkedList.RemoveAll(5);

            Assert.AreEqual(1, this.linkedList.Count());
            Assert.AreEqual(25, this.linkedList.head.value);
            Assert.AreEqual(25, this.linkedList.tail.value);
        }

        [TestMethod]
        public void AddDoublicatedNodesInTail3Test()
        {
            this.linkedList.AddInTail(new Node(5));
            this.linkedList.AddInTail(new Node(25));
            this.linkedList.AddInTail(new Node(5));
            this.linkedList.AddInTail(new Node(25));
            this.linkedList.AddInTail(new Node(5));

            this.linkedList.RemoveAll(5);

            Assert.AreEqual(2, this.linkedList.Count());
            Assert.AreEqual(25, this.linkedList.head.value);
            Assert.AreEqual(25, this.linkedList.tail.value);
        }

        [TestMethod]
        public void AddDoublicatedNodesInTailNegativeTest()
        {
            this.linkedList.AddInTail(new Node(5));
            this.linkedList.AddInTail(new Node(5));
            this.linkedList.AddInTail(new Node(25));

            this.linkedList.RemoveAll(6);

            Assert.AreEqual(3, this.linkedList.Count());
        }

        [TestMethod]
        public void AddLinkedNodesInTailTest()
        {
            var node = new Node(5);
            node.next = new Node(15);

            this.linkedList.AddInTail(node);

            this.linkedList.RemoveAll(5);

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

            this.linkedList.RemoveAll(15);

            Assert.AreEqual(1, this.linkedList.Count());
            Assert.AreEqual(5, this.linkedList.head.value);
            Assert.AreEqual(5, this.linkedList.tail.value);
        }
    }
}