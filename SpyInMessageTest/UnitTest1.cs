using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp3;

namespace SpyInMessageTest
{
    [TestClass]
    public class SpyInMessageTest
    {
        [TestMethod]
        public void SetArrayTest()
        {
            SpyInMessage spyInMessage = new SpyInMessage();
            Char[] charArray = new Char[] { '1', '2', '3' };
            int[] intArray = new int[3];
            int[] expected = new int[] { 1, 2, 3 };

            CollectionAssert.AreEqual(expected, spyInMessage.setArray(charArray, intArray));
        }

       
    }
}
