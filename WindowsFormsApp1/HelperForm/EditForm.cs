using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.HelperForm
{
    public partial class EditForm : Form
    {
        DataBase dataBs = new DataBase();
        public EditForm()
        {
            InitializeComponent();
            Edit();
        }
        public int id = 0;
        public List<int> Kl = new List<int>();
        public List<int> Ph = new List<int>();
        public List<int> Us = new List<int>();
        public int Kl2 = 0;
        public int Ph2 = 0;
        public int Us2 = 0;
        public EditForm(int idsender) : this()
        {
            id = (int)idsender;

            var main = $"SELECT uchet_data,klient_id,photograph_id,usluga_id FROM uchet WHERE uchet_id={id} ";
            var command = new SqlCommand(main, dataBs.GetConnection());
            dataBs.openConnection();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                dateTimePicker1.Text =reader[0].ToString();      
                KlientcomboBox.SelectedIndex = Kl.IndexOf(int.Parse(reader[1].ToString()));
                PhotocomboBox.SelectedIndex = Ph.IndexOf(int.Parse(reader[2].ToString()));
                UslugicomboBox.SelectedIndex = Us.IndexOf(int.Parse(reader[3].ToString()));
                Kl2 = int.Parse(reader[1].ToString());
                Ph2 = int.Parse(reader[2].ToString());
                Us2 = int.Parse(reader[3].ToString());
            }
            reader.Close();



        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (KlientcomboBox.Text != string.Empty)
            {
             
                dataBs.openConnection();
                var changequery = $"UPDATE uchet SET uchet_data = '{dateTimePicker1.Value}',klient_id = {Kl2},photograph_id = {Ph2},usluga_id = {Us2} WHERE uchet_id={id}";
                var command = new SqlCommand(changequery, dataBs.GetConnection());
                command.ExecuteNonQuery();
                dataBs.closeConnection();
               
            }
            else
            {
                MessageBox.Show("Введите правильно!");
            }
        }
        public void Edit()
        {
            var queryString = $"SELECT klient_id,fio  FROM  klient ";
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
        
    

        private void EditForm_Load(object sender, EventArgs e)
        {

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
