using AlgorithmsDataStructures;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SkillSmart.Lessons.Tests.LinkedListTests
{
    [TestClass]
    public class LinkedListInsertNodeTests
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
            var n5 = new Node(5);
            var n15 = new Node(15);

            this.linkedList.AddInTail(null);

            this.linkedList.InsertAfter(n5, n15);

            Assert.AreEqual(0, this.linkedList.Count());
            Assert.AreEqual(null, this.linkedList.head);
            Assert.AreEqual(null, this.linkedList.tail);
        }

        [TestMethod]
        public void AddNodeToHeadTest()
        {
            var n15 = new Node(15);

            this.linkedList.InsertAfter(null, n15);

            Assert.AreEqual(1, this.linkedList.Count());
            Assert.AreEqual(15, this.linkedList.head.value);
            Assert.AreEqual(15, this.linkedList.tail.value);
        }

        [TestMethod]
        public void AddSingleNodeInTailTest()
        {
            var n5 = new Node(5);
            var n15 = new Node(15);

            this.linkedList.AddInTail(n5);

            this.linkedList.InsertAfter(n5, n15);

            Assert.AreEqual(2, this.linkedList.Count());
            Assert.AreEqual(5, this.linkedList.head.value);
            Assert.AreEqual(15, this.linkedList.tail.value);
        }

        [TestMethod]
        public void AddThreeNodesInTailTest()
        {
            var n5 = new Node(5);
            var n5_2 = new Node(5);
            var n15 = new Node(15);
            var n15_2 = new Node(15);
            var n25 = new Node(25);

            this.linkedList.AddInTail(n5);
            this.linkedList.AddInTail(n5_2);
            this.linkedList.AddInTail(n15);
            this.linkedList.AddInTail(n25);

            this.linkedList.InsertAfter(n5, n15_2);

            Assert.AreEqual(5, this.linkedList.Count());
            Assert.AreEqual(5, this.linkedList.head.value);
            Assert.AreEqual(25, this.linkedList.tail.value);
        }

        [TestMethod]
        public void AddThreeNodesInTail2Test()
        {
            var n5 = new Node(5);
            var n15 = new Node(15);
            var n20 = new Node(20);
            var n25 = new Node(25);

            this.linkedList.AddInTail(n5);
            this.linkedList.AddInTail(n15);
            this.linkedList.AddInTail(n25);

            this.linkedList.InsertAfter(n15, n20);

            Assert.AreEqual(4, this.linkedList.Count());
            Assert.AreEqual(5, this.linkedList.head.value);
            Assert.AreEqual(25, this.linkedList.tail.value);
        }

        [TestMethod]
        public void AddDoublicatedNodesInTailTest()
        {
            var n5 = new Node(5);
            var n5_2 = new Node(5);
            var n15 = new Node(15);
            var n25 = new Node(25);

            this.linkedList.AddInTail(n5);
            this.linkedList.AddInTail(n5_2);
            this.linkedList.AddInTail(n25);

            this.linkedList.InsertAfter(n5, n15);

            Assert.AreEqual(4, this.linkedList.Count());
            Assert.AreEqual(5, this.linkedList.head.value);
            Assert.AreEqual(25, this.linkedList.tail.value);
        }

        [TestMethod]
        public void AddDoublicatedNodesInTailNegativeTest()
        {
            var n5 = new Node(5);
            var n5_2 = new Node(5);
            var n6 = new Node(6);
            var n15 = new Node(15);
            var n25 = new Node(25);

            this.linkedList.AddInTail(n5);
            this.linkedList.AddInTail(n5_2);
            this.linkedList.AddInTail(n25);

            this.linkedList.InsertAfter(n6, n15);

            Assert.AreEqual(3, this.linkedList.Count());
            Assert.AreEqual(5, this.linkedList.head.value);
            Assert.AreEqual(25, this.linkedList.tail.value);
        }
    }
}