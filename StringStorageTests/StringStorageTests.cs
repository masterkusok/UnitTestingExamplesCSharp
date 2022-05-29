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
        StringStorage _newStorage;

        [TestInitialize()]
        public void InitializeStorage()
        {
            Debug.WriteLine("Initialized storage");
            _storage = new StringStorage();
            _storage.AddElement("Kinda nice string!");
            _storage.AddElement("String 2");
            _storage.AddElement("String 3");

            _newStorage = new StringStorage();
            _newStorage.AddElement("Kinda nice string!");
            _newStorage.AddElement("String 3");
            _newStorage.AddElement("String 2");
        }

        [TestCleanup()]
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

        /*
         You can test exception throwing like this too 
        [TestMethod()]
        public void GetElement_get100Element_thrownArgumentOutOfRangeException()
        {
            // act & assert
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => { _storage.GetElement(100); });
        }
        */

        [TestMethod()]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void GetElement_get100Element_thrownArgumentOutOfRangeException()
        {
            _storage.GetElement(100);
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

        [TestMethod()]
        public void GetStorage_areNotEqual_returnTrue()
        {
            // Test passes, because methods AreEqual() and AreNotEqual() take the order of 
            // items into a count
            CollectionAssert.AreNotEqual(_storage.Storage, _newStorage.Storage);
        }

        [TestMethod()]
        public void GetStorage_areEquivalent_returnTrue()
        {
            // Test passes, because methods AreEquivalent() and AreNotEquivalent() don't take the order of 
            // items into a count
            CollectionAssert.AreEquivalent(_storage.Storage, _newStorage.Storage);
        }

        [TestMethod()]
        public void Test_isSubsetOf_returnTrue()
        {
            // arrange
            StringStorage temp = new StringStorage();
            temp.AddElement("String 3");
            // assert
            CollectionAssert.IsSubsetOf(temp.Storage, _storage.Storage);
        }
    }
}