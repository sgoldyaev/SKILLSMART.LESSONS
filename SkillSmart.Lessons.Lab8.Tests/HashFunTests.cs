using AlgorithmsDataStructures;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SkillSmart.Lessons.Lab8.Tests
{
    [TestClass]
    public class HashFunTests
    {
        private readonly bool asc = true;
        private HashTable table;

        [TestInitialize]
        public void Init() 
        {
            table = new HashTable(7, 3);
        }

        [TestMethod]
        public void GetNonNullStringHashTest()
        {
            var hash = table.HashFun("Quick");

            Assert.IsNotNull(hash);
        }

        [TestMethod]
        public void GetTwoStringsHashTest()
        {
            var hash1 = table.HashFun("Quick");
            var hash2 = table.HashFun("Quick");

            Assert.AreEqual(hash1, hash2);
        }

        [TestMethod]
        public void GetNullStringHashTest()
        {
            var hash = table.HashFun(null);

            Assert.AreEqual(-1, hash);
        }

        [TestMethod]
        public void GetEmptyStringHashTest()
        {
            var hash = table.HashFun(string.Empty);

            Assert.IsNotNull(hash);
        }
    }
}