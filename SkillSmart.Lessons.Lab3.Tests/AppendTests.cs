using AlgorithmsDataStructures;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SkillSmart.Lessons.Lab3.Tests.Data;

namespace SkillSmart.Lessons.Lab3.Tests
{
    [TestClass]
    public class AppendTests
    {
        private DynArray<int> dinArray;

        [TestInitialize]
        public void Init() 
        {
            dinArray = new DynArray<int>();
        }

        [TestMethod]
        public void CreateDefaultArrayTest()
        {
            Assert.AreEqual(DynArray<int>.defaultSize, dinArray.array.Length);
            
            CollectionAssert.AreEqual(ArrayOf16Items.Empty, dinArray.array);
        }

        [TestMethod]
        public void Add16ItemsToArrayTest()
        {
            dinArray.From(ArrayOf16Items.Full);

            Assert.AreEqual(DynArray<int>.defaultSize, dinArray.count);
            Assert.AreEqual(DynArray<int>.defaultSize, dinArray.capacity);
            Assert.AreEqual(DynArray<int>.defaultSize, dinArray.array.Length);
            
            CollectionAssert.AreEqual(ArrayOf16Items.Full, dinArray.array);
        }

        [TestMethod]
        public void Add17ItemsToArrayTest()
        {
            for (var index = 0; index < 17; index++)
                dinArray.Append(index + 1);
            
            Assert.AreEqual(17, dinArray.count);
            Assert.AreEqual(32, dinArray.capacity);
            Assert.AreEqual(32, dinArray.array.Length);
            
            CollectionAssert.AreEqual(ArrayOf16Items.AddLast1Element, dinArray.array);
        }

        [TestMethod]
        public void Add32ItemsToArrayTest()
        {
            dinArray.From(ArrayOf32Items.Full);

            Assert.AreEqual(32, dinArray.count);
            Assert.AreEqual(32, dinArray.capacity);
            Assert.AreEqual(32, dinArray.array.Length);
            
            CollectionAssert.AreEqual(ArrayOf32Items.Full, dinArray.array);
        }
   }
}