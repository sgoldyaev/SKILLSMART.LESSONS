using AlgorithmsDataStructures;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SkillSmart.Lessons.Lab3.Tests
{
    [TestClass]
    public class DinArrayRemoveTests
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
            foreach (var item in ArrayOf16Items.Full)
                dinArray.Append(item);

            dinArray.Remove(0);
            
            Assert.AreEqual(15, dinArray.count);
            Assert.AreEqual(DynArray<int>.defaultSize, dinArray.capacity);
            Assert.AreEqual(DynArray<int>.defaultSize, dinArray.array.Length);
            CollectionAssert.AreEqual(ArrayOf16Items.FirstOneIsMissed, dinArray.array);
        }

        [TestMethod]
        public void RemoveFirstTwoItemFrom16ItemsArrayTest()
        {
            foreach (var item in ArrayOf16Items.Full)
                dinArray.Append(item);

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
            foreach (var item in ArrayOf16Items.Full)
                dinArray.Append(item);

            dinArray.Remove(15);
            
            Assert.AreEqual(15, dinArray.count);
            Assert.AreEqual(DynArray<int>.defaultSize, dinArray.capacity);
            Assert.AreEqual(DynArray<int>.defaultSize, dinArray.array.Length);
            CollectionAssert.AreEqual(ArrayOf16Items.LastOneIsMissed, dinArray.array);
        }

        [TestMethod]
        public void RemoveLastTwoItemFrom16ItemsArrayTest()
        {
            foreach (var item in ArrayOf16Items.Full)
                dinArray.Append(item);

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
            foreach (var item in ArrayOf16Items.Full)
                dinArray.Append(item);

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
            foreach (var item in ArrayOf32Items.Full)
                dinArray.Append(item);

            dinArray.Remove(0);
            
            Assert.AreEqual(31, dinArray.count);
            Assert.AreEqual(32, dinArray.capacity);
            Assert.AreEqual(32, dinArray.array.Length);
            CollectionAssert.AreEqual(ArrayOf32Items.FirstOneIsMissed, dinArray.array);
        }

        [TestMethod]
        public void RemoveFirstTwoItemFrom32ItemsArrayTest()
        {
            foreach (var item in ArrayOf32Items.Full)
                dinArray.Append(item);

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
            foreach (var item in ArrayOf32Items.Full)
                dinArray.Append(item);

            dinArray.Remove(31);
            
            Assert.AreEqual(31, dinArray.count);
            Assert.AreEqual(32, dinArray.capacity);
            Assert.AreEqual(32, dinArray.array.Length);
            CollectionAssert.AreEqual(ArrayOf32Items.LastOneIsMissed, dinArray.array);
        }

        [TestMethod]
        public void RemoveLastTwoItemFrom32ItemsArrayTest()
        {
            foreach (var item in ArrayOf32Items.Full)
                dinArray.Append(item);

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
            foreach (var item in ArrayOf32Items.Full)
                dinArray.Append(item);

            dinArray.Remove(4);
            
            Assert.AreEqual(31, dinArray.count);
            Assert.AreEqual(32, dinArray.capacity);
            Assert.AreEqual(32, dinArray.array.Length);
            CollectionAssert.AreEqual(ArrayOf32Items.MiddleOneIsMissed, dinArray.array);
        }

        [TestMethod]
        public void RemoveMiddleTwoItemsFrom32ItemsArrayTest()
        {
            foreach (var item in ArrayOf32Items.Full)
                dinArray.Append(item);

            dinArray.Remove(4);
            dinArray.Remove(4);
            
            Assert.AreEqual(30, dinArray.count);
            Assert.AreEqual(32, dinArray.capacity);
            Assert.AreEqual(32, dinArray.array.Length);
            CollectionAssert.AreEqual(ArrayOf32Items.MiddleTwoIsMissed, dinArray.array);
        }
        #endregion
   }
}