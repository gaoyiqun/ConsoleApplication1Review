using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lecture5Review;

namespace Lecture5ReviewUnitTest
{
    [TestClass]
    public class UnitTestClassA
    {
        [TestMethod]
        public void TestAddTwoNumbers()
        {
            ClassA instanceA = new ClassA();
            Assert.AreEqual(instanceA.AddTwoNumbers(2, 3), 5);
        }
        
        [TestMethod]
        public void TestTrimStringWithEndingSpaces()
        {
            ClassA instanceA = new ClassA();
            Assert.AreEqual(instanceA.TrimString("a   "), "a");
        }

        [TestMethod]
        public void TestTrimStringWithStartinhSpaces()
        {
            ClassA instanceA = new ClassA();
            Assert.AreEqual(instanceA.TrimString("    a"), "a");
        }

        [TestMethod]
        public void TestTrimStringWithMiddlingSpaces()
        {
            ClassA instanceA = new ClassA();
            Assert.AreEqual(instanceA.TrimString("a  b "), "a  b");
        }

        [TestMethod]
        public void TestTrimStringWithNull()
        {
            ClassA instanceA = new ClassA();
            Assert.AreEqual(instanceA.TrimString(null), null);
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void TestTrimStringNotNullThrowException()
        {
            ClassA instanceA = new ClassA();
            var trimedString = instanceA.TrimStringNotNull(null);
        }
    }
}
