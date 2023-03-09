using System;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace HelloWorld
{
    public partial class btnClick : Form
    {
        public btnClick()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            showInput.Text = "";

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button92_Click(object sender, EventArgs e)
        {

        }

        private void textnput_TextChanged(object sender, EventArgs e)
        {

        }

        private void showInput_Click(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {
            showInput.Text += "+";

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            showInput.Text += "1";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            showInput.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            showInput.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            showInput.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            showInput.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            showInput.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            showInput.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            showInput.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            showInput.Text += "9";
        }

        private void button0_Click(object sender, EventArgs e)
        {
            showInput.Text += "0";
        }

        private void buttonResult_Click(object sender, EventArgs e)
        {

            string expr = $"{showInput.Text}";
            DataTable dt = new DataTable();
            var result = dt.Compute(expr, "");
            showInput.Text = result.ToString();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {

        }

        private void showInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonBack_MouseClick(object sender, MouseEventArgs e)
        {
            if(showInput.Text.Length > 0) {

                char[] newInput = new char[showInput.Text.Length];
                newInput = showInput.Text.ToCharArray();
                var list = newInput.ToList();
                list.RemoveAt(showInput.Text.Length-1);
                newInput = list.ToArray();
                showInput.Text = string.Join("", newInput);

                //apaga o ultimo caracter.
            }
        }

        private void buttonMult_Click(object sender, EventArgs e)
        {
            showInput.Text += "*";
        }

        private void buttonSub_Click(object sender, EventArgs e)
        {
            showInput.Text += "-";
        }

        private void buttonDiv_Click(object sender, EventArgs e)
        {
            showInput.Text += "/";
        }

        private void buttonPoint_Click(object sender, EventArgs e)
        {
            showInput.Text += ".";
        }
    }
}