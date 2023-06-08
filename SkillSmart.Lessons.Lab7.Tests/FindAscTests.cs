using AlgorithmsDataStructures;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SkillSmart.Lessons.Lab7.Tests
{
    [TestClass]
    public class FindAscTests
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
        public void FindFirstElement()
        {
            var find = list.Find(1000);
            
            Assert.AreEqual(1000, find.value);
        }

        [TestMethod]
        public void FindSecondElement()
        {
            var find = list.Find(2000);
            
            Assert.AreEqual(2000, find.value);
        }

        [TestMethod]
        public void FindLastElement()
        {
            var find = list.Find(3000);
            
            Assert.AreEqual(3000, find.value);
        }

        [TestMethod]
        public void FindLessThanFirstElement()
        {
            var find = list.Find(10);
            
            Assert.AreEqual(null, find);
        }

        [TestMethod]
        public void FindGreaterThanLastElement()
        {
            var find = list.Find(10000);
            
            Assert.AreEqual(null, find);
        }
    }
}