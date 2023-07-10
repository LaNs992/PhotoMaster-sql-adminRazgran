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
    public partial class UslugiAdd : Form
    {
        DataBase dataBs = new DataBase();
        public UslugiAdd()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataBs.openConnection();
            if (fio_textBox.Text != "")
            {
               
                var addQuery = $"INSERT INTO usluga(usluga_name,usluga_price) VALUES ("
                   + $"'{fio_textBox.Text}','{mail__textBox.Text}')";
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
            if (fio_textBox.Text != "" && mail__textBox.Text != "")
            {
                button1.Enabled = true;

            }
            else button1.Enabled = false;
        }

        private void mail__textBox_TextChanged(object sender, EventArgs e)
        {
            if (fio_textBox.Text != "" && mail__textBox.Text != "")
            {
                button1.Enabled = true;

            }
            else button1.Enabled = false;
        }

        private void UslugiAdd_Load(object sender, EventArgs e)
        {
            button1.Enabled = false;
        }

        private void mail__textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
        char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8) // цифры и клавиша BackSpace
            {
                e.Handled = true;
            }
        }
    }
}
