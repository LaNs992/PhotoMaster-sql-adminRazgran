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
    public partial class OpenTheDorForm : Form
    {
        DataBase dataBs = new DataBase();
        public OpenTheDorForm()
        {
            InitializeComponent();
        }

        private void OpenTheDorForm_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            RegisterFm Rf = new RegisterFm();
            Rf.ShowDialog();
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                pictureBox1.Enabled = true;

            }
            else pictureBox1.Enabled = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            if (Auto.isAdmin == false)
            {
                dataBs.openConnection();
                SqlDataAdapter adapter = new SqlDataAdapter();
                DataTable table = new DataTable();
                string queryString = $"SELECT * FROM UserPan  WHERE login_user='{textBox1.Text}' AND password_user='{textBox2.Text}' ";
                var command = new SqlCommand(queryString, dataBs.GetConnection());
                adapter.SelectCommand = command;
                adapter.Fill(table);
                if (table.Rows.Count == 1)
                {
                    MessageBox.Show("Вы успешно вошли!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Uchet uc = new Uchet();
                    uc.DostupUser("Пользователь");
                    this.Hide();
                    uc.ShowDialog();

                  
                }
                else MessageBox.Show("Такого аккаунта не существует!", "Внимание!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dataBs.closeConnection();
            }
            else
            {
                dataBs.openConnection();
                SqlDataAdapter adapter = new SqlDataAdapter();
                DataTable table = new DataTable();
                string queryString = $"SELECT * FROM AdminPan  WHERE login_adm='{textBox1.Text}' AND password_adm='{textBox2.Text}' ";
                var command = new SqlCommand(queryString, dataBs.GetConnection());
                adapter.SelectCommand = command;
                adapter.Fill(table);
                if (table.Rows.Count == 1)
                {
                    MessageBox.Show("Вы успешно вошли!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MainForm mainForm = new MainForm();
                    mainForm.ShowDialog();
                    this.Hide();
                }
                else MessageBox.Show("Такого аккаунта не существует!", "Внимание!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                dataBs.closeConnection();
            }
        }





        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                pictureBox1.Enabled = true;

            }
            else pictureBox1.Enabled = false;
        }
    }
}

