using AlgorithmsDataStructures;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SkillSmart.Lessons.Lab3.Tests
{
    [TestClass]
    public class DinArrayAppendTests
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
            var defaultArray = System.Array.ConvertAll(new int[16], v => 0);

            Assert.AreEqual(DynArray<int>.defaultSize, dinArray.array.Length);
            
            CollectionAssert.AreEqual(defaultArray, dinArray.array);
        }

        [TestMethod]
        public void Add16ItemsToArrayTest()
        {
            var arrayOf15Items = new int[16];

            for (var index = 0; index < 16; index++)
            {
                arrayOf15Items[index] = index + 1;

                dinArray.Append(index + 1);
            }

            Assert.AreEqual(DynArray<int>.defaultSize, dinArray.count);
            Assert.AreEqual(DynArray<int>.defaultSize, dinArray.capacity);
            Assert.AreEqual(DynArray<int>.defaultSize, dinArray.array.Length);
            CollectionAssert.AreEqual(arrayOf15Items, dinArray.array);
        }

        [TestMethod]
        public void Add17ItemsToArrayTest()
        {
            var arrayOf32Items = new int[32];

            for (var index = 0; index < 17; index++)
            {
                arrayOf32Items[index] = index + 1;

                dinArray.Append(index + 1);
            }
            
            Assert.AreEqual(17, dinArray.count);
            Assert.AreEqual(arrayOf32Items.Length, dinArray.capacity);
            Assert.AreEqual(arrayOf32Items.Length, dinArray.array.Length);
            
            CollectionAssert.AreEqual(arrayOf32Items, dinArray.array);
        }

        [TestMethod]
        public void Add32ItemsToArrayTest()
        {
            var arrayOf32Items = new int[32];

            for (var index = 0; index < 32; index++)
            {
                arrayOf32Items[index] = index + 1;

                dinArray.Append(index + 1);
            }
            
            Assert.AreEqual(arrayOf32Items.Length, dinArray.count);
            Assert.AreEqual(arrayOf32Items.Length, dinArray.capacity);
            Assert.AreEqual(arrayOf32Items.Length, dinArray.array.Length);
            
            CollectionAssert.AreEqual(arrayOf32Items, dinArray.array);
        }
   }
}