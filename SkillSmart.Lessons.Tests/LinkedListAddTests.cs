using AlgorithmsDataStructures;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SkillSmart.Lessons.Tests
{
    [TestClass]
    public class LinkedListAddTests
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

            Assert.AreEqual(0, linkedList.Count());
            Assert.AreEqual(null, linkedList.head);
            Assert.AreEqual(null, linkedList.tail);
        }

        [TestMethod]
        public void AddSingleNodeInTailTest()
        {
            linkedList.AddInTail(new Node(5));

            Assert.AreEqual(1, linkedList.Count());
            Assert.AreEqual(5, linkedList.head.value);
            Assert.AreEqual(5, linkedList.tail.value);
        }

        [TestMethod]
        public void AddThreeNodesInTailTest()
        {
            linkedList.AddInTail(new Node(5));
            linkedList.AddInTail(new Node(15));
            linkedList.AddInTail(new Node(25));

            Assert.AreEqual(3, linkedList.Count());
            Assert.AreEqual(5, linkedList.head.value);
            Assert.AreEqual(25, linkedList.tail.value);
        }

        [TestMethod]
        public void AddLinkedNodesInTailTest()
        {
            var node = new Node(5);
            node.next = new Node(15);

            linkedList.AddInTail(node);

            Assert.AreEqual(1, linkedList.Count());
            Assert.AreEqual(5, linkedList.head.value);
            Assert.AreEqual(5, linkedList.tail.value);
        }

        [TestMethod]
        public void ClearSingleNodeInTailTest()
        {
            linkedList.AddInTail(new Node(5));

            linkedList.Clear();

            Assert.AreEqual(0, linkedList.Count());
            Assert.AreEqual(null, linkedList.head);
            Assert.AreEqual(null, linkedList.tail);
        }
    }
}