using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DependencyInjection;

namespace TestProjectDependencyInjection
{
    [TestClass]
    public class UnitTestCalssA
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
            Assert.AreEqual(instanceA.TrimString("a "), "a");

        }

        [TestMethod]
        public void TestTrimStringWithStartingSpaces()
        {
            ClassA instanceA = new ClassA();
            Assert.AreEqual(instanceA.TrimString(" a"), "a");

        }

        [TestMethod]
        public void TestTrimStringWithMiddleSpaces()
        {
            ClassA instanceA = new ClassA();
            Assert.AreEqual(instanceA.TrimString("b a"), "b a");

        }

        [TestMethod]
        public void TestTrimStringWithNull()
        {
            ClassA instanceA = new ClassA();
            Assert.AreEqual(instanceA.TrimString(null), null);

        }


        [TestMethod]
        [ExpectedException(typeof(NotFiniteNumberException))]
        public void TestTrimStringNotNullShouldThrowException()
        {
            ClassA instanceA = new ClassA();
            var trimedString = instanceA.TrimStringNotNull(null);

        }
    }
}
