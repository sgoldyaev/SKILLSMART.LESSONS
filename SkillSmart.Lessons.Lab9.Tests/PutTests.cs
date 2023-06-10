using AlgorithmsDataStructures;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace SkillSmart.Lessons.Lab8.Tests
{
    [TestClass]
    public class PutTests
    {
        private readonly bool asc = true;
        private NativeDictionary<string> dic;

        [TestInitialize]
        public void Init() 
        {
            dic = new NativeDictionary<string>(4);
        }

        [TestMethod]
        public void PutNullStringTest()
        {
            dic.Put(null, "value1");

            var value = dic.Get(null);

            Assert.IsNull(value);
        }

        [TestMethod]
        public void PutNotNullStringTest()
        {
            dic.Put("key1", "value1");

            var slot = dic.Get("key1");

            Assert.AreNotEqual(-1, slot);
        }
    }
}