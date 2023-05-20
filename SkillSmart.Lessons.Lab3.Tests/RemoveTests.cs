using AlgorithmsDataStructures;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SkillSmart.Lessons.Lab3.Tests.Data;

namespace SkillSmart.Lessons.Lab3.Tests
{
    [TestClass]
    public class RemoveTests
    {
        private DynArray<int> dinArray;

        [TestInitialize]
        public void Init() 
        {
            dinArray = new DynArray<int>();
        }

        #region 16 items array
        [TestMethod]
        public void RemoveFirstOneItemFrom16ItemsArrayTest()
        {
            dinArray.From(ArrayOf16Items.Full);

            dinArray.Remove(0);
            
            Assert.AreEqual(15, dinArray.count);
            Assert.AreEqual(DynArray<int>.defaultSize, dinArray.capacity);
            Assert.AreEqual(DynArray<int>.defaultSize, dinArray.array.Length);
            CollectionAssert.AreEqual(ArrayOf16Items.FirstOneIsMissed, dinArray.array);
        }

        [TestMethod]
        public void RemoveFirstTwoItemFrom16ItemsArrayTest()
        {
            dinArray.From(ArrayOf16Items.Full);

            dinArray.Remove(0);
            dinArray.Remove(0);
            
            Assert.AreEqual(14, dinArray.count);
            Assert.AreEqual(DynArray<int>.defaultSize, dinArray.capacity);
            Assert.AreEqual(DynArray<int>.defaultSize, dinArray.array.Length);
            CollectionAssert.AreEqual(ArrayOf16Items.FirstTwoIsMissed, dinArray.array);
        }

        [TestMethod]
        public void RemoveLastOneItemFrom16ItemsArrayTest()
        {
            dinArray.From(ArrayOf16Items.Full);

            dinArray.Remove(15);
            
            Assert.AreEqual(15, dinArray.count);
            Assert.AreEqual(DynArray<int>.defaultSize, dinArray.capacity);
            Assert.AreEqual(DynArray<int>.defaultSize, dinArray.array.Length);
            CollectionAssert.AreEqual(ArrayOf16Items.LastOneIsMissed, dinArray.array);
        }

        [TestMethod]
        public void RemoveLastTwoItemFrom16ItemsArrayTest()
        {
            dinArray.From(ArrayOf16Items.Full);

            dinArray.Remove(15);
            dinArray.Remove(14);
            
            Assert.AreEqual(14, dinArray.count);
            Assert.AreEqual(DynArray<int>.defaultSize, dinArray.capacity);
            Assert.AreEqual(DynArray<int>.defaultSize, dinArray.array.Length);
            CollectionAssert.AreEqual(ArrayOf16Items.LastTwoIsMissed, dinArray.array);
        }

        [TestMethod]
        public void RemoveMiddleOneItemFrom16ItemsArrayTest()
        {
            dinArray.From(ArrayOf16Items.Full);

            dinArray.Remove(4);
            
            Assert.AreEqual(15, dinArray.count);
            Assert.AreEqual(DynArray<int>.defaultSize, dinArray.capacity);
            Assert.AreEqual(DynArray<int>.defaultSize, dinArray.array.Length);
            CollectionAssert.AreEqual(ArrayOf16Items.MiddleOneIsMissed, dinArray.array);
        }

        [TestMethod]
        public void RemoveMiddleTwoItemsFrom16ItemsArrayTest()
        {
            foreach (var item in ArrayOf16Items.Full)
                dinArray.Append(item);

            dinArray.Remove(4);
            dinArray.Remove(4);
            
            Assert.AreEqual(14, dinArray.count);
            Assert.AreEqual(DynArray<int>.defaultSize, dinArray.capacity);
            Assert.AreEqual(DynArray<int>.defaultSize, dinArray.array.Length);
            CollectionAssert.AreEqual(ArrayOf16Items.MiddleTwoIsMissed, dinArray.array);
        }
        #endregion
        
        #region 32 items array
        [TestMethod]
        public void RemoveFirstOneItemFrom32ItemsArrayTest()
        {
            dinArray.From(ArrayOf32Items.Full);

            dinArray.Remove(0);
            
            Assert.AreEqual(31, dinArray.count);
            Assert.AreEqual(32, dinArray.capacity);
            Assert.AreEqual(32, dinArray.array.Length);
            CollectionAssert.AreEqual(ArrayOf32Items.FirstOneIsMissed, dinArray.array);
        }

        [TestMethod]
        public void RemoveFirstTwoItemFrom32ItemsArrayTest()
        {
            dinArray.From(ArrayOf32Items.Full);

            dinArray.Remove(0);
            dinArray.Remove(0);
            
            Assert.AreEqual(30, dinArray.count);
            Assert.AreEqual(32, dinArray.capacity);
            Assert.AreEqual(32, dinArray.array.Length);
            CollectionAssert.AreEqual(ArrayOf32Items.FirstTwoIsMissed, dinArray.array);
        }

        [TestMethod]
        public void RemoveLastOneItemFrom32ItemsArrayTest()
        {
            dinArray.From(ArrayOf32Items.Full);

            dinArray.Remove(31);
            
            Assert.AreEqual(31, dinArray.count);
            Assert.AreEqual(32, dinArray.capacity);
            Assert.AreEqual(32, dinArray.array.Length);
            CollectionAssert.AreEqual(ArrayOf32Items.LastOneIsMissed, dinArray.array);
        }

