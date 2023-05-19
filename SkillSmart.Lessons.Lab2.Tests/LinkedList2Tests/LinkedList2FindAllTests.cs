using AlgorithmsDataStructures;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SkillSmart.Lessons.Tests.LinkedList2Tests
{
    [TestClass]
    public class LinkedListFindAllTests
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

            var found = this.linkedList.FindAll(5);

            Assert.AreEqual(0, found.Count);
        }

        [TestMethod]
        public void AddSingleNodeInTailTest()
        {
            this.linkedList.AddInTail(new Node(5));

            var found = this.linkedList.FindAll(5);

            Assert.AreEqual(1, found.Count);
        }

        [TestMethod]
        public void AddThreeNodesInTailTest()
        {
            this.linkedList.AddInTail(new Node(5));
            this.linkedList.AddInTail(new Node(15));
            this.linkedList.AddInTail(new Node(25));

            var found = this.linkedList.FindAll(5);

            Assert.AreEqual(1, found.Count);
        }


        [TestMethod]
        public void AddDoublicatedNodesInTailTest()
        {
            this.linkedList.AddInTail(new Node(5));
            this.linkedList.AddInTail(new Node(5));
            this.linkedList.AddInTail(new Node(25));

            var found = this.linkedList.FindAll(5);

            Assert.AreEqual(2, found.Count);
        }

        [TestMethod]
        public void AddDoublicatedNodesInTailNegativeTest()
        {
            this.linkedList.AddInTail(new Node(5));
            this.linkedList.AddInTail(new Node(5));
            this.linkedList.AddInTail(new Node(25));

            var found = this.linkedList.FindAll(6);

            Assert.AreEqual(0, found.Count);
        }

        [TestMethod]
        public void AddLinkedNodesInTailTest()
        {
            var node = new Node(5);
            node.next = new Node(15);

            this.linkedList.AddInTail(node);

            var found = this.linkedList.FindAll(5);

            Assert.AreEqual(1, found.Count);
        }

        [TestMethod]
        public void ClearSingleNodeInTailTest()
        {
            this.linkedList.AddInTail(new Node(5));

            this.linkedList.Clear();

            var found = this.linkedList.FindAll(5);

            Assert.AreEqual(0, found.Count);
        }
    }
}