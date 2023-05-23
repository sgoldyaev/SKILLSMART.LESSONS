using System;
using AlgorithmsDataStructures;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SkillSmart.Lessons.Lab3.Tests
{
    [TestClass]
    public class BalanceTests
    {
        private Stack<int> stack;

        [TestInitialize]
        public void Init() 
        {
            stack = new Stack<int>();
        }

        [TestMethod]
        [DataRow("(()((())()))")]
        [DataRow("(()()(()")]
        public void Balance1Test(string input)
        {
            var index = 0;
            for (index = 0; index < input.Length; index ++)
            {
                var symbol = input[index];
                
                if (symbol == '(')
                    this.stack.Push(1);
                
                else if (symbol == ')')
                    if (this.stack.Pop() == 0)
                        break;
            }

            Assert.AreEqual(index, input.Length, "Цикл преждевременно завершился");
            Assert.AreEqual(0, this.stack.Size(), "В стеке остались элементы");
            Assert.IsTrue(index == input.Length && this.stack.Size() == 0, $"Последовательность {input} не сбалансированна");
        }
    }
}