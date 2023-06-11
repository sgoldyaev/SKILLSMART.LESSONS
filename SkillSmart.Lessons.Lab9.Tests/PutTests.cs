using AlgorithmsDataStructures;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace SkillSmart.Lessons.Lab9.Tests
{
    [TestClass]
    public class PutTests
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

            Assert.IsTrue(dic.slots.All(x => x == null));
        }

        [TestMethod]
        public void PutNotNullStringTest()
        {
            dic.Put("key1", "value1");

            Assert.IsTrue(dic.slots.Count(x => x == "key1") == 1);
            Assert.IsTrue(dic.slots.Count(x => !string.IsNullOrEmpty(x) && x != "key1") == 0);

            Assert.IsTrue(dic.values.Count(x => x == "value1") == 1);
            Assert.IsTrue(dic.values.Count(x => !string.IsNullOrEmpty(x) && x != "value1") == 0);
        }

        [TestMethod]
        public void PutTwoStringTest()
        {
            dic.Put("key1", "value1");
            dic.Put("key2", "value2");

            Assert.IsTrue(dic.slots.Count(x => x == "key1") == 1);
            Assert.IsTrue(dic.slots.Count(x => x == "key2") == 1);
            Assert.IsTrue(dic.slots.Count(x => !string.IsNullOrEmpty(x) && x != "key1" && x != "key2") == 0);

            Assert.IsTrue(dic.values.Count(x => x == "value1") == 1);
            Assert.IsTrue(dic.values.Count(x => x == "value2") == 1);
            Assert.IsTrue(dic.values.Count(x => !string.IsNullOrEmpty(x) && x != "value1" && x != "value2") == 0);
        }

        [TestMethod]
        public void PutStringTwiseTest()
        {
            dic.Put("key1", "value1");
            dic.Put("key1", "value2");

            Assert.IsTrue(dic.slots.Count(x => x == "key1") == 1);
            Assert.IsTrue(dic.slots.Count(x => !string.IsNullOrEmpty(x) && x != "key1") == 0);

            Assert.IsTrue(dic.values.Count(x => x == "value1") == 0);
            Assert.IsTrue(dic.values.Count(x => x == "value2") == 1);
            Assert.IsTrue(dic.values.Count(x => !string.IsNullOrEmpty(x) && x != "value2") == 0);
        }
    }
}