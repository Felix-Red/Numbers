using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Numbers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random random = new Random();

            textBox1.Text = GetDistinctRandomNumber(random).ToString();
            textBox2.Text = GetDistinctRandomNumber(random).ToString();
            textBox3.Text = GetDistinctRandomNumber(random).ToString();
            textBox4.Text = GetDistinctRandomNumber(random).ToString();
            textBox5.Text = GetDistinctRandomNumber(random).ToString();
            textBox6.Text = GetDistinctRandomNumber(random).ToString();

            //PowerBall
            Random powerball = new Random(); 
            textBox7.Text = GetDistinctRandomNumber2(random).ToString();
            textBox8.Text = GetDistinctRandomNumber2(random).ToString();
            textBox9.Text = GetDistinctRandomNumber2(random).ToString();
            textBox10.Text = GetDistinctRandomNumber2(random).ToString();
            textBox11.Text = GetDistinctRandomNumber2(random).ToString();
            textBox12.Text = powerball.Next(1, 20).ToString();

            //Daily lotto
            textBox13.Text = GetDistinctRandomNumber3(random).ToString();
            textBox14.Text = GetDistinctRandomNumber3(random).ToString();
            textBox15.Text = GetDistinctRandomNumber3(random).ToString();
            textBox16.Text = GetDistinctRandomNumber3(random).ToString();
            textBox17.Text = GetDistinctRandomNumber3(random).ToString();
        }

        private int GetDistinctRandomNumber(Random random)
        {
            int randomNumber;

            do
            {
                randomNumber = random.Next(1, 52);
            } while (textBox1.Text == randomNumber.ToString() ||
                     textBox2.Text == randomNumber.ToString() ||
                     textBox3.Text == randomNumber.ToString() ||
                     textBox4.Text == randomNumber.ToString() ||
                     textBox5.Text == randomNumber.ToString() ||
                     textBox6.Text == randomNumber.ToString());

            return randomNumber;
        }

        private int GetDistinctRandomNumber2(Random random)
        {
            int randomNumber;

            do
            {
                randomNumber = random.Next(1, 50);
            } while (textBox7.Text == randomNumber.ToString() ||
                     textBox8.Text == randomNumber.ToString() ||
                     textBox9.Text == randomNumber.ToString() ||
                     textBox10.Text == randomNumber.ToString() ||
                     textBox11.Text == randomNumber.ToString());

            return randomNumber;
        }
        private int GetDistinctRandomNumber3(Random random)
        {
            int randomNumber;

            do
            {
                randomNumber = random.Next(1, 36);
            } while (textBox13.Text == randomNumber.ToString() ||
                     textBox14.Text == randomNumber.ToString() ||
                     textBox15.Text == randomNumber.ToString() ||
                     textBox16.Text == randomNumber.ToString() ||
                     textBox17.Text == randomNumber.ToString() );

            return randomNumber;
        }
    }
}
