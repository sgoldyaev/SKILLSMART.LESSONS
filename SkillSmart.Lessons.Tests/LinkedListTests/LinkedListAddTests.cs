using AlgorithmsDataStructures;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SkillSmart.Lessons.Tests.LinkedListTests
{
    [TestClass]
    public class LinkedListAddTests
    {
        private LinkedList linkedList;

        [TestInitialize]
        public void Init() 
        {
            this.linkedList = new LinkedList();
        }

        [TestMethod]
        public void AddNullNodeInTailTest()
        {
            this.linkedList.AddInTail(null);

            Assert.AreEqual(0, this.linkedList.Count());
            Assert.AreEqual(null, this.linkedList.head);
            Assert.AreEqual(null, this.linkedList.tail);
        }

        [TestMethod]
        public void AddSingleNodeInTailTest()
        {
            this.linkedList.AddInTail(new Node(5));

            Assert.AreEqual(1, this.linkedList.Count());
            Assert.AreEqual(5, this.linkedList.head.value);
            Assert.AreEqual(5, this.linkedList.tail.value);
        }

        [TestMethod]
        public void AddThreeNodesInTailTest()
        {
            this.linkedList.AddInTail(new Node(5));
            this.linkedList.AddInTail(new Node(15));
            this.linkedList.AddInTail(new Node(25));

            Assert.AreEqual(3, this.linkedList.Count());
            Assert.AreEqual(5, this.linkedList.head.value);
            Assert.AreEqual(25, this.linkedList.tail.value);
        }

        [TestMethod]
        public void AddLinkedNodesInTailTest()
        {
            var node = new Node(5);
            node.next = new Node(15);

            this.linkedList.AddInTail(node);

            Assert.AreEqual(1, this.linkedList.Count());
            Assert.AreEqual(5, this.linkedList.head.value);
            Assert.AreEqual(5, this.linkedList.tail.value);
        }

        [TestMethod]
        public void ClearSingleNodeInTailTest()
        {
            this.linkedList.AddInTail(new Node(5));

            this.linkedList.Clear();

            Assert.AreEqual(0, this.linkedList.Count());
            Assert.AreEqual(null, this.linkedList.head);
            Assert.AreEqual(null, this.linkedList.tail);
        }
    }
}