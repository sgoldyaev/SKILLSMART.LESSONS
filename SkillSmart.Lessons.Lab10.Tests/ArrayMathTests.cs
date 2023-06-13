using AlgorithmsDataStructures;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SkillSmart.Lessons.Lab10.Tests
{
    [TestClass]
    public class ArrayMathTests
    {
        private string[] array1;
        private string[] array2;
        private string[] array3;
        private string[] array4;
        private string[] array5;

        [TestInitialize]
        public void Init() 
        {
            array1 = new string[] { null, "20", "10", "AA", null, "BB" };
            array2 = new string[] { null, "30", "CC", "10", null, "AA" };
            array3 = new string[] { null, "40", "EE", "50", null, "DD" };
            array4 = new string[] { "Quick", "fox", "jump", "over" };
            array5 = new string[] { "jump", "over" };
        }

        [TestMethod]
        public void Intersection1Test()
        {
            var intersection = ArrayMath.Intersect(array1, array2);

            CollectionAssert.AreEquivalent(new []{ "10", "AA" }, intersection);
        }

        [TestMethod]
        public void Intersection2Test()
        {
            var intersection = ArrayMath.Intersect(array2, array1);

            CollectionAssert.AreEquivalent(new []{ "10", "AA" }, intersection);
        }

        [TestMethod]
        public void Union1Test()
        {
            var union = ArrayMath.Union(array1, array2);

            CollectionAssert.AreEquivalent(new []{ "10", "20", "30", "AA", "BB", "CC" }, union);
        }

        [TestMethod]
        public void Union2Test()
        {
            var union = ArrayMath.Union(array2, array1);

            CollectionAssert.AreEquivalent(new []{ "10", "20", "30", "AA", "BB", "CC" }, union);
        }

        [TestMethod]
        public void Except1Test()
        {
            var union = ArrayMath.Union(array1, array2);

            CollectionAssert.AreEquivalent(new []{ "10", "20", "30", "AA", "BB", "CC" }, union);
        }

        [TestMethod]
        public void Except2Test()
        {
            var except = ArrayMath.Except(array2, array1);

            CollectionAssert.AreEquivalent(new []{ "30", "CC" }, except);
        }

        [TestMethod]
        public void Except3Test()
        {
            var except = ArrayMath.Except(array1, array3);

            CollectionAssert.AreEquivalent(new []{ "10", "20", "AA", "BB" }, except);
        }

        [TestMethod]
        public void Except4Test()
        {
            var except = ArrayMath.Except(array4, array5);

            CollectionAssert.AreEquivalent(new []{ "fox", "Quick" }, except);
        }
  }
}