using AlgorithmsDataStructures;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SkillSmart.Lessons.Lab10.Tests
{
    [TestClass]
    public class GetTests
    {
        private PowerSet<string> set;

        [TestInitialize]
        public void Init() 
        {
            set = new PowerSet<string>();
        }

        [TestMethod]
        public void GetNullStringFromEmptyTest()
        {
            var get = set.Get(null);

            Assert.IsFalse(get);
        }

        [TestMethod]
        public void GetNotNullStringFromEmptyTest()
        {
            var get = set.Get("Quik");

            Assert.IsFalse(get);
        }

        [TestMethod]
        public void GetNullStringTest()
        {
            set.Put("Quik");
            set.Put("fox");
            set.Put("jump");

            var get = set.Get(null);

            Assert.IsFalse(get);
        }

        [TestMethod]
        public void GetExistedStringTest()
        {
            set.Put("Quick");
            set.Put("fox");
            set.Put("jump");

            var get = set.Get("Quick");

            Assert.IsTrue(get);
        }

        [TestMethod]
        public void GetNonExistedStringTest()
        {
            set.Put("Quik");
            set.Put("fox");
            set.Put("jump");

            var get = set.Get("Quick fox jump");

            Assert.IsFalse(get);
        }
   }
}