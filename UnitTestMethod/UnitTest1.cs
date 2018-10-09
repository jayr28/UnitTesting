using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;


namespace UnitTestMethod
{
    [TestClass]
    public class UnitTest1

    {
 

        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            CustomNumbers<int> numberList = new CustomNumbers<int>();
            int value = 4;
            //Act
            numberList.Add(value);
            //Assert
            Assert.AreEqual(value, numberList[0]);
        }
        [TestMethod]
        public void TestMethod2()
        {
            //Arrange
            CustomNumbers<int> numberList = new CustomNumbers<int>();
            int value = 4;
            int value1 = 8;
            //Act
            numberList.Add(value);
            //Assert
            Assert.AreEqual(value, value1);
        }
        [TestMethod]
        public void TestMethod3()
        {
            //Arrange
            CustomNumbers<int> numberList = new CustomNumbers<int>();
            int value = 1;
            int value1 = 2;
            //Act
            numberList.Add(value);
            numberList.Add(value1);
            //Assert
            Assert.AreEqual(value, numberList[0]);
        }

        [TestMethod]
        public void TestMethod5()
        {
            //Arrange
            CustomNumbers<int> numberList = new CustomNumbers<int>();

            //Act
            numberList.Add(3);
            numberList.Add(5);
            numberList.Add(8);
            numberList.Add(12);
            numberList.Add(13);
            numberList.Add(16);
            numberList.Add(19);
            numberList.Add(28);

 

            //Assert
            Assert.AreEqual(3, numberList[0]);
        }

        [TestMethod]
        public void TestMethod6()
        {
            //Arrange
            CustomNumbers<int> numberList = new CustomNumbers<int>();

            //Act
            numberList.Add(3);
            numberList.Add(5);
            numberList.Add(8);
            numberList.Add(12);
            numberList.Add(13);
            numberList.Add(16);
            numberList.Add(19);
            numberList.Add(28);

            //Assert
            Assert.AreEqual(3, numberList[5]); //this should fail
        }

        [TestMethod]
        public void TestMethod7()
        {
            //Arrange
            CustomNumbers<int> numberList = new CustomNumbers<int>();

            //Act
            numberList.Add(3);
            numberList.Add(5);
            numberList.Add(8);
            numberList.Add(12);
            numberList.Add(13);
            numberList.Add(16);
            numberList.Add(19);
            numberList.Add(28);
            numberList.Remove(8);

            //Assert
            Assert.AreEqual(8, numberList[2]); //this should fail
        }
        [TestMethod]
        public void TestMethod8()
        {
            //Arrange
            CustomNumbers<int> numberList = new CustomNumbers<int>();

            //Act
            numberList.Add(3);
            numberList.Add(5);
            numberList.Add(8);
            numberList.Add(12);
            numberList.Add(13);
            numberList.Add(16);
            numberList.Add(19);
            numberList.Add(28);
            numberList.Remove(16);

            //Assert
            Assert.AreEqual(19, numberList[5]); //this should pass
        }
        [TestMethod]
        public void TestMethod9()
        {
            //Arrange
            string expected = "3581213161928";
            CustomNumbers<int> numberList = new CustomNumbers<int>();

            //Act
            numberList.Add(3);
            numberList.Add(5);
            numberList.Add(8);
            numberList.Add(12);
            numberList.Add(13);
            numberList.Add(16);
            numberList.Add(19);
            numberList.Add(28);
            string actual = numberList.ToString();

            //Assert
            Assert.AreEqual(expected, actual); //this should pass
        }

    }
}