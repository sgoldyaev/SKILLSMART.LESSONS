using AlgorithmsDataStructures;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SkillSmart.Lessons.Lab3.Tests
{
    [TestClass]
    public class PeekTests
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
        public void PeekTwoElementsTest()
        {
            var last = this.stack.Peek();
            
            Assert.AreEqual(2, this.stack.Size());
            Assert.AreEqual(200, last);

            last = this.stack.Peek();
            
            Assert.AreEqual(2, this.stack.Size());
            Assert.AreEqual(200, last);
        }
    }
}