using AlgorithmsDataStructures;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace SkillSmart.Lessons.Lab8.Tests
{
    [TestClass]
    public class SeekTests
    {
        private readonly bool asc = true;
        private HashTable table;

        [TestInitialize]
        public void Init() 
        {
            table = new HashTable(7, 3);
        }

        [TestMethod]
        public void SeekNullStringTest()
        {
            var slot = table.SeekSlot(null);

            Assert.AreEqual(-1, slot);
        }

        [TestMethod]
        public void SeekNonNullStringTest()
        {
            var slot = table.SeekSlot("Quick");

            Assert.AreNotEqual(-1, slot);
        }


        [TestMethod]
        public void SeekTheSameStringTest()
        {
            var slot1 = table.SeekSlot("Quick");
            var slot2 = table.SeekSlot("Quick");

            Assert.AreEqual(slot1, slot2);
        }

        [TestMethod]
        public void SeekWithOccupiedSlotTest()
        {
            var hash1 = table.HashFun("Quick");
            
            table.slots[hash1] = "fox";

            var slot1 = table.SeekSlot("Quick");

            Assert.AreNotEqual(slot1, hash1);
        }

        [TestMethod]
        public void SeekSlotInOneVacantSlotTableTest()
        {
            for (var i = 0; i < table.slots.Length; i++) table.slots[i] = "busy";

            var hash1 = table.HashFun("Quick");
            var emptySlot = hash1 > 0 ? hash1 - 1 : table.slots.Length - 1;

            table.slots[emptySlot] = null;

            var slot1 = table.SeekSlot("Quick");

            Assert.AreNotEqual(-1, slot1);
            Assert.AreEqual(emptySlot, slot1);
        }


        [TestMethod]
        public void SeekSlotInFullTableTest()
        {
            for (var i = 0; i < table.slots.Length; i++) table.slots[i] = "busy";

            var hash1 = table.HashFun("Quick");

            var slot1 = table.SeekSlot("Quick");

            Assert.AreNotEqual(-1, hash1);
            Assert.AreEqual(-1, slot1);
        }
    }
}