using AlgorithmsDataStructures;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace SkillSmart.Lessons.Lab10.Tests
{
    [TestClass]
    public class SizeTests
    {
        private PowerSet<string> set;

        [TestInitialize]
        public void Init() 
        {
            set = new PowerSet<string>();
        }

        [TestMethod]
        public void PutNullStringTest()
        {
            set.Put(null);

            Assert.AreEqual(0, set.Size());
        }

        [TestMethod]
        public void PutStringTest()
        {
            set.Put("Quick");

            Assert.AreEqual(1, set.Size());
        }

        [TestMethod]
        public void PutStringTwiseTest()
        {
            set.Put("Quick");
            set.Put("Quick");

            Assert.AreEqual(1, set.Size());
        }

        [TestMethod]
        public void PutTwoStringsTest()
        {
            set.Put("Quick");
            set.Put("fox");

            Assert.AreEqual(2, set.Size());
        }

        [TestMethod]
        public void RemoveFromEmptySetTest()
        {
            set.Remove("Quick");

            Assert.AreEqual(0, set.Size());
        }

        [TestMethod]
        public void RemoveOneStringTest()
        {
            set.Put("Quick");
            set.Put("fox");

            set.Remove("Quick");

            Assert.AreEqual(1, set.Size());
        }

        [TestMethod]
        public void RemoveAllStringsTest()
        {
            set.Put("Quick");
            set.Put("fox");

            set.Remove("Quick");
            set.Remove("fox");

            Assert.AreEqual(0, set.Size());
        }
   }
}