using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Forms;

namespace WindowsFormsApp1.Autorizate
{
    public partial class RegisterFm : Form
    {

        DataBase dataBs = new DataBase();
        public RegisterFm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {


            if (textBox1.Text != "" && textBox2.Text != "")
            {
                pictureBox1.Enabled = true;

            }
            else pictureBox1.Enabled = false;
        


    }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                pictureBox1.Enabled = true;

            }
            else pictureBox1.Enabled = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                pictureBox1.Enabled = true;
                dataBs.openConnection();
                var addQuery = $"INSERT INTO UserPan(login_user,password_user) VALUES ("
                  + $"'{textBox1.Text}','{textBox2.Text}')";
                var command = new SqlCommand(addQuery, dataBs.GetConnection());
                command.ExecuteNonQuery();
                MessageBox.Show("Ваш аккаунт создан!");
               OpenTheDorForm mainForm=new OpenTheDorForm();
                mainForm.Show();
                this.Close();

            }
            else
            {
                MessageBox.Show("Введите правильно!");
                pictureBox1.Enabled = false;
            }
            dataBs.closeConnection();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Auto auto= new Auto();
            auto.Show();
            this.Close();
        }
    }
}
