using AlgorithmsDataStructures;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SkillSmart.Lessons.Lab3.Tests
{
    [TestClass]
    public class SizeTests
    {
        private Queue<int> queue;

        [TestInitialize]
        public void Init() 
        {
            this.queue = new Queue<int>();
        }

        [TestMethod]
        public void EnqueueSingleElementTest()
        {
            this.queue.Enqueue(100);
            
            Assert.AreEqual(1, this.queue.Size());
        }

        [TestMethod]
        public void EnqueueTwoElementTest()
        {
            this.queue.Enqueue(100);
            this.queue.Enqueue(200);
            
            Assert.AreEqual(2, this.queue.Size());
        }
    }
}