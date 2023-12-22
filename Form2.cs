using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Student_Management_System
{
    public partial class Form2 : Form
    {
        
        public Form2()
        {
            InitializeComponent();
           

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            dateTimePicker1.Text = "";
            textBox9.Text = "";
            textBox10.Text = "";
            textBox11.Text = "";
            comboBox1.Text = "";
            textBox1.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                
                string connectionString = "Data Source=RAHEESH-RAMZY\\SQLEXPRESS;Initial Catalog=\"Student Management\";Integrated Security=True";

                
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                   
                    connection.Open();

                   
                    using (SqlCommand command = new SqlCommand("INSERT INTO Students (Reg No, First Name, Last Name, Date of Birth, Gender, Address, E-mail, Mobile Phone, Home Phone, Parent Name, NIC, Contact No,) VALUES (@Reg No, @First Name, @Last Name, @Date of Birth, @Gender, @Address, @E-mail, @Mobile Phone, @Home Phone, @Parent Name, @NIC, @Contact No)", connection))
                    {
                        
                        command.Parameters.AddWithValue("@Reg No", textBox1.Text);
                        command.Parameters.AddWithValue("@First Name", textBox2.Text);
                        command.Parameters.AddWithValue("@Last Name", textBox3.Text);
                        command.Parameters.AddWithValue("@Date of Birth", dateTimePicker1.Value);
                        command.Parameters.AddWithValue("@Gender", comboBox1.SelectedItem.ToString());
                        command.Parameters.AddWithValue("@Address", textBox4.Text);
                        command.Parameters.AddWithValue("@E-mail", textBox5.Text);
                        command.Parameters.AddWithValue("@Mobile Phone", textBox6.Text);
                        command.Parameters.AddWithValue("@Home Phone", textBox7.Text);
                        command.Parameters.AddWithValue("@Parent Name", textBox9.Text);
                        command.Parameters.AddWithValue("@NIC", textBox10.Text);
                        command.Parameters.AddWithValue("@Contact No", textBox11.Text);

                        
                        command.ExecuteNonQuery();
                    }
                }

                
                MessageBox.Show("Data saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                
                MessageBox.Show("An error occurred while saving the data. Please try again. " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        private void button2_Click(object sender, EventArgs e)
        {

            try
            {
                
                string connectionString = "Data Source=RAHEESH-RAMZY\\SQLEXPRESS;Initial Catalog=\"Student Management\";Integrated Security=True";

                
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    
                    connection.Open();

                    
                    using (SqlCommand command = new SqlCommand("INSERT INTO Students (Reg No, First Name, Last Name, Date of Birth, Gender, Address, E-mail, Mobile Phone, Home Phone, Parent Name, NIC, Contact No) VALUES (@Reg No, @First Name, @Last Name, @Date of Birth, @Gender, @Address, @E-mail, @Mobile Phone, @Home Phone, @Parent Name, @NIC, @Contact No)", connection))
                    {
                        
                        command.Parameters.AddWithValue("@Reg No", textBox1.Text);
                        command.Parameters.AddWithValue("@First Name", textBox2.Text);
                        command.Parameters.AddWithValue("@Last Name", textBox3.Text);
                        command.Parameters.AddWithValue("@Date of Birth", dateTimePicker1.Value);
                        command.Parameters.AddWithValue("@Gender", comboBox1.SelectedItem.ToString());
                        command.Parameters.AddWithValue("@Address", textBox4.Text);
                        command.Parameters.AddWithValue("@E-mail", textBox5.Text);
                        command.Parameters.AddWithValue("@Mobile Phone", textBox6.Text);
                        command.Parameters.AddWithValue("@Home Phone", textBox7.Text);
                        command.Parameters.AddWithValue("@Parent Name", textBox9.Text);
                        command.Parameters.AddWithValue("@NIC", textBox10.Text);
                        command.Parameters.AddWithValue("@Contact No", textBox11.Text);

                        command.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Data Updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while Updating the data. Please try again. " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
    }
}
