using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListNumbers;

namespace UnitTestMethod
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            CustomListNumbers<int> customNumbers = new CustomListNumbers<int>();
            int value = 4;
            //Act
            customNumbers.Add(value);
            //Assert
            Assert.AreEqual(value, customNumbers[0]);
        }
        public void TestMethod2()
        {
            //Arrange
            CustomListNumbers<int> customNumbers = new CustomListNumbers<int>();
            int value = 4;
            int value1 = 8;
            //Act
            customNumbers.Add(value);
            //Assert
            Assert.AreEqual(value, customNumbers[0]);
        }
        public void TestMethod3()
        {
            //Arrange
            CustomListNumbers<int> customNumbers = new CustomListNumbers<int>();
            int value = 1;
            int value1 = 2;
            //Act
            customNumbers.Add(value);
            customNumbers.Add(value1);
            //Assert
            Assert.AreEqual(value, customNumbers[0]);
        }
    }
}
