using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringStorage;
using System;
using System.Diagnostics;

namespace StringStorage.Tests
{
    [TestClass()]
    public class StringStorageTests
    {
        StringStorage _storage;

        [TestInitialize]
        public void InitializeStorage()
        {
            Debug.WriteLine("Initialized storage");
            _storage = new StringStorage();
            _storage.AddElement("Kinda nice string!");
        }

        [TestCleanup]
        public void CleanupStorage()
        {
            Debug.WriteLine("Cleaned up storage");
            _storage.Storage.Clear();
        }

        [TestMethod()]
        public void GetElement_get0element_returnedKindaNiceString()
        {
            // arrange 
            string expect = "Kinda nice string!";
            // act 
            string actual = _storage.GetElement(0);
            // assert
            Assert.AreEqual(expect, actual);
        }
        
        [TestMethod]
        public void GetElement_get100Element_thrownArgumentOutOfRangeException()
        {
            // act & assert
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => { _storage.GetElement(100); });
        }

        [TestMethod()]
        public void GetSize_getSizeOfStorage_returned1()
        {
            // arrange
            int expect = 1;
            // act
            int actual = _storage.GetSize();
            // assert
            Assert.AreEqual(expect, actual);
        }
    }
}