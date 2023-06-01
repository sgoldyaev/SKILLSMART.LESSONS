using AlgorithmsDataStructures;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SkillSmart.Lessons.Lab3.Tests
{
    [TestClass]
    public class AddTailTests
    {
        private Deque<int> queue;

        [TestInitialize]
        public void Init() 
        {
            this.queue = new Deque<int>();
            this.queue.AddTail(100);
            this.queue.AddTail(200);
            this.queue.AddTail(300);
            this.queue.AddTail(400);
        }

        [TestMethod]
        public void RemoveSingleFrontElementTest()
        {
            var last = queue.RemoveFront();
            
            Assert.AreEqual(3, this.queue.Size());
            Assert.AreEqual(100, last);
        }

        [TestMethod]
        public void RemoveTwoFrontElementsTest()
        {
            var last = queue.RemoveFront();
            
            Assert.AreEqual(3, this.queue.Size());
            Assert.AreEqual(100, last);

            last = queue.RemoveFront();
            
            Assert.AreEqual(2, this.queue.Size());
            Assert.AreEqual(200, last);
        }

        [TestMethod]
        public void RemoveSingleTailElementTest()
        {
            var last = queue.RemoveTail();
            
            Assert.AreEqual(3, this.queue.Size());
            Assert.AreEqual(400, last);
        }

        [TestMethod]
        public void RemoveTwoTailElementsTest()
        {
            var last = queue.RemoveTail();
            
            Assert.AreEqual(3, this.queue.Size());
            Assert.AreEqual(400, last);

            last = queue.RemoveTail();
            
            Assert.AreEqual(2, this.queue.Size());
            Assert.AreEqual(300, last);
        }

        [TestMethod]
        public void RemoveSingleFromAndSingleTailElementsTest()
        {
            var last = queue.RemoveFront();
            
            Assert.AreEqual(3, this.queue.Size());
            Assert.AreEqual(100, last);

            last = queue.RemoveTail();
            
            Assert.AreEqual(2, this.queue.Size());
            Assert.AreEqual(400, last);
        }

        [TestMethod]
        public void RemoveMixElementsTest()
        {
            var last = queue.RemoveFront();
            
            Assert.AreEqual(3, this.queue.Size());
            Assert.AreEqual(100, last);

            last = queue.RemoveTail();
            
            Assert.AreEqual(2, this.queue.Size());
            Assert.AreEqual(400, last);

            last = queue.RemoveFront();
            
            Assert.AreEqual(1, this.queue.Size());
            Assert.AreEqual(200, last);

            last = queue.RemoveTail();
            
            Assert.AreEqual(0, this.queue.Size());
            Assert.AreEqual(300, last);
        }
   }
}