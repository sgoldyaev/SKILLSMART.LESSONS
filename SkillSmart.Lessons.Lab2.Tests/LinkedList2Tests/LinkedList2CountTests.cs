using AlgorithmsDataStructures;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SkillSmart.Lessons.Tests.LinkedList2Tests
{
    [TestClass]
    public class LinkedListCountTests
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

            Assert.AreEqual(0, this.linkedList.Count());
        }

        [TestMethod]
        public void AddSingleNodeInTailTest()
        {
            this.linkedList.AddInTail(new Node(5));

            Assert.AreEqual(1, this.linkedList.Count());
        }

        [TestMethod]
        public void AddThreeNodesInTailTest()
        {
            this.linkedList.AddInTail(new Node(5));
            this.linkedList.AddInTail(new Node(15));
            this.linkedList.AddInTail(new Node(25));

            Assert.AreEqual(3, this.linkedList.Count());
        }

        //[TestMethod]
        public void AddLinkedNodesInTailTest()
        {
            var node = new Node(5);
            node.next = new Node(15);

            this.linkedList.AddInTail(node);

            Assert.AreEqual(2, this.linkedList.Count());
        }

        [TestMethod]
        public void ClearSingleNodeInTailTest()
        {
            this.linkedList.AddInTail(new Node(5));

            this.linkedList.Clear();

            Assert.AreEqual(0, this.linkedList.Count());
        }
    }
}