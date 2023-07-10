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
    public partial class PhotoEdit : Form
    {
        DataBase dataBs = new DataBase();
        public PhotoEdit()
        {
            InitializeComponent();
        }
        public int id = 0;
        public PhotoEdit(int idsender) : this()
        {
            id = (int)idsender;

            var main = $"SELECT photograph_fio,photograph_number,photograph_mail FROM photograph WHERE photograph_id={id} ";
            var command = new SqlCommand(main, dataBs.GetConnection());
            dataBs.openConnection();
            SqlDataReader reader = command.ExecuteReader();
            reader.Read();
           
                fio_textBox.Text = reader[0].ToString();
            maskedTextBox1.Text = reader[1].ToString();
                mail__textBox.Text = reader[2].ToString();

                reader.Close();


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (fio_textBox.Text != string.Empty)
            {

                dataBs.openConnection();
                var changequery = $"UPDATE photograph SET photograph_fio = '{fio_textBox.Text}',photograph_number = '{maskedTextBox1.Text}' ,photograph_mail = '{mail__textBox.Text}' WHERE photograph_id={id}";
                var command = new SqlCommand(changequery, dataBs.GetConnection());
                command.ExecuteNonQuery();
                dataBs.closeConnection();

            }
            else
            {
                MessageBox.Show("Введите правильно!");
            }
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

        private void mail__textBox_TextChanged(object sender, EventArgs e)
        {
            if (fio_textBox.Text != "" && maskedTextBox1.Text != "" && mail__textBox.Text != "")
            {
                button1.Enabled = true;

            }
            else button1.Enabled = false;
        }

        private void PhotoEdit_Load(object sender, EventArgs e)
        {
            button1.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
