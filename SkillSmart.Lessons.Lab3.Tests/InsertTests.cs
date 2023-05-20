using AlgorithmsDataStructures;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SkillSmart.Lessons.Lab3.Tests.Data;

namespace SkillSmart.Lessons.Lab3.Tests
{
    [TestClass]
    public class InsertTests
    {
        private DynArray<int> dinArray;

        [TestInitialize]
        public void Init() 
        {
            dinArray = new DynArray<int>();
        }

        [TestMethod]
        public void InsertFirst1ItemTo16ArrayTest()
        {
            dinArray.From(ArrayOf16Items.Full);
            
            dinArray.Insert(17, 0);

            Assert.AreEqual(17, dinArray.count);
            Assert.AreEqual(32, dinArray.capacity);
            Assert.AreEqual(32, dinArray.array.Length);
            CollectionAssert.AreEqual(ArrayOf16Items.AddFirst1Element, dinArray.array);
        }

        [TestMethod]
        public void InsertFirst2ItemsTo16ArrayTest()
        {
            dinArray.From(ArrayOf16Items.Full);
            
            dinArray.Insert(17, 0);
            dinArray.Insert(18, 0);

            Assert.AreEqual(18, dinArray.count);
            Assert.AreEqual(32, dinArray.capacity);
            Assert.AreEqual(32, dinArray.array.Length);
            CollectionAssert.AreEqual(ArrayOf16Items.AddFirst2Elements, dinArray.array);
        }

        [TestMethod]
        public void InsertFirst16ItemsTo16ArrayTest()
        {
            dinArray.From(ArrayOf16Items.Full);
            
            for (var value = 16; value < 32; value ++)
                dinArray.Insert(value + 1, 0);

            Assert.AreEqual(32, dinArray.count);
            Assert.AreEqual(32, dinArray.capacity);
            Assert.AreEqual(32, dinArray.array.Length);
            CollectionAssert.AreEqual(ArrayOf16Items.AddFirst16Elements, dinArray.array);
        }
        
        [TestMethod]
        public void InsertLast1ItemTo16ArrayTest()
        {
            dinArray.From(ArrayOf16Items.Full);
            
            dinArray.Insert(17, dinArray.count);

            Assert.AreEqual(17, dinArray.count);
            Assert.AreEqual(32, dinArray.capacity);
            Assert.AreEqual(32, dinArray.array.Length);
            CollectionAssert.AreEqual(ArrayOf16Items.AddLast1Element, dinArray.array);
        }

        [TestMethod]
        public void InsertLast2ItemsTo16ArrayTest()
        {
            dinArray.From(ArrayOf16Items.Full);
            
            dinArray.Insert(17, dinArray.count);
            dinArray.Insert(18, dinArray.count);

            Assert.AreEqual(18, dinArray.count);
            Assert.AreEqual(32, dinArray.capacity);
            Assert.AreEqual(32, dinArray.array.Length);
            CollectionAssert.AreEqual(ArrayOf16Items.AddLast2Elements, dinArray.array);
        }

        [TestMethod]
        public void InsertLast16ItemsTo16ArrayTest()
        {
            dinArray.From(ArrayOf16Items.Full);

            for (var index = 16; index < 32; index ++)
                dinArray.Insert(index + 1, dinArray.count);

            Assert.AreEqual(32, dinArray.count);
            Assert.AreEqual(32, dinArray.capacity);
            Assert.AreEqual(32, dinArray.array.Length);
            CollectionAssert.AreEqual(ArrayOf32Items.Full, dinArray.array);
        }
    }
}