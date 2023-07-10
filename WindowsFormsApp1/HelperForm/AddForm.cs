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
    public partial class AddForm : Form
    {
        DataBase dataBs = new DataBase();
        public AddForm()
        {

            InitializeComponent();
        }
        public int id = 0;
        public AddForm(int idsender):this()
        {
           id = (int)idsender;
          
        

        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AddForm_Load(object sender, EventArgs e)
        {
            var queryString = $"SELECT klient_id,fio FROM klient";
            var command = new SqlCommand(queryString, dataBs.GetConnection());
            dataBs.openConnection();
            SqlDataReader reader = command.ExecuteReader();
            KlientcomboBox.Items.Clear();
            while (reader.Read())
            {
                KlientcomboBox.Items.Add(reader[1].ToString());
                Kl.Add(int.Parse(reader[0].ToString()));
            }
            reader.Close();

            queryString = $"SELECT photograph_id,photograph_fio FROM photograph";
            command = new SqlCommand(queryString, dataBs.GetConnection());
            reader = command.ExecuteReader();
            dataBs.openConnection();
            PhotocomboBox.Items.Clear();
            while (reader.Read())
            {
                PhotocomboBox.Items.Add(reader[1].ToString());
                Ph.Add(int.Parse(reader[0].ToString()));

            }
            reader.Close();
            queryString = $"SELECT usluga_id,usluga_name FROM usluga";
            command = new SqlCommand(queryString, dataBs.GetConnection());
            reader = command.ExecuteReader();
            dataBs.openConnection();
            UslugicomboBox.Items.Clear();
            while (reader.Read())
            {
                UslugicomboBox.Items.Add(reader[1].ToString());
                Us.Add(int.Parse(reader[0].ToString()));
            }
            reader.Close();
            KlientcomboBox.SelectedIndex = 0;
            PhotocomboBox.SelectedIndex = 0;
            UslugicomboBox.SelectedIndex = 0;
        }
        public List<int> Kl = new List<int>();
        public List<int> Ph = new List<int>();
        public List<int> Us = new List<int>();
        public int Kl2 = 0;
        public int Ph2 = 0;
        public int Us2 = 0;
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataBs.openConnection();
            if (KlientcomboBox.Text != "")
            {
                var addQuery = $"INSERT INTO uchet(uchet_data,klient_id,photograph_id,usluga_id) VALUES ('{dateTimePicker1.Value}',"
                   + $"'{Kl2}','{Ph2}','{Us2}')";
                var command = new SqlCommand(addQuery, dataBs.GetConnection());
                command.ExecuteNonQuery();
                MessageBox.Show("Новая запись успешно создана!");
               
            }
            else
            {
                MessageBox.Show("Введите правльно!!");
            }
            dataBs.closeConnection();
        }

        private void KlientcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Kl2 = Kl[KlientcomboBox.SelectedIndex];
        }

        private void PhotocomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Ph2 = Ph[PhotocomboBox.SelectedIndex];
        }

        private void UslugicomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Us2 = Us[UslugicomboBox.SelectedIndex];
        }
    }
}
