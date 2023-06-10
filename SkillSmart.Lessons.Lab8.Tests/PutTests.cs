using AlgorithmsDataStructures;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace SkillSmart.Lessons.Lab8.Tests
{
    [TestClass]
    public class PutTests
    {
        private readonly bool asc = true;
        private HashTable table;

        [TestInitialize]
        public void Init() 
        {
            table = new HashTable(7, 3);
        }

        [TestMethod]
        public void PutNullStringTest()
        {
            var slot = table.Put(null);

            Assert.AreEqual(-1, slot);
        }

        [TestMethod]
        public void PutNonNullStringTest()
        {
            var slot = table.Put("Quick");

            Assert.AreNotEqual(-1, slot);
        }


        [TestMethod]
        public void PutTheSameStringTest()
        {
            var slot1 = table.Put("Quick");
            var slot2 = table.Put("Quick");

            Assert.AreEqual(slot1, slot2);
        }

        [TestMethod]
        public void PutStringWithTheSameHashTest()
        {
            var hash1 = table.HashFun("Quick");
            
            table.slots[hash1] = "fox";

            var slot1 = table.Put("Quick");

            Assert.AreNotEqual(slot1, hash1);
        }

        [TestMethod]
        public void PutStringToOneVacantSlotTableTest()
        {
            for (var i = 0; i < table.slots.Length; i++) table.slots[i] = "busy";

            var hash1 = table.HashFun("Quick");
            var emptySlot = hash1 > 0 ? hash1 - 1 : table.slots.Length - 1;

            table.slots[emptySlot] = null;

            var slot1 = table.Put("Quick");

            Assert.AreNotEqual(-1, slot1);
            Assert.AreEqual(emptySlot, slot1);
        }


        [TestMethod]
        public void PutStringToFullTableTest()
        {
            for (var i = 0; i < table.slots.Length; i++) table.slots[i] = "busy";

            var hash1 = table.HashFun("Quick");

            var slot1 = table.Put("Quick");

            Assert.AreNotEqual(-1, hash1);
            Assert.AreEqual(-1, slot1);
        }
    }
}