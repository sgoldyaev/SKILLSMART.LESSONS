using AlgorithmsDataStructures;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SkillSmart.Lessons.Tests
{
    [TestClass]
    public class LinkedListMergeTests
    {
        private LinkedList left;
        private LinkedList right;

        [TestInitialize]
        public void Init() 
        {
            left = new LinkedList();
            right = new LinkedList();
        }

        [TestMethod]
        public void AddNullNodeInTailTest()
        {
            left.AddInTail(null);
            right.AddInTail(null);

            var result = LinkedList.Merge(left, right);

            Assert.AreEqual(0, result.Count());
        }

        [TestMethod]
        public void AddSingleNodeInTailTest()
        {
            left.AddInTail(new Node(5));
            right.AddInTail(new Node(5));

            var result = LinkedList.Merge(left, right);

            Assert.AreEqual(1, result.Count());
            Assert.AreEqual(10, result.head.value);
            Assert.AreEqual(10, result.tail.value);
        }

        [TestMethod]
        public void AddSingleNodeInTail2Test()
        {
            left.AddInTail(new Node(5));
            right.AddInTail(new Node(10));

            var result = LinkedList.Merge(left, right);

            Assert.AreEqual(1, result.Count());
            Assert.AreEqual(15, result.head.value);
            Assert.AreEqual(15, result.tail.value);
        }

        [TestMethod]
        public void AddTwoNodeInTailTest()
        {
            left.AddInTail(new Node(5));
            left.AddInTail(new Node(10));
            right.AddInTail(new Node(10));
            right.AddInTail(new Node(20));

            var result = LinkedList.Merge(left, right);

            Assert.AreEqual(2, result.Count());
            Assert.AreEqual(15, result.head.value);
            Assert.AreEqual(30, result.tail.value);
        }

        [TestMethod]
        public void AddNegativeTest()
        {
            left.AddInTail(new Node(5));
            left.AddInTail(new Node(10));
            left.AddInTail(new Node(15));

            right.AddInTail(new Node(10));
            right.AddInTail(new Node(20));

            var result = LinkedList.Merge(left, right);

            Assert.AreEqual(0, result.Count());
            Assert.AreEqual(null, result.head);
            Assert.AreEqual(null, result.tail);
        }
   }
}