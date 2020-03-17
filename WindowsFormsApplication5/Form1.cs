using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApplication5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bnt_livros_Click(object sender, EventArgs e)
        {
            btn_Finaliza formu2 = new btn_Finaliza();
            formu2.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void bnt_produtos_Click(object sender, EventArgs e)
        {
            Form3 formu3 = new Form3();
            formu3.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
