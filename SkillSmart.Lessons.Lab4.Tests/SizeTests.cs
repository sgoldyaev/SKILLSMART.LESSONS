using AlgorithmsDataStructures;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SkillSmart.Lessons.Lab3.Tests
{
    [TestClass]
    public class SizeTests
    {
        private Stack<int> stack;

        [TestInitialize]
        public void Init() 
        {
            stack = new Stack<int>();
        }

        [TestMethod]
        public void PushSingleElementTest()
        {
            this.stack.Push(100);
            
            Assert.AreEqual(1, this.stack.Size());
        }

        [TestMethod]
        public void PushTwoElementTest()
        {
            this.stack.Push(100);
            this.stack.Push(200);
            
            Assert.AreEqual(2, this.stack.Size());
        }   }
}