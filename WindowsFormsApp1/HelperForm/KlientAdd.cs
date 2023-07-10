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

namespace WindowsFormsApp1.HelperForm
{
    public partial class KlientAdd : Form
    {
        DataBase dataBs = new DataBase();
        public KlientAdd()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            dataBs.openConnection();
            if (fio_textBox.Text != ""&&maskedTextBox1.Text!=""&&mail__textBox.Text!="")
            {
                button1.Enabled = true;
                var addQuery = $"INSERT INTO klient(fio,klient_number,klient_mail) VALUES ('{fio_textBox.Text}',"
                   + $"'{maskedTextBox1.Text}','{mail__textBox.Text}')";
                var command = new SqlCommand(addQuery, dataBs.GetConnection());
                command.ExecuteNonQuery();
                MessageBox.Show("Новая запись успешно создана!");
                
            }
            else
            {
                button1.Enabled =false;
                MessageBox.Show("Введите правильно!");
            }
            dataBs.closeConnection();

        }

        private void KlientAdd_Load(object sender, EventArgs e)
        {
            button1.Enabled = false;
        }

        private void mail__textBox_TextChanged(object sender, EventArgs e)
        {
            if (fio_textBox.Text != "" && maskedTextBox1.Text != "" && mail__textBox.Text != "")
            {
                button1.Enabled = true;
              
            }
            else
                button1.Enabled = false;
        }

        private void maskedTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (fio_textBox.Text != "" && maskedTextBox1.Text != "" && mail__textBox.Text != "")
            {
                button1.Enabled = true;

            }
            else
                button1.Enabled = false;
        }

        private void fio_textBox_TextChanged(object sender, EventArgs e)
        {
            if (fio_textBox.Text != "" && maskedTextBox1.Text != "" && mail__textBox.Text != "")
            {
                button1.Enabled = true;

            }
            else
                button1.Enabled = false;
        }
    }
}