        [TestMethod]
        public void RemoveLastTwoItemFrom32ItemsArrayTest()
        {
            dinArray.From(ArrayOf32Items.Full);

            dinArray.Remove(31);
            dinArray.Remove(30);
            
            Assert.AreEqual(30, dinArray.count);
            Assert.AreEqual(32, dinArray.capacity);
            Assert.AreEqual(32, dinArray.array.Length);
            CollectionAssert.AreEqual(ArrayOf32Items.LastTwoIsMissed, dinArray.array);
        }

        [TestMethod]
        public void RemoveMiddleOneItemFrom32ItemsArrayTest()
        {
            dinArray.From(ArrayOf32Items.Full);

            dinArray.Remove(4);
            
            Assert.AreEqual(31, dinArray.count);
            Assert.AreEqual(32, dinArray.capacity);
            Assert.AreEqual(32, dinArray.array.Length);
            CollectionAssert.AreEqual(ArrayOf32Items.MiddleOneIsMissed, dinArray.array);
        }

        [TestMethod]
        public void RemoveMiddleTwoItemsFrom32ItemsArrayTest()
        {
            dinArray.From(ArrayOf32Items.Full);

            dinArray.Remove(4);
            dinArray.Remove(4);
            
            Assert.AreEqual(30, dinArray.count);
            Assert.AreEqual(32, dinArray.capacity);
            Assert.AreEqual(32, dinArray.array.Length);
            CollectionAssert.AreEqual(ArrayOf32Items.MiddleTwoIsMissed, dinArray.array);
        }
        #endregion

        #region 32 items array with resize
        [TestMethod]
        public void Remove11ItemFrom32ItemsArrayTest()
        {
            dinArray.From(ArrayOf32Items.Full);

            for (var index = 0; index < 11; index ++)
                dinArray.Remove(0);
            
            Assert.AreEqual(21, dinArray.count);
            Assert.AreEqual(32, dinArray.capacity);
            Assert.AreEqual(32, dinArray.array.Length);
            CollectionAssert.AreEqual(ArrayOf32Items.First11ItemsAreMissed, dinArray.array);
        }

        [TestMethod]
        public void Remove12ItemFrom32ItemsArrayTest()
        {
            dinArray.From(ArrayOf32Items.Full);

            for (var index = 0; index < 12; index ++)
                dinArray.Remove(0);
            
            Assert.AreEqual(20, dinArray.count);
            Assert.AreEqual(20, dinArray.capacity);
            Assert.AreEqual(20, dinArray.array.Length);
            CollectionAssert.AreEqual(ArrayOf32Items.First12ItemsAreMissed, dinArray.array);
        }
        #endregion

        #region 20 items array with resize
        [TestMethod]
        public void Remove4ItemFrom20ItemsArrayTest()
        {
            // NOTE [sg]: make 20 items array
            Remove12ItemFrom32ItemsArrayTest();
            
            for (var index = 0; index < 4; index ++)
                dinArray.Remove(0);

            Assert.AreEqual(16, dinArray.count);
            Assert.AreEqual(20, dinArray.capacity);
            Assert.AreEqual(20, dinArray.array.Length);
            CollectionAssert.AreEqual(ArrayOf20Items.First4ItemsAreMissed, dinArray.array);
        }

        [TestMethod]
        public void Remove5ItemFrom20ItemsArrayTest()
        {
            // NOTE [sg]: make 20 items array
            Remove12ItemFrom32ItemsArrayTest();
            
            for (var index = 0; index < 5; index ++)
                dinArray.Remove(0);

            Assert.AreEqual(15, dinArray.count);
            Assert.AreEqual(20, dinArray.capacity);
            Assert.AreEqual(20, dinArray.array.Length);
            CollectionAssert.AreEqual(ArrayOf20Items.First5ItemsAreMissed, dinArray.array);
        }

        [TestMethod]
        public void Remove7ItemFrom20ItemsArrayTest()
        {
            // NOTE [sg]: make 20 items array
            Remove12ItemFrom32ItemsArrayTest();
            
            for (var index = 0; index < 7; index ++)
                dinArray.Remove(0);

            Assert.AreEqual(13, dinArray.count);
            Assert.AreEqual(20, dinArray.capacity);
            Assert.AreEqual(20, dinArray.array.Length);
            CollectionAssert.AreEqual(ArrayOf20Items.First7ItemsAreMissed, dinArray.array);
        }

        [TestMethod]
        public void Remove8ItemFrom20ItemsArrayTest()
        {
            // NOTE [sg]: make 20 items array
            Remove12ItemFrom32ItemsArrayTest();
            
            for (var index = 0; index < 8; index ++)
                dinArray.Remove(0);

            Assert.AreEqual(12, dinArray.count);
            Assert.AreEqual(16, dinArray.capacity);
            Assert.AreEqual(16, dinArray.array.Length);
            CollectionAssert.AreEqual(ArrayOf20Items.First8ItemsAreMissed, dinArray.array);
        }
        #endregion
   }
}