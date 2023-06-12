using AlgorithmsDataStructures;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace SkillSmart.Lessons.Lab10.Tests
{
    [TestClass]
    public class DifferenceTests
    {
        private PowerSet<string> set1;
        private PowerSet<string> set2;

        [TestInitialize]
        public void Init() 
        {
            set1 = new PowerSet<string>();
            set2 = new PowerSet<string>();
        }

        [TestMethod]
        public void DifferenceEmtpySetsTest()
        {
            var set = set1.Difference(set2);

            Assert.AreEqual(0, set.Size());
        }

        [TestMethod]
        public void DifferenceSets1Test()
        {
            set1.Put("Quick");
            set1.Put("fox");

            set2.Put("jump");
            set2.Put("over");

            var set = set1.Difference(set2);

            Assert.AreEqual(2, set.Size());
        }

        [TestMethod]
        public void DifferenceSets2Test()
        {
            set1.Put("Quick");
            set1.Put("fox");
            set1.Put("jump");
            set1.Put("over");

            set2.Put("jump");
            set2.Put("over");

            var set = set1.Difference(set2);

            Assert.AreEqual(2, set.Size());
        }

        [TestMethod]
        public void DifferenceSets3Test()
        {
            set1.Put("Quick");
            set1.Put("fox");

            set2.Put("Quick");
            set2.Put("fox");
            set2.Put("jump");
            set2.Put("over");

            var set = set1.Difference(set2);

            Assert.AreEqual(0, set.Size());
        }

        [TestMethod]
        public void DifferenceSets4Test()
        {
            set1.Put("Quick");
            set1.Put("fox");
            set1.Put("jump");
            set1.Put("over");

            set2.Put("Quick");
            set2.Put("fox");
            set2.Put("jump");
            set2.Put("over");

            var set = set1.Difference(set2);

            Assert.AreEqual(0, set.Size());
        }

        [TestMethod]
        public void DifferenceBigSets1Test()
        {
            var generator = new StringGenerator();

            var corpus = generator.Generate(20_000);

            foreach (var s in corpus.Take(5_000))
                set1.Put(s);

            foreach (var s in corpus.Skip(5_000).Take(5_000))
                set2.Put(s);

            var set = set1.Difference(set2);

            Assert.AreEqual(5_000, set.Size());
        }

        [TestMethod]
        public void DifferenceBigSets2Test()
        {
            var generator = new StringGenerator();

            var corpus = generator.Generate(20_000);

            foreach (var s in corpus.Take(10_000))
                set1.Put(s);

            foreach (var s in corpus.Take(10_000))
                set2.Put(s);

            var set = set1.Difference(set2);

            Assert.AreEqual(0, set.Size());
        }
   }
}