using System;
using AlgorithmsDataStructures;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SkillSmart.Lessons.Lab3.Tests
{
    [TestClass]
    public class PalindromeTests
    {
        private Deque<char> queue;

        [TestInitialize]
        public void Init() 
        {
            queue = new Deque<char>();
        }

        [TestMethod]
        [DataRow("боб")]
        [DataRow("АРА")]
        [DataRow("АБОБА")]
        [DataRow("madam")]
        public void IsItPalindromeTest(string input)
        {
            foreach (var c in input)
            {
                this.queue.AddFront(c);
            }

            var output = new char[input.Length];
            var index = 0;
            
            while (queue.Size() > 0)
            {
                output[index] = queue.RemoveTail();

                index++;
            }
            
            CollectionAssert.AreEqual(input.ToCharArray(), output);
        }
   }
}