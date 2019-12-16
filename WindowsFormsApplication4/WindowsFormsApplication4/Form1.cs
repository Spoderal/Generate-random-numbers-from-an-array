using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            const int SIZE = 5;
            int[] lotteryNumbers = new int[SIZE];

            Random rand = new Random();

            for(int index = 0; index < lotteryNumbers.Length; index++)
            {
                lotteryNumbers[index] = rand.Next(100);
            }

            textBox1.Text = lotteryNumbers[0].ToString();
            textBox2.Text = lotteryNumbers[1].ToString();
            textBox3.Text = lotteryNumbers[2].ToString();
            textBox4.Text = lotteryNumbers[3].ToString();
            textBox5.Text = lotteryNumbers[4].ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
