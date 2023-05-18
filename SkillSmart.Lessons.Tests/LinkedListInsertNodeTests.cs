using AlgorithmsDataStructures;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SkillSmart.Lessons.Tests
{
    [TestClass]
    public class LinkedListInsertNodeTests
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
            var n5 = new Node(5);
            var n15 = new Node(15);

            linkedList.AddInTail(null);

            linkedList.InsertAfter(n5, n15);

            Assert.AreEqual(0, linkedList.Count());
            Assert.AreEqual(null, linkedList.head);
            Assert.AreEqual(null, linkedList.tail);
        }

        [TestMethod]
        public void AddNodeToHeadTest()
        {
            var n15 = new Node(15);

            linkedList.InsertAfter(null, n15);

            Assert.AreEqual(1, linkedList.Count());
            Assert.AreEqual(15, linkedList.head.value);
            Assert.AreEqual(15, linkedList.tail.value);
        }

        [TestMethod]
        public void AddSingleNodeInTailTest()
        {
            var n5 = new Node(5);
            var n15 = new Node(15);

            linkedList.AddInTail(n5);

            linkedList.InsertAfter(n5, n15);

            Assert.AreEqual(2, linkedList.Count());
            Assert.AreEqual(5, linkedList.head.value);
            Assert.AreEqual(15, linkedList.tail.value);
        }

        [TestMethod]
        public void AddThreeNodesInTailTest()
        {
            var n5 = new Node(5);
            var n5_2 = new Node(5);
            var n15 = new Node(15);
            var n15_2 = new Node(15);
            var n25 = new Node(25);

            linkedList.AddInTail(n5);
            linkedList.AddInTail(n5_2);
            linkedList.AddInTail(n15);
            linkedList.AddInTail(n25);

            linkedList.InsertAfter(n5, n15_2);

            Assert.AreEqual(5, linkedList.Count());
            Assert.AreEqual(5, linkedList.head.value);
            Assert.AreEqual(25, linkedList.tail.value);
        }

        [TestMethod]
        public void AddThreeNodesInTail2Test()
        {
            var n5 = new Node(5);
            var n15 = new Node(15);
            var n20 = new Node(20);
            var n25 = new Node(25);

            linkedList.AddInTail(n5);
            linkedList.AddInTail(n15);
            linkedList.AddInTail(n25);

            linkedList.InsertAfter(n15, n20);

            Assert.AreEqual(4, linkedList.Count());
            Assert.AreEqual(5, linkedList.head.value);
            Assert.AreEqual(25, linkedList.tail.value);
        }

        [TestMethod]
        public void AddDoublicatedNodesInTailTest()
        {
            var n5 = new Node(5);
            var n5_2 = new Node(5);
            var n15 = new Node(15);
            var n25 = new Node(25);

            linkedList.AddInTail(n5);
            linkedList.AddInTail(n5_2);
            linkedList.AddInTail(n25);

            linkedList.InsertAfter(n5, n15);

            Assert.AreEqual(4, linkedList.Count());
            Assert.AreEqual(5, linkedList.head.value);
            Assert.AreEqual(25, linkedList.tail.value);
        }

        [TestMethod]
        public void AddDoublicatedNodesInTailNegativeTest()
        {
            var n5 = new Node(5);
            var n5_2 = new Node(5);
            var n6 = new Node(6);
            var n15 = new Node(15);
            var n25 = new Node(25);

            linkedList.AddInTail(n5);
            linkedList.AddInTail(n5_2);
            linkedList.AddInTail(n25);

            linkedList.InsertAfter(n6, n15);

            Assert.AreEqual(3, linkedList.Count());
            Assert.AreEqual(5, linkedList.head.value);
            Assert.AreEqual(25, linkedList.tail.value);
        }
    }
}