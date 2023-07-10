using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Autorizate;

namespace WindowsFormsApp1.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Spr_Click(object sender, EventArgs e)
        {
             Klient kl= new Klient();
            kl.ShowDialog();
        }

        private void Oil_Click(object sender, EventArgs e)
        {
            Photograph kl = new Photograph();
            kl.ShowDialog();
        }

        private void Uchet_Click(object sender, EventArgs e)
        {
            Uchet kl = new Uchet();
            kl.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UslugiForm kl = new UslugiForm();
            kl.ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void выйтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Бажин Кирилл Андреевич! Ип-20-3");
        }

        private void файлToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Auto auto = new Auto();
            auto.Show();
            this.Close();
        }
    }
}
