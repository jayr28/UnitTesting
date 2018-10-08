using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    class Program
    {
        static void Main(string[] args)
        {
        
                //Arrange
                CustomNumbers<int>[] numberArrayList = new CustomNumbers<int>[8];

            CustomNumbers<int> numberList = new CustomNumbers<int>();
            int value = 4;
            //Act
            numberList.Add(value);
            value = 5;
            //Act
            numberList.Add(value);
            value = 6;
            //Act
            numberList.Add(value);
            value = 7;
            //Act
            numberList.Add(value);
            value = 8;
            //Act
            numberList.Add(value);
            value = 19;
            //Act
            numberList.Add(value);
            value = 25;
            //Act
            numberList.Add(value);
            value = 35;
            //Act
            numberList.Add(value);
            value = 45;
            //Act
      
            //Act
            numberList.Add(value);

            numberList.Remove(35);
            numberList.Remove(25);


            numberArrayList[0] = numberList;

                //Assert
                //Assert.AreEqual(value, numberList[0]);
         

        }
    }
}
