using AlgorithmsDataStructures;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SkillSmart.Lessons.Lab9.Tests
{
    [TestClass]
    public class IsKeyTests
    {
        private NativeDictionary<string> dic;

        [TestInitialize]
        public void Init() 
        {
            dic = new NativeDictionary<string>(4);
        }

        [TestMethod]
        public void IsKeyNullStringTest()
        {
            var isKey = dic.IsKey(null);

            Assert.IsFalse(isKey);
        }

        [TestMethod]
        public void IsKeyNotExistedTest()
        {
            var isKey = dic.IsKey("key1");

            Assert.IsFalse(isKey);
        }

        [TestMethod]
        public void IsKeyExistedTest()
        {
            dic.Put("key1", "value1");
            
            var isKey = dic.IsKey("key1");

            Assert.IsTrue(isKey);
        }

        [TestMethod]
        public void IsKeyExisted2Test()
        {
            dic.Put("key1", "value1");
            
            var isKey = dic.IsKey("value1");

            Assert.IsFalse(isKey);
        }

        [TestMethod]
        public void PutStringTwiseTest()
        {
            dic.Put("key1", "value1");
            dic.Put("key1", "value2");

            var isKey = dic.IsKey("key1");

            Assert.IsTrue(isKey);
        }
    }
}