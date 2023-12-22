using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Management_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            string username = textBox1.Text;
            string password = textBox2.Text;
            if (username == "Admin" && password == "123")
            {
                Form2 form2 = new Form2();
                form2.Show();
                this.Hide();
            }
            else if (textBox1.Text.Trim() == string.Empty || textBox2.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please fill out all the Fields!");

            }

            else
            {
                MessageBox.Show("Username or Password is Incorrect!");
                textBox1.Text = "";
                textBox2.Text = "";
                textBox1.Focus();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            textBox1.Text = "";
            textBox2.Text = "";
            textBox1.Focus();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
