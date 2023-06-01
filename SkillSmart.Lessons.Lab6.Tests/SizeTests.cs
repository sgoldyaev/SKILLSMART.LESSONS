using AlgorithmsDataStructures;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SkillSmart.Lessons.Lab3.Tests
{
    [TestClass]
    public class SizeTests
    {
        private Deque<int> queue;

        [TestInitialize]
        public void Init() 
        {
            this.queue = new Deque<int>();
        }

        [TestMethod]
        public void AddFrontSingleElementTest()
        {
            this.queue.AddFront(100);
            
            Assert.AreEqual(1, this.queue.Size());
        }

        [TestMethod]
        public void AddFrontTwoElementTest()
        {
            this.queue.AddFront(100);
            this.queue.AddFront(200);
            
            Assert.AreEqual(2, this.queue.Size());
        }

        [TestMethod]
        public void AddTailSingleElementTest()
        {
            this.queue.AddTail(100);
            
            Assert.AreEqual(1, this.queue.Size());
        }

        [TestMethod]
        public void AddTailTwoElementTest()
        {
            this.queue.AddFront(100);
            this.queue.AddFront(200);
            
            Assert.AreEqual(2, this.queue.Size());
        }
    }
}