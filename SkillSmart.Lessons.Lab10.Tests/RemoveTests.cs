using AlgorithmsDataStructures;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace SkillSmart.Lessons.Lab10.Tests
{
    [TestClass]
    public class RemoveTests
    {
        private PowerSet<string> set;

        [TestInitialize]
        public void Init() 
        {
            set = new PowerSet<string>();
            set.Put("Quick");
            set.Put("fox");
            set.Put("jump");
        }

        [TestMethod]
        public void RemoveNullStringTest()
        {
            var removed = set.Remove(null);

            var hasQuick = set.slots.Count(x => x == "Quick");
            var hasFox = set.slots.Count(x => x == "fox");
            var hasJump = set.slots.Count(x => x == "jump");
            var hasOthers = set.slots.Count(x => x != null && x != "Quick" && x != "fox" && x != "jump");

            Assert.IsFalse(removed);
            Assert.AreEqual(1, hasQuick);
            Assert.AreEqual(1, hasFox);
            Assert.AreEqual(1, hasJump);
            Assert.AreEqual(0, hasOthers);
        }

        [TestMethod]
        public void RemoveExistingStringTest()
        {
            var removed = set.Remove("Quick");

            var hasQuick = set.slots.Count(x => x == "Quick");
            var hasFox = set.slots.Count(x => x == "fox");
            var hasJump = set.slots.Count(x => x == "jump");
            var hasOthers = set.slots.Count(x => x != null && x != "Quick" && x != "fox" && x != "jump");

            Assert.IsTrue(removed);
            Assert.AreEqual(0, hasQuick);
            Assert.AreEqual(1, hasFox);
            Assert.AreEqual(1, hasJump);
            Assert.AreEqual(0, hasOthers);
        }

        [TestMethod]
        public void RemoveNonExistingStringTest()
        {
            var removed = set.Remove("Quik fox jump");

            var hasQuick = set.slots.Count(x => x == "Quick");
            var hasFox = set.slots.Count(x => x == "fox");
            var hasJump = set.slots.Count(x => x == "jump");
            var hasOthers = set.slots.Count(x => x != null && x != "Quick" && x != "fox" && x != "jump");

            Assert.IsFalse(removed);
            Assert.AreEqual(1, hasQuick);
            Assert.AreEqual(1, hasFox);
            Assert.AreEqual(1, hasJump);
            Assert.AreEqual(0, hasOthers);
        }

        [TestMethod]
        public void RemoveAllStringsTest()
        {
            var removedQuick = set.Remove("Quick");
            var removedFox = set.Remove("fox");
            var removedJump = set.Remove("jump");

            var hasQuick = set.slots.Count(x => x == "Quick");
            var hasFox = set.slots.Count(x => x == "fox");
            var hasJump = set.slots.Count(x => x == "jump");
            var hasOthers = set.slots.Count(x => x != null && x != "Quick" && x != "fox" && x != "jump");

            Assert.IsTrue(removedQuick);
            Assert.IsTrue(removedFox);
            Assert.IsTrue(removedJump);

            Assert.AreEqual(0, hasQuick);
            Assert.AreEqual(0, hasFox);
            Assert.AreEqual(0, hasJump);
            Assert.AreEqual(0, hasOthers);
        }

        [TestMethod]
        public void RemoveFromEmptySetTest()
        {
            set = new PowerSet<string>();

            var removedQuick = set.Remove("Quik");

            var hasQuick = set.slots.Count(x => x == "Quick");
            var hasOthers = set.slots.Count(x => x != null && x != "Quick");

            Assert.IsFalse(removedQuick);

            Assert.AreEqual(0, hasQuick);
            Assert.AreEqual(0, hasOthers);
        }
   }
}