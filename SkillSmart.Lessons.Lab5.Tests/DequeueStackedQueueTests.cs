using AlgorithmsDataStructures;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SkillSmart.Lessons.Lab3.Tests
{
    [TestClass]
    public class DequeueStackedQueueTests
    {
        private QueueOnStacks<int> queue;

        [TestInitialize]
        public void Init() 
        {
            this.queue = new QueueOnStacks<int>();
            this.queue.Enqueue(100);
            this.queue.Enqueue(200);
        }

        [TestMethod]
        public void DequeueSingleElementTest()
        {
            var last = queue.Dequeue();
            
            Assert.AreEqual(1, this.queue.Size());
            Assert.AreEqual(100, last);
        }

        [TestMethod]
        public void DequeueTwoElementsTest()
        {
            var last = this.queue.Dequeue();
            
            Assert.AreEqual(1, this.queue.Size());
            Assert.AreEqual(100, last);

            last = this.queue.Dequeue();
            
            Assert.AreEqual(0, this.queue.Size());
            Assert.AreEqual(200, last);
        }

        [TestMethod]
        public void DequeueThreeElementsTest()
        {
            var last = this.queue.Dequeue();
            
            Assert.AreEqual(1, this.queue.Size());
            Assert.AreEqual(100, last);

            last = this.queue.Dequeue();
            
            Assert.AreEqual(0, this.queue.Size());
            Assert.AreEqual(200, last);

            last = this.queue.Dequeue();
            
            Assert.AreEqual(0, this.queue.Size());
            Assert.AreEqual(0, last);
        }
    }
}