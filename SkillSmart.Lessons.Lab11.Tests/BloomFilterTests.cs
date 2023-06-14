using AlgorithmsDataStructures;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SkillSmart.Lessons.Lab11.Tests
{
    [TestClass]
    public class BloomFilterTests
    {
        private BloomFilter filter;

        [TestInitialize]
        public void Init()
        {
            filter = new BloomFilter(32);
        }

        [TestMethod]
        [DataRow("0123456789")]
        [DataRow("1234567890")]
        [DataRow("2345678901")]
        [DataRow("3456789012")]
        [DataRow("4567890123")]
        [DataRow("5678901234")]
        [DataRow("6789012345")]
        [DataRow("7890123456")]
        [DataRow("8901234567")]
        [DataRow("9012345678")]
        public void Intersection1Test(string input)
        {
            filter.Add(input);

            var exists = filter.IsValue(input);

            Assert.IsTrue(exists);
        }

        [TestMethod]
        [DataRow("5678901234")]
        [DataRow("6789012345")]
        [DataRow("7890123456")]
        [DataRow("8901234567")]
        [DataRow("9012345678")]
        public void Intersection2Test(string input)
        {
            filter.Add("0123456789");
            filter.Add("1234567890");
            filter.Add("2345678901");
            filter.Add("3456789012");
            filter.Add("4567890123");

            var exists = filter.IsValue(input);

            Assert.IsFalse(exists);
        }
    }
}