using AlgorithmsDataStructures;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SkillSmart.Lessons.Lab11.Tests
{
    [TestClass]
    public class BloomFilterTests
    {
        private readonly string[] data = new string[]
        {
            "0123456789",
            "1234567890",
            "2345678901",
            "3456789012",
            "4567890123",
            "5678901234",
            "6789012345",
            "7890123456",
            "8901234567",
            "9012345678",
        };
        private BloomFilter filter;

        [TestInitialize]
        public void Init()
        {
            filter = new BloomFilter(32);
        }

        [TestMethod]
        public void Intersection1Test()
        {
            filter.Add(data[0]);

            var isValue1 = filter.IsValue(data[0]);

            Assert.IsTrue(isValue1);
        }
    }
}