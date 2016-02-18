using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DependencyInjection;
using Moq;

namespace TestProjectDependencyInjection
{
    /// <summary>
    /// Summary description for UnitTestClassC
    /// </summary>
    [TestClass]
    public class UnitTestClassC
    {
       

       
     
        [TestMethod]
        public void TestGetSum()
        {
            //Create an mock of interface
            Mock<IMyInterface> mock = new Mock<IMyInterface>();
            // Create mock implementation of ImyInterface
            mock.Setup(r => r.AddTwoNumbers(2, 3)).Returns(1000);

            ClassC instanceC = new ClassC(mock.Object);
            Assert.AreEqual(instanceC.GetSum(2, 3), 2000);
        }
    }
}
