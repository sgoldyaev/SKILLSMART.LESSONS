using AlgorithmsDataStructures;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SkillSmart.Lessons.Lab3.Tests
{
    [TestClass]
    public class CircleBufferTests
    {
        private CircleBuffer<int> queue;

        [TestInitialize]
        public void Init() 
        {
            this.queue = new CircleBuffer<int>(5);
            this.queue.Enqueue(100);
            this.queue.Enqueue(200);
            this.queue.Enqueue(300);
            this.queue.Enqueue(400);
        }

        [TestMethod]
        public void GetSizeTest()
        {
            Assert.AreEqual(4, this.queue.Size());
        }

        [TestMethod]
        public void EnqueueSingleElementTest()
        {
            queue.Enqueue(500);
            
            Assert.AreEqual(5, this.queue.Size());
        }

        [TestMethod]
        public void EnqueueTwoElementsTest()
        {
            queue.Enqueue(500);
            queue.Enqueue(600);
            
            Assert.AreEqual(5, this.queue.Size());
        }

        [TestMethod]
        public void EnqueueTwoDequeueTreeElementsTest()
        {
            queue.Enqueue(500);
            queue.Enqueue(600);
            
            Assert.AreEqual(5, this.queue.Size());
            
            var last = this.queue.Dequeue();
            
            Assert.AreEqual(4, this.queue.Size());
            Assert.AreEqual(200, last);

            last = this.queue.Dequeue();
            
            Assert.AreEqual(3, this.queue.Size());
            Assert.AreEqual(300, last);
        }

        [TestMethod]
        public void DequeueTwoElementsTest()
        {
            var last = this.queue.Dequeue();
            
            Assert.AreEqual(3, this.queue.Size());
            Assert.AreEqual(100, last);

            last = this.queue.Dequeue();
            
            Assert.AreEqual(2, this.queue.Size());
            Assert.AreEqual(200, last);
        }

        [TestMethod]
        public void DequeueThreeElementsTest()
        {
            var last = this.queue.Dequeue();
            
            Assert.AreEqual(3, this.queue.Size());
            Assert.AreEqual(100, last);

            last = this.queue.Dequeue();
            
            Assert.AreEqual(2, this.queue.Size());
            Assert.AreEqual(200, last);

            last = this.queue.Dequeue();
            
            Assert.AreEqual(1, this.queue.Size());
            Assert.AreEqual(300, last);
        }
    }
}