using AlgorithmsDataStructures;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SkillSmart.Lessons.Lab7.Tests
{
    [TestClass]
    public class AddAscTests
    {
        private readonly bool asc = true;
        private OrderedList<int> list;

        [TestInitialize]
        public void Init() 
        {
            list = new OrderedList<int>(asc);
        }

        [TestMethod]
        public void AddOneElement()
        {
            list.Add(1000);
            
            Assert.AreEqual(1, list.Count());
            Assert.AreEqual(1000, list.head.value);
            Assert.AreEqual(null, list.head.next);
            Assert.AreEqual(null, list.head.prev);

            Assert.AreEqual(1000, list.tail.value);
            Assert.AreEqual(null, list.tail.next);
            Assert.AreEqual(null, list.tail.prev);
        }

        [TestMethod]
        public void AddTwoOrderedElements()
        {
            list.Add(1000);
            list.Add(2000);
            
            Assert.AreEqual(2, list.Count());
            Assert.AreEqual(1000, list.head.value);
            Assert.AreEqual(2000, list.head.next.value);
            Assert.AreEqual(null, list.head.prev);

            Assert.AreEqual(2000, list.tail.value);
            Assert.AreEqual(1000, list.tail.prev.value);
            Assert.AreEqual(null, list.tail.next);
        }

        [TestMethod]
        public void AddTwoReversedElements()
        {
            list.Add(2000);
            list.Add(1000);
            
            Assert.AreEqual(2, list.Count());
            Assert.AreEqual(1000, list.head.value);
            Assert.AreEqual(2000, list.head.next.value);
            Assert.AreEqual(null, list.head.prev);

            Assert.AreEqual(2000, list.tail.value);
            Assert.AreEqual(1000, list.tail.prev.value);
            Assert.AreEqual(null, list.tail.next);
        }

        [TestMethod]
        public void AddThreeOrderedElements()
        {
            list.Add(1000);
            list.Add(2000);
            list.Add(3000);
            
            Assert.AreEqual(3, list.Count());
            Assert.AreEqual(1000, list.head.value);
            Assert.AreEqual(2000, list.head.next.value);
            Assert.AreEqual(3000, list.head.next.next.value);
            Assert.AreEqual(null, list.head.next.next.next);
            Assert.AreEqual(2000, list.head.next.next.prev.value);
            Assert.AreEqual(1000, list.head.next.next.prev.prev.value);
            Assert.AreEqual(null, list.head.next.next.prev.prev.prev);
            Assert.AreEqual(null, list.head.prev);

            Assert.AreEqual(3000, list.tail.value);
            Assert.AreEqual(2000, list.tail.prev.value);
            Assert.AreEqual(1000, list.tail.prev.prev.value);
            Assert.AreEqual(null, list.tail.prev.prev.prev);
            Assert.AreEqual(2000, list.tail.prev.prev.next.value);
            Assert.AreEqual(3000, list.tail.prev.prev.next.next.value);
            Assert.AreEqual(null, list.tail.prev.prev.next.next.next);
            Assert.AreEqual(null, list.tail.prev.prev.prev);
            Assert.AreEqual(null, list.tail.next);
        }

        [TestMethod]
        public void AddThreeReversedElements()
        {
            list.Add(3000);
            list.Add(2000);
            list.Add(1000);
            
            Assert.AreEqual(3, list.Count());
            Assert.AreEqual(1000, list.head.value);
            Assert.AreEqual(2000, list.head.next.value);
            Assert.AreEqual(3000, list.head.next.next.value);
            Assert.AreEqual(null, list.head.next.next.next);
            Assert.AreEqual(2000, list.head.next.next.prev.value);
            Assert.AreEqual(1000, list.head.next.next.prev.prev.value);
            Assert.AreEqual(null, list.head.next.next.prev.prev.prev);
            Assert.AreEqual(null, list.head.prev);

            Assert.AreEqual(3000, list.tail.value);
            Assert.AreEqual(2000, list.tail.prev.value);
            Assert.AreEqual(1000, list.tail.prev.prev.value);
            Assert.AreEqual(null, list.tail.prev.prev.prev);
            Assert.AreEqual(2000, list.tail.prev.prev.next.value);
            Assert.AreEqual(3000, list.tail.prev.prev.next.next.value);
            Assert.AreEqual(null, list.tail.prev.prev.next.next.next);
            Assert.AreEqual(null, list.tail.prev.prev.prev);
            Assert.AreEqual(null, list.tail.next);
        }

        [TestMethod]
        public void AddThreeMixed1Elements()
        {
            list.Add(2000);
            list.Add(3000);
            list.Add(1000);
            
            Assert.AreEqual(3, list.Count());
            Assert.AreEqual(1000, list.head.value);
            Assert.AreEqual(2000, list.head.next.value);
            Assert.AreEqual(3000, list.head.next.next.value);
            Assert.AreEqual(null, list.head.next.next.next);
            Assert.AreEqual(2000, list.head.next.next.prev.value);
            Assert.AreEqual(1000, list.head.next.next.prev.prev.value);
            Assert.AreEqual(null, list.head.next.next.prev.prev.prev);
            Assert.AreEqual(null, list.head.prev);

            Assert.AreEqual(3000, list.tail.value);
            Assert.AreEqual(2000, list.tail.prev.value);
            Assert.AreEqual(1000, list.tail.prev.prev.value);
            Assert.AreEqual(null, list.tail.prev.prev.prev);
            Assert.AreEqual(2000, list.tail.prev.prev.next.value);
            Assert.AreEqual(3000, list.tail.prev.prev.next.next.value);
            Assert.AreEqual(null, list.tail.prev.prev.next.next.next);
            Assert.AreEqual(null, list.tail.prev.prev.prev);
            Assert.AreEqual(null, list.tail.next);
        }

        [TestMethod]
        public void AddThreeMixed2Elements()
        {
            list.Add(3000);
            list.Add(1000);
            list.Add(2000);
            
            Assert.AreEqual(3, list.Count());
            Assert.AreEqual(1000, list.head.value);
            Assert.AreEqual(2000, list.head.next.value);
            Assert.AreEqual(3000, list.head.next.next.value);
            Assert.AreEqual(null, list.head.next.next.next);
            Assert.AreEqual(2000, list.head.next.next.prev.value);
            Assert.AreEqual(1000, list.head.next.next.prev.prev.value);
            Assert.AreEqual(null, list.head.next.next.prev.prev.prev);
            Assert.AreEqual(null, list.head.prev);

            Assert.AreEqual(3000, list.tail.value);
            Assert.AreEqual(2000, list.tail.prev.value);
            Assert.AreEqual(1000, list.tail.prev.prev.value);
            Assert.AreEqual(null, list.tail.prev.prev.prev);
            Assert.AreEqual(2000, list.tail.prev.prev.next.value);
            Assert.AreEqual(3000, list.tail.prev.prev.next.next.value);
            Assert.AreEqual(null, list.tail.prev.prev.next.next.next);
            Assert.AreEqual(null, list.tail.prev.prev.prev);
            Assert.AreEqual(null, list.tail.next);
        }
    }
}