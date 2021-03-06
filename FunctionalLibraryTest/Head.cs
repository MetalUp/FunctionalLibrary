﻿using MetalUp.FunctionalLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FunctionalLibraryTest
{
    [TestClass]
    public class Head : TestBase
    {
        [TestMethod]
        public void Head1()
        {
            var list = FList.New(1, 2, 3, 4, 5);
            var actual = FList.Head(list);
            var expected = 1;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Head2()
        {
            var list = FList.New(5);
            var actual = FList.Head(list);
            var expected = 5;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(EmptyListException), "EmptyListException NOT thrown")]
        public void Head3Action()
        {
            var list = FList.Empty<int>();
            var actual = FList.Head(list);
        }

        [TestMethod]
        public void Head1String()
        {
            var list = "12345";
            var actual = FList.Head(list);
            var expected = '1';
            Assert.AreEqual(expected, actual);
        }
    }
}
