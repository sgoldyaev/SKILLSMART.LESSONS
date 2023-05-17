using AlgorithmsDataStructures;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SkillSmart.Lessons.Tests
{
    [TestClass]
    public class LinkedListRemoveAllTests
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

            linkedList.RemoveAll(5);

            Assert.AreEqual(0, linkedList.Count());
        }

        [TestMethod]
        public void AddSingleNodeInTailTest()
        {
            linkedList.AddInTail(new Node(5));

            linkedList.RemoveAll(5);

            Assert.AreEqual(0, linkedList.Count());
        }

        [TestMethod]
        public void AddThreeNodesInTailTest()
        {
            linkedList.AddInTail(new Node(5));
            linkedList.AddInTail(new Node(15));
            linkedList.AddInTail(new Node(25));

            linkedList.RemoveAll(5);

            Assert.AreEqual(2, linkedList.Count());
        }

        [TestMethod]
        public void AddDoublicatedNodesInTailTest()
        {
            linkedList.AddInTail(new Node(5));
            linkedList.AddInTail(new Node(5));
            linkedList.AddInTail(new Node(25));

            linkedList.RemoveAll(5);

            Assert.AreEqual(1, linkedList.Count());
        }

        [TestMethod]
        public void AddDoublicatedNodesInTail2Test()
        {
            linkedList.AddInTail(new Node(25));
            linkedList.AddInTail(new Node(5));
            linkedList.AddInTail(new Node(5));

            linkedList.RemoveAll(5);

            Assert.AreEqual(1, linkedList.Count());
        }

        [TestMethod]
        public void AddDoublicatedNodesInTail3Test()
        {
            linkedList.AddInTail(new Node(5));
            linkedList.AddInTail(new Node(25));
            linkedList.AddInTail(new Node(5));
            linkedList.AddInTail(new Node(25));
            linkedList.AddInTail(new Node(5));

            linkedList.RemoveAll(5);

            Assert.AreEqual(2, linkedList.Count());
        }

        [TestMethod]
        public void AddDoublicatedNodesInTailNegativeTest()
        {
            linkedList.AddInTail(new Node(5));
            linkedList.AddInTail(new Node(5));
            linkedList.AddInTail(new Node(25));

            linkedList.RemoveAll(6);

            Assert.AreEqual(3, linkedList.Count());
        }

        [TestMethod]
        public void AddLinkedNodesInTailTest()
        {
            var node = new Node(5);
            node.next = new Node(15);

            linkedList.AddInTail(node);

            linkedList.RemoveAll(5);

            Assert.AreEqual(1, linkedList.Count());
        }

        [TestMethod]
        public void AddLinkedNodesInTail2Test()
        {
            var node = new Node(5);
            node.next = new Node(15);

            linkedList.AddInTail(node);

            linkedList.RemoveAll(15);

            Assert.AreEqual(1, linkedList.Count());
        }
    }
}