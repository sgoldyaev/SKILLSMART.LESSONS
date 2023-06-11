using AlgorithmsDataStructures;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SkillSmart.Lessons.Lab9.Tests
{
    [TestClass]
    public class GetTests
    {
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

            Assert.AreEqual("value1", slot);
        }

        [TestMethod]
        public void PutStringTwiseTest()
        {
            dic.Put("key1", "value1");
            dic.Put("key1", "value2");

            var slot = dic.Get("key1");

            Assert.AreEqual("value2", slot);
        }
    }
}