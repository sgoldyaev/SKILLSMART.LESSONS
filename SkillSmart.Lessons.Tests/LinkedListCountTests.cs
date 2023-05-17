using AlgorithmsDataStructures;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SkillSmart.Lessons.Tests
{
    [TestClass]
    public class LinkedListCountTests
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
        }

        [TestMethod]
        public void AddSingleNodeInTailTest()
        {
            linkedList.AddInTail(new Node(5));

            Assert.AreEqual(1, linkedList.Count());
        }

        [TestMethod]
        public void AddThreeNodesInTailTest()
        {
            linkedList.AddInTail(new Node(5));
            linkedList.AddInTail(new Node(15));
            linkedList.AddInTail(new Node(25));

            Assert.AreEqual(3, linkedList.Count());
        }

        [TestMethod]
        public void AddLinkedNodesInTailTest()
        {
            var node = new Node(5);
            node.next = new Node(15);

            linkedList.AddInTail(node);

            Assert.AreEqual(2, linkedList.Count());
        }

        [TestMethod]
        public void ClearSingleNodeInTailTest()
        {
            linkedList.AddInTail(new Node(5));

            linkedList.Clear();

            Assert.AreEqual(0, linkedList.Count());
        }
    }
}