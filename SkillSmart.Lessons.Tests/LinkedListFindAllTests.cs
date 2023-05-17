using AlgorithmsDataStructures;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SkillSmart.Lessons.Tests
{
    [TestClass]
    public class LinkedListFindAllTests
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

            var found = linkedList.FindAll(5);

            Assert.AreEqual(0, found.Count);
        }

        [TestMethod]
        public void AddSingleNodeInTailTest()
        {
            linkedList.AddInTail(new Node(5));

            var found = linkedList.FindAll(5);

            Assert.AreEqual(1, found.Count);
        }

        [TestMethod]
        public void AddThreeNodesInTailTest()
        {
            linkedList.AddInTail(new Node(5));
            linkedList.AddInTail(new Node(15));
            linkedList.AddInTail(new Node(25));

            var found = linkedList.FindAll(5);

            Assert.AreEqual(1, found.Count);
        }


        [TestMethod]
        public void AddDoublicatedNodesInTailTest()
        {
            linkedList.AddInTail(new Node(5));
            linkedList.AddInTail(new Node(5));
            linkedList.AddInTail(new Node(25));

            var found = linkedList.FindAll(5);

            Assert.AreEqual(2, found.Count);
        }

        [TestMethod]
        public void AddDoublicatedNodesInTailNegativeTest()
        {
            linkedList.AddInTail(new Node(5));
            linkedList.AddInTail(new Node(5));
            linkedList.AddInTail(new Node(25));

            var found = linkedList.FindAll(6);

            Assert.AreEqual(0, found.Count);
        }

        [TestMethod]
        public void AddLinkedNodesInTailTest()
        {
            var node = new Node(5);
            node.next = new Node(15);

            linkedList.AddInTail(node);

            var found = linkedList.FindAll(5);

            Assert.AreEqual(1, found.Count);
        }

        [TestMethod]
        public void ClearSingleNodeInTailTest()
        {
            linkedList.AddInTail(new Node(5));

            linkedList.Clear();

            var found = linkedList.FindAll(5);

            Assert.AreEqual(0, found.Count);
        }
    }
}