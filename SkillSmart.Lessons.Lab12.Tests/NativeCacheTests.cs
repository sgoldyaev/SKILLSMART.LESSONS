using AlgorithmsDataStructures;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace SkillSmart.Lessons.Lab12.Tests
{
    [TestClass]
    public class NativeCacheTests
    {
        private NativeCache<string> cache;

        [TestInitialize]
        public void Init()
        {
            cache = new NativeCache<string>();
        }

        [TestMethod]
        //[DataRow("0123456789")]
        //[DataRow("1234567890")]
        //[DataRow("2345678901")]
        //[DataRow("3456789012")]
        //[DataRow("4567890123")]
        //[DataRow("5678901234")]
        //[DataRow("6789012345")]
        //[DataRow("7890123456")]
        //[DataRow("8901234567")]
        //[DataRow("9012345678")]
        public void GetEmptyCacheTests()
        {
            var actual = cache.Get("key");

            Assert.IsNull(actual);
        }

        [TestMethod]
        public void GetExistingKeyTests()
        {
            cache.Put("key1", "value1");

            var actual = cache.Get("key1");

            Assert.AreEqual("value1", actual);
        }

        [TestMethod]
        public void GetNonExistingKeyTests()
        {
            cache.Put("key1", "value1");

            var actual = cache.Get("key2");

            Assert.IsNull(actual);
        }

        [TestMethod]
        public void RemoveExistingKeyTests()
        {
            cache.Put("key1", "value1");

            var removed = cache.Remove("key1");

            Assert.IsTrue(removed);
        }

        [TestMethod]
        public void RemoveNonExistingKeyTests()
        {
            cache.Put("key1", "value1");

            var removed = cache.Remove("key2");

            Assert.IsFalse(removed);
        }

        [TestMethod]
        public void HitsOneTest()
        {
            cache.Put("key1", "value1");

            var value1 = cache.Get("key1");
            var key1 = cache.SeekSlot("key1");

            Assert.IsFalse(cache.hits[key1] == 1);
        }

        [TestMethod]
        public void HitsTwiseTest()
        {
            cache.Put("key1", "value1");

            var value1 = cache.Get("key1");
            var value2 = cache.Get("key1");
            var key1 = cache.SeekSlot("key1");

            Assert.IsFalse(cache.hits[key1] == 2);
        }

        [TestMethod]
        public void PutWithReplacemenTest()
        {
            for (var index = 0; index < 10; index++)
            {
                cache.slots[index] = "no data " + index;
                cache.values[index] = "not value " + index;
                cache.hits[index] = 10;
            }

            cache.hits[0] = 2;
            cache.count = 10;

            cache.Put("key1", "value1");

            var newValue = cache.Get("key1");

            Assert.AreEqual("value1", newValue);
        }
    }
}