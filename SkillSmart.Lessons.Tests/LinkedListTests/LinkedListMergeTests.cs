using AlgorithmsDataStructures;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SkillSmart.Lessons.Tests.LinkedListTests
{
    [TestClass]
    public class LinkedListMergeTests
    {
        private LinkedList left;
        private LinkedList right;

        [TestInitialize]
        public void Init() 
        {
            this.left = new LinkedList();
            this.right = new LinkedList();
        }

        [TestMethod]
        public void AddNullNodeInTailTest()
        {
            this.left.AddInTail(null);
            this.right.AddInTail(null);

            var result = Lab1Bonus.Merge(this.left, this.right);

            Assert.AreEqual(0, result.Count());
        }

        [TestMethod]
        public void AddSingleNodeInTailTest()
        {
            this.left.AddInTail(new Node(5));
            this.right.AddInTail(new Node(5));

            var result = Lab1Bonus.Merge(this.left, this.right);

            Assert.AreEqual(1, result.Count());
            Assert.AreEqual(10, result.head.value);
            Assert.AreEqual(10, result.tail.value);
        }

        [TestMethod]
        public void AddSingleNodeInTail2Test()
        {
            this.left.AddInTail(new Node(5));
            this.right.AddInTail(new Node(10));

            var result = Lab1Bonus.Merge(this.left, this.right);

            Assert.AreEqual(1, result.Count());
            Assert.AreEqual(15, result.head.value);
            Assert.AreEqual(15, result.tail.value);
        }

        [TestMethod]
        public void AddTwoNodeInTailTest()
        {
            this.left.AddInTail(new Node(5));
            this.left.AddInTail(new Node(10));
            this.right.AddInTail(new Node(10));
            this.right.AddInTail(new Node(20));

            var result = Lab1Bonus.Merge(this.left, this.right);

            Assert.AreEqual(2, result.Count());
            Assert.AreEqual(15, result.head.value);
            Assert.AreEqual(30, result.tail.value);
        }

        [TestMethod]
        public void AddNegativeTest()
        {
            this.left.AddInTail(new Node(5));
            this.left.AddInTail(new Node(10));
            this.left.AddInTail(new Node(15));

            this.right.AddInTail(new Node(10));
            this.right.AddInTail(new Node(20));

            var result = Lab1Bonus.Merge(this.left, this.right);

            Assert.AreEqual(0, result.Count());
            Assert.AreEqual(null, result.head);
            Assert.AreEqual(null, result.tail);
        }

        [TestMethod]
        public void MergeNullableListTest()
        {
            this.left = null;

            this.right.AddInTail(new Node(10));
            this.right.AddInTail(new Node(20));

            var result = Lab1Bonus.Merge(this.left, this.right);

            Assert.AreEqual(0, result.Count());
            Assert.AreEqual(null, result.head);
            Assert.AreEqual(null, result.tail);
        }
   }
}