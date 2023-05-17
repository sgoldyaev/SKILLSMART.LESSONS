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
            linkedList.AddInTail(null);

            linkedList.InsertAfter(new Node(5), new Node(15));

            Assert.AreEqual(0, linkedList.Count());
        }

        [TestMethod]
        public void AddSingleNodeInTailTest()
        {
            linkedList.AddInTail(new Node(5));

            linkedList.InsertAfter(new Node(5), new Node(15));

            Assert.AreEqual(2, linkedList.Count());
        }

        [TestMethod]
        public void AddThreeNodesInTailTest()
        {
            linkedList.AddInTail(new Node(5));
            linkedList.AddInTail(new Node(15));
            linkedList.AddInTail(new Node(25));

            linkedList.InsertAfter(new Node(5), new Node(15));

            Assert.AreEqual(4, linkedList.Count());
        }


        [TestMethod]
        public void AddThreeNodesInTail2Test()
        {
            linkedList.AddInTail(new Node(5));
            linkedList.AddInTail(new Node(15));
            linkedList.AddInTail(new Node(25));

            linkedList.InsertAfter(new Node(15), new Node(20));

            Assert.AreEqual(4, linkedList.Count());
        }



        [TestMethod]
        public void AddDoublicatedNodesInTailTest()
        {
            linkedList.AddInTail(new Node(5));
            linkedList.AddInTail(new Node(5));
            linkedList.AddInTail(new Node(25));

            linkedList.InsertAfter(new Node(5), new Node(15));

            Assert.AreEqual(4, linkedList.Count());
        }

        [TestMethod]
        public void AddDoublicatedNodesInTailNegativeTest()
        {
            linkedList.AddInTail(new Node(5));
            linkedList.AddInTail(new Node(5));
            linkedList.AddInTail(new Node(25));

            linkedList.InsertAfter(new Node(6), new Node(15));

            Assert.AreEqual(3, linkedList.Count());
        }
    }
}