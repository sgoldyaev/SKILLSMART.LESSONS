using AlgorithmsDataStructures;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace SkillSmart.Lessons.Lab10.Tests
{
    [TestClass]
    public class PutTests
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

            var hasAny = set.slots.Any(x=>x != null);

            Assert.IsFalse(hasAny);
        }

        [TestMethod]
        public void PutStringTest()
        {
            set.Put("Quik");

            var quickSlots = set.slots.Count(x => x == "Quik");
            var noQuikSlots = set.slots.Count(x => x != null && x != "Quik");

            Assert.AreEqual(1, quickSlots);
            Assert.AreEqual(0, noQuikSlots);
        }

        [TestMethod]
        public void PutStringTwiseTest()
        {
            set.Put("Quik");
            set.Put("Quik");

            var quickSlots = set.slots.Count(x => x == "Quik");
            var noQuikSlots = set.slots.Count(x => x != null && x != "Quik");

            Assert.AreEqual(1, quickSlots);
            Assert.AreEqual(0, noQuikSlots);
        }

        [TestMethod]
        public void PutTwoStringsTest()
        {
            set.Put("Quik");
            set.Put("fox");

            var quickSlots = set.slots.Count(x => x == "Quik");
            var foxSlots = set.slots.Count(x => x == "fox");
            var noOtherSlots = set.slots.Count(x => x != null && x != "Quik" && x != "fox");

            Assert.AreEqual(1, quickSlots);
            Assert.AreEqual(1, foxSlots);
            Assert.AreEqual(0, noOtherSlots);
        }
   }
}