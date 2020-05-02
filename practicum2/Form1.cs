using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace practicum2
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();

        public Form1()
        {
            InitializeComponent();
            int n1 = rnd.Next(10);
            num1Text.Text = n1.ToString();

            int n2 = rnd.Next(10);
            num2Text.Text = n2.ToString();

            int n3 = rnd.Next(10);
            num3Text.Text = n3.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1 = Int32.Parse(num1Text.Text);
            int num2 = Int32.Parse(num2Text.Text);
            int num3 = Int32.Parse(num3Text.Text);
            
            String output = MethodRunner.RunAllMethods(num1,num2,num3);
            methodOutput.Text = output;

            //Als de checkbox aangeklikt is wordt er bij num1 van de lambda's een andee waarde ingevoerd.
            if (!checkBox1.Checked)
            {
            output = LambdaRunner.RunAllMethods(num1,num2,num3);
            lambdaOutput.Text = output;
            }
            else
            {
                output = LambdaRunner.RunAllMethods(999, num2, num3);
                lambdaOutput.Text = output;
            }




            MessageBox.Show(AnswerChecker.CheckAnswers());
        }
    }
}
