using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Autorizate;
using WindowsFormsApp1.HelperForm;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class Uchet : Form
    {
        DataBase dataBs = new DataBase();
        decimal dec;
        string dostup;
        public Uchet()
        {
            InitializeComponent();
        }
        private void add_btn_Click(object sender, EventArgs e)
        {
           
        }
        private void RefreshDgv()
        {
            dataGridView1.Rows.Clear();
            string queryString = $"SELECT * FROM uchet,klient,photograph,usluga WHERE uchet.klient_id=klient.klient_id and photograph.photograph_id=uchet.photograph_id and uchet.usluga_id=usluga.usluga_id ";
            var command = new SqlCommand(queryString, dataBs.GetConnection());
            dataBs.openConnection();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                ReadSingleRow(dataGridView1, reader);
               
            }
            reader.Close();
        }
        private void CreateColm()
        {
            dataGridView1.Columns.Add("uchet_id", "Код Учёта");
            dataGridView1.Columns.Add("uchet_data", "Дата");
            dataGridView1.Columns.Add("klient_id", "idКлиент");
            dataGridView1.Columns[2].Visible= false;
            dataGridView1.Columns.Add("photograph_id", "idФотограф");
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns.Add("usluga_id", "idУслуга");
            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns.Add("fio", "Клиент");
            dataGridView1.Columns.Add("photograph_fio", "Фотограф");
            dataGridView1.Columns.Add("usluga_name", "Услуга");
            dataGridView1.Columns.Add("Price", "Цена");

        }
       
        private void ReadSingleRow(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetInt32(2), record.GetInt32(3), record.GetInt32(4), record.GetString(6) ,record.GetString(10), record.GetString(14), record.GetString(15));
        }
        public List<int> Kl = new List<int>();
        public List<int> Ph = new List<int>();
        public List<int> Us = new List<int>();
        public int Kl2 = 0;
        public int Ph2 = 0;
        public int Us2 = 0;

        public void Uchet_Load(object sender, EventArgs e)
        {
            CreateColm();
            RefreshDgv();
            if (dostup == "Пользователь")
            {
                Edit_toolStripButton.Enabled = false;
                Del_toolStripButton.Enabled = false;
                Add_toolStripButton.Enabled = false;

            }
        }

       
       

        private void Add_toolStripButton_Click(object sender, EventArgs e)
        {
            AddForm addForm= new AddForm();
            addForm.ShowDialog();
        }

        private void Reload_toolStripButton_Click(object sender, EventArgs e)
        {
            RefreshDgv();
            
        }

        private void Edit_toolStripButton_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex;
            var id = Convert.ToInt32(dataGridView1.Rows[index].Cells[0].Value);
            EditForm af = new EditForm(id);
            if (af.ShowDialog() == DialogResult.OK)
            {

               
                
            }

            
        }

        private void Del_toolStripButton_Click(object sender, EventArgs e)
        {

            int index = dataGridView1.CurrentCell.RowIndex;
            var id = Convert.ToInt32(dataGridView1.Rows[index].Cells[0].Value);
           
            DialogResult result = MessageBox.Show(
        "Вы уверены что хотите удалить товар?",
        "Сообщение",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Information,
        MessageBoxDefaultButton.Button1,
        MessageBoxOptions.RightAlign);

            if (result == DialogResult.Yes)
            {
                dataGridView1.Rows[index].Visible = false;
                if (index != -1)
                {
                    dataBs.openConnection();
                    var deleteQyary = $"DELETE FROM uchet WHERE uchet_id ={id}";
                    var command = new SqlCommand(deleteQyary, dataBs.GetConnection());
                    command.ExecuteNonQuery();
                    dataBs.closeConnection();
                    RefreshDgv();
                }
            }
        }


        private void Search_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                dataGridView1.Rows[i].Selected = false;
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    if (dataGridView1.Rows[i].Cells[j].Value != null)
                    {
                        if (dataGridView1.Rows[i].Cells[j].Value.ToString().Contains(Search.Text))
                        {
                            dataGridView1.Rows[i].Selected = true;
                            break;
                        }
                    }
                }
            }
        }
      
        public void DostupUser(string user)
        {
            dostup= user;
        }

        private void button4_Click(object sender, EventArgs e)
        {

            if (rb1.Checked)
            {
                dataGridView1.Sort(dataGridView1.Columns[0], ListSortDirection.Ascending);
            }
            else if (rb2.Checked)
            {
                dataGridView1.Sort(dataGridView1.Columns[1], ListSortDirection.Ascending);
            }
            else if (rb3.Checked)
            {
                dataGridView1.Sort(dataGridView1.Columns[2], ListSortDirection.Ascending);
            }
            else if (rb4.Checked)
            {
                dataGridView1.Sort(dataGridView1.Columns[3], ListSortDirection.Ascending);
            }
            else if (rb5.Checked)
            {
                dataGridView1.Sort(dataGridView1.Columns[4], ListSortDirection.Ascending);
            }else if (rb6.Checked)
            {
                dataGridView1.Sort(dataGridView1.Columns[5], ListSortDirection.Ascending);
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

            Microsoft.Office.Interop.Excel.Application ExcelApp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook ExcelWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet ExcelWorkSheet;
            //Книга.
            ExcelWorkBook = ExcelApp.Workbooks.Add(System.Reflection.Missing.Value);
            //Таблица.
            ExcelWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)ExcelWorkBook.Worksheets.get_Item(1);
            ExcelWorkSheet.Columns.ColumnWidth = 27;
            ExcelApp.Cells[1, 1] = "Код Учета";
            ExcelApp.Cells[1, 2] = "Дата";
            ExcelApp.Cells[1, 3] = "Код Клиент";
            ExcelApp.Cells[1, 4] = "Код Фотограф";
            ExcelApp.Cells[1, 5] = "Код Услуга";
            ExcelApp.Cells[1, 6] = "Клиент";
            ExcelApp.Cells[1, 7] = "Фотограф";
            ExcelApp.Cells[1, 8] = "Услуга";
            ExcelApp.Cells[1, 9] = "Цена";
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    ExcelApp.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value;
                }
            }
            //Вызываем нашу созданную эксельку.
            ExcelApp.Visible = true;
            ExcelApp.UserControl = true;
        }

        private void выйтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void файлToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Auto auto= new Auto();
            auto.Show();
            this.Close();
        }
    }
}

