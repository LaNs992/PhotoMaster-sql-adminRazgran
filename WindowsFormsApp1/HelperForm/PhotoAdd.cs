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

namespace WindowsFormsApp1.HelperForm
{
    public partial class PhotoAdd : Form
    {
        DataBase dataBs = new DataBase();
        public PhotoAdd()
        {
            InitializeComponent();
        }
        Photograph Ph= new Photograph();
        private void mail__textBox_TextChanged(object sender, EventArgs e)
        {
            if (fio_textBox.Text != "" && maskedTextBox1.Text != "" && mail__textBox.Text != "")
            {
                button1.Enabled = true;

            }
            else button1.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataBs.openConnection();
            if (fio_textBox.Text != "")
            {
                var addQuery = $"INSERT INTO photograph(photograph_fio,photograph_number,photograph_mail) VALUES ('{fio_textBox.Text}',"
                   + $"'{maskedTextBox1.Text}','{mail__textBox.Text}')";
                var command = new SqlCommand(addQuery, dataBs.GetConnection());
                command.ExecuteNonQuery();
                MessageBox.Show("Новая запись успешно создана!");
                
            }
            else
            {
                MessageBox.Show("Введите правильно!");
            }
            dataBs.closeConnection();
        }

        private void fio_textBox_TextChanged(object sender, EventArgs e)
        {
            if (fio_textBox.Text != "" && maskedTextBox1.Text != "" && mail__textBox.Text != "")
            {
                button1.Enabled = true;

            }
            else button1.Enabled = false;
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            if (fio_textBox.Text != "" && maskedTextBox1.Text != "" && mail__textBox.Text != "")
            {
                button1.Enabled = true;

            }
            else button1.Enabled = false;
        }

        private void PhotoAdd_Load(object sender, EventArgs e)
        {
            button1.Enabled = false;
        }
    }
}

