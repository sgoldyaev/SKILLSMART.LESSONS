using AlgorithmsDataStructures;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SkillSmart.Lessons.Lab3.Tests
{
    [TestClass]
    public class PopTests
    {
        private Stack<int> stack;

        [TestInitialize]
        public void Init() 
        {
            stack = new Stack<int>();
            stack.Push(100);
            stack.Push(200);
        }

        [TestMethod]
        public void PopSingleElementTest()
        {
            var last = this.stack.Pop();
            
            Assert.AreEqual(1, this.stack.Size());
            Assert.AreEqual(200, last);
        }

        [TestMethod]
        public void PopTwoElementsTest()
        {
            var last = this.stack.Pop();
            
            Assert.AreEqual(1, this.stack.Size());
            Assert.AreEqual(200, last);

            last = this.stack.Pop();
            
            Assert.AreEqual(0, this.stack.Size());
            Assert.AreEqual(100, last);
        }

        [TestMethod]
        public void PopThreeElementsTest()
        {
            var last = this.stack.Pop();
            
            Assert.AreEqual(1, this.stack.Size());
            Assert.AreEqual(200, last);

            last = this.stack.Pop();
            
            Assert.AreEqual(0, this.stack.Size());
            Assert.AreEqual(100, last);

            last = this.stack.Pop();
            
            Assert.AreEqual(0, this.stack.Size());
            Assert.AreEqual(0, last);
        }
    }
}