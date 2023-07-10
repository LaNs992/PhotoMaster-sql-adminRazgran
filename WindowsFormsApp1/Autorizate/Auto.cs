using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Forms;

namespace WindowsFormsApp1.Autorizate
{
    public partial class Auto : Form
    {
        public Auto()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            OpenTheDorForm Op=new OpenTheDorForm();
            isAdmin = true;
            Op.ShowDialog();
            this.Hide();

           

        }
        public static bool isAdmin= false;
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Uchet uc = new Uchet();
            uc.DostupUser("Пользователь");
            isAdmin = false;
            OpenTheDorForm Op = new OpenTheDorForm();
            Op.ShowDialog();
            this.Hide();
        }
    }
}
