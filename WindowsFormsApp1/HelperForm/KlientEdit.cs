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
    public partial class KlientEdit : Form
    {
        DataBase dataBs = new DataBase();
        public KlientEdit()
        {
            InitializeComponent();
        }
        public int id = 0;
        public KlientEdit(int idsender) : this()
        {
            id = (int)idsender;

            var main = $"SELECT fio,klient_number ,klient_mail  FROM klient WHERE klient_id ={id} ";
            var command = new SqlCommand(main, dataBs.GetConnection());
            dataBs.openConnection();
            SqlDataReader reader = command.ExecuteReader();
            reader.Read();

            fio_textBox.Text = reader[0].ToString();
            maskedTextBox1.Text = reader[1].ToString();
            mail__textBox.Text = reader[2].ToString();

            reader.Close();


        }
        Klient kl  = new Klient();
        private void button1_Click(object sender, EventArgs e)
        {
            int index = kl.dataGridView1.CurrentCell.RowIndex;
            var id = kl.dataGridView1.Rows[index].Cells[0].Value.ToString();
            var fio = fio_textBox.Text;
            var number = maskedTextBox1.Text;
            var mail = mail__textBox.Text;
            if (fio_textBox.Text != string.Empty)
            {
                kl.dataGridView1.Rows[index].SetValues(id, fio);
                dataBs.openConnection();
                var changequery = $"UPDATE klient SET fio = '{fio}',klient_number = '{number}',klient_mail = '{mail}' WHERE klient_id = {id}";
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

        private void fio_textBox_TextChanged(object sender, EventArgs e)
        {
            if (fio_textBox.Text != "" && maskedTextBox1.Text != "" && mail__textBox.Text != "")
            {
                button1.Enabled = true;

            }
            else button1.Enabled = false;
        }

        private void KlientEdit_Load(object sender, EventArgs e)
        {
            button1.Enabled = false;
        }
    }
}
