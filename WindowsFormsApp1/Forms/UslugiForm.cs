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
using WindowsFormsApp1.Autorizate;
using WindowsFormsApp1.HelperForm;

namespace WindowsFormsApp1.Forms
{
    public partial class UslugiForm : Form
    {
        DataBase dataBs = new DataBase();
        public UslugiForm()
        {
            InitializeComponent();
        }

        private void UslugiForm_Load(object sender, EventArgs e)
        {
            CreateColm();
            RefreshDgv();
        }

        private void ReadSingleRow(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2));
        }
        private void CreateColm()
        {
            dataGridView1.Columns.Add("usluga_id", "Код Фотографа");
            dataGridView1.Columns.Add("usluga_name", "Название услуги");
            dataGridView1.Columns.Add("usluga_price", "Цена");
            

        }
        private void RefreshDgv()
        {
            dataGridView1.Rows.Clear();
            string queryString = $"SELECT * FROM usluga";
            var command = new SqlCommand(queryString, dataBs.GetConnection());
            dataBs.openConnection();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                ReadSingleRow(dataGridView1, reader);
            }
            reader.Close();
        }
       

        

        private void Edit_toolStripButton_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex;
            var id = Convert.ToInt32(dataGridView1.Rows[index].Cells[0].Value);
            UslugiEdit pe = new UslugiEdit(id);
            pe.ShowDialog();
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

                SqlDataAdapter adapter = new SqlDataAdapter();
                DataTable table = new DataTable();
                string queryString = $"SELECT * FROM uchet WHERE usluga_id={id} ";
                var command = new SqlCommand(queryString, dataBs.GetConnection());
                adapter.SelectCommand = command;
                adapter.Fill(table);
                if (table.Rows.Count >= 1)
                {
                    MessageBox.Show(
           "Клиент используется в  учёте,сначала удалите его там !",
           "Сообщение",
           MessageBoxButtons.YesNo,
           MessageBoxIcon.Information,
           MessageBoxDefaultButton.Button1,
           MessageBoxOptions.RightAlign);
                }
                else
                {
                    dataGridView1.Rows[index].Visible = false;
                    if (index != -1)
                    {
                        dataBs.openConnection();
                        var deleteQyary = $"DELETE FROM usluga WHERE usluga_id = {id} ";
                        command = new SqlCommand(deleteQyary, dataBs.GetConnection());
                        command.ExecuteNonQuery();
                        dataBs.closeConnection();
                        RefreshDgv();
                    }
                }
            }
        }

        private void Add_toolStripButton_Click(object sender, EventArgs e)
        {
            UslugiAdd ad = new UslugiAdd();
            ad.ShowDialog();
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

        private void Reload_toolStripButton_Click(object sender, EventArgs e)
        {
            RefreshDgv();
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
            ExcelApp.Cells[1, 1] = "Код Услуги";
            ExcelApp.Cells[1, 2] = "Название";
            ExcelApp.Cells[1, 3] = "Цена";
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

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
           this.Close();
        }

        private void файлToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Auto auto = new Auto();
            auto.Show();
            this.Close();
        }
    }
}
