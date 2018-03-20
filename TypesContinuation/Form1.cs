using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TypesContinuation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal myDecimalValue = 10;
            // int myIntValue = myDecimalValue; it won't works because we try to convert decimal to int, but we can use projection(?)/rzutowanie
            int myIntValue = (int)myDecimalValue;
            int x = 365;
            byte myByte = (byte) x; // As we can see there is no error, but if we check what value is behind x we will see it's 109 because max of byte possibilitie is 256 and if we add 109 it will equal 365!
            MessageBox.Show("Liczba x to: " + myByte);

            int myInt = 36;
            float myFloat = 16.4F;
            myFloat = myInt + myFloat; // if we use operators like "+","-","/","*" it will do projection automatically to bigger type. Float can be included in int type, but int type can't be included in float type. That's why compilator convert to int type.

            long l = 139401930;
            short s = 516;
            double d = l - s; // we used two operators "-" and "=", minus was used to substract long from short and operator "is equal to" to convert to double type
            d = d / 123.456;
            MessageBox.Show("Liczba d to: " + d);

            long b = 139401930;
            MessageBox.Show("Liczba b to: " + b); // operator + which allows us convert number b to string
            // wont work MessageBox.Show(b);
            MessageBox.Show(b.ToString()); // simple method To.String changed value b to string but without using any of operators

        }
    }
}
