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
            int[] expected = new int[] { 1, 2, 3 };

            CollectionAssert.AreEqual(expected, spyInMessage.setArray(charArray));
        }

        [TestMethod]
        public void isSpyInMessageTest()
        {
            SpyInMessage spyInMessage = new SpyInMessage();
            int[] message = new int[] {1, 2, 3, 4, 5, 6};
            int[] spyTrue = new int[] {1, 3, 6 };
            int[] spyFalse1 = new int[] {3, 2, 6};
            int[] spyFalse2 = new int[] {3, 2, 6, 7};

            Assert.IsTrue(spyInMessage.isSpyInMessage(message, spyTrue));
            Assert.IsFalse(spyInMessage.isSpyInMessage(message, spyFalse1));
            Assert.IsFalse(spyInMessage.isSpyInMessage(message, spyFalse2));
        }




    }
}
