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
    public partial class UslugiEdit : Form
    {
        public UslugiEdit()
        {
            InitializeComponent();
        }
        public int id = 0;
        public UslugiEdit(int idsender) : this()
        {
            id = (int)idsender;

            var main = $"SELECT usluga_name ,usluga_price FROM usluga WHERE usluga_id={id} ";
            var command = new SqlCommand(main, dataBs.GetConnection());
            dataBs.openConnection();
            SqlDataReader reader = command.ExecuteReader();
            reader.Read();

            fio_textBox.Text = reader[0].ToString(); 
            mail__textBox.Text = reader[1].ToString();

            reader.Close();
        }
        DataBase dataBs = new DataBase();
        UslugiForm uf = new UslugiForm();
        private void button1_Click(object sender, EventArgs e)
        {
            
            int index = uf.dataGridView1.CurrentCell.RowIndex;
            var id = uf.dataGridView1.Rows[index].Cells[0].Value.ToString();

            if (fio_textBox.Text != string.Empty)
            {
                uf.dataGridView1.Rows[index].SetValues(id, fio_textBox.Text);
                dataBs.openConnection();
                var changequery = $"UPDATE usluga SET usluga_name = '{fio_textBox.Text}',usluga_price = '{mail__textBox.Text}' WHERE usluga_id = {id}";
                var command = new SqlCommand(changequery, dataBs.GetConnection());
                command.ExecuteNonQuery();
                dataBs.closeConnection();
                
            }
            else
            {
                MessageBox.Show("Введите название поставщика!");
            }
        }

        private void mail__textBox_TextChanged(object sender, EventArgs e)
        {
            if (fio_textBox.Text != "" &&  mail__textBox.Text != "")
            {
                button1.Enabled = true;

            }
            else button1.Enabled = false;
        }

        private void fio_textBox_TextChanged(object sender, EventArgs e)
        {
            if (fio_textBox.Text != "" &&  mail__textBox.Text != "")
            {
                button1.Enabled = true;

            }
            else button1.Enabled = false;
        }

        private void UslugiEdit_Load(object sender, EventArgs e)
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
