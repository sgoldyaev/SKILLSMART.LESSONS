using AlgorithmsDataStructures;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SkillSmart.Lessons.Lab7.Tests
{
    [TestClass]
    public class DeleteAscTests
    {
        private readonly bool asc = true;
        private OrderedList<int> list;

        [TestInitialize]
        public void Init() 
        {
            list = new OrderedList<int>(asc);

            list.Add(1000);
            list.Add(2000);
            list.Add(3000);
        }

        [TestMethod]
        public void DeleteFirstElement()
        {
            list.Delete(1000);
            
            Assert.AreEqual(2, list.Count());

            Assert.AreEqual(2000, list.head.value);
            Assert.AreEqual(3000, list.head.next.value);
            Assert.AreEqual(null, list.head.next.next);
            Assert.AreEqual(2000, list.head.next.prev.value);
            Assert.AreEqual(null, list.head.next.prev.prev);
            Assert.AreEqual(null, list.head.next.next);
            Assert.AreEqual(null, list.head.prev);

            Assert.AreEqual(3000, list.tail.value);
            Assert.AreEqual(2000, list.tail.prev.value);
            Assert.AreEqual(null, list.tail.prev.prev);
            Assert.AreEqual(3000, list.tail.prev.next.value);
            Assert.AreEqual(null, list.tail.prev.next.next);
            Assert.AreEqual(null, list.tail.prev.prev);
            Assert.AreEqual(null, list.tail.next);
        }

        [TestMethod]
        public void DeleteSecondElement()
        {
            list.Delete(2000);
            
            Assert.AreEqual(2, list.Count());

            Assert.AreEqual(1000, list.head.value);
            Assert.AreEqual(3000, list.head.next.value);
            Assert.AreEqual(null, list.head.next.next);
            Assert.AreEqual(1000, list.head.next.prev.value);
            Assert.AreEqual(null, list.head.next.prev.prev);
            Assert.AreEqual(null, list.head.next.next);
            Assert.AreEqual(null, list.head.prev);

            Assert.AreEqual(3000, list.tail.value);
            Assert.AreEqual(1000, list.tail.prev.value);
            Assert.AreEqual(null, list.tail.prev.prev);
            Assert.AreEqual(3000, list.tail.prev.next.value);
            Assert.AreEqual(null, list.tail.prev.next.next);
            Assert.AreEqual(null, list.tail.prev.prev);
            Assert.AreEqual(null, list.tail.next);
        }

        [TestMethod]
        public void DeleteLastElement()
        {
            list.Delete(3000);
            
            Assert.AreEqual(2, list.Count());

            Assert.AreEqual(1000, list.head.value);
            Assert.AreEqual(2000, list.head.next.value);
            Assert.AreEqual(null, list.head.next.next);
            Assert.AreEqual(1000, list.head.next.prev.value);
            Assert.AreEqual(null, list.head.next.prev.prev);
            Assert.AreEqual(null, list.head.next.next);
            Assert.AreEqual(null, list.head.prev);

            Assert.AreEqual(2000, list.tail.value);
            Assert.AreEqual(1000, list.tail.prev.value);
            Assert.AreEqual(null, list.tail.prev.prev);
            Assert.AreEqual(2000, list.tail.prev.next.value);
            Assert.AreEqual(null, list.tail.prev.next.next);
            Assert.AreEqual(null, list.tail.prev.prev);
            Assert.AreEqual(null, list.tail.next);
        }

        [TestMethod]
        public void DeleteOrderedAllElements()
        {
            list.Delete(1000);
            list.Delete(2000);
            list.Delete(3000);
            
            Assert.AreEqual(0, list.Count());

            Assert.AreEqual(null, list.head);
            Assert.AreEqual(null, list.tail);
        }

        [TestMethod]
        public void DeleteReversedAllElements()
        {
            list.Delete(3000);
            list.Delete(2000);
            list.Delete(1000);
            
            Assert.AreEqual(0, list.Count());

            Assert.AreEqual(null, list.head);
            Assert.AreEqual(null, list.tail);
        }

        [TestMethod]
        public void DeleteMoreElements()
        {
            list.Delete(3000);
            list.Delete(2000);
            list.Delete(1000);
            list.Delete(1000);
            
            Assert.AreEqual(0, list.Count());

            Assert.AreEqual(null, list.head);
            Assert.AreEqual(null, list.tail);
        }
    }
}