using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestProgram.cs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //Arrange
                CustomList.CustomNumbers<int>[] numberArrayList = new CustomList.CustomNumbers<int>[8];

                CustomNumbers<int> numberList = new CustomNumbers<int>();
                int value = 4;
                //Act
                numberList.Add(value);
                value = 5;
                //Act
                numberList.Add(value);


                numberArrayList[0] = numberList;





                //Assert
                //Assert.AreEqual(value, numberList[0]);
      

        }
    }
}
