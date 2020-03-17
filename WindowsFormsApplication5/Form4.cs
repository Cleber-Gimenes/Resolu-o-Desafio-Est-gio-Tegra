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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void lst_titulo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void carregarlista()
        {
            lst_titulo.Items.Clear();
            lst_autor.Items.Clear();
            lst_valor.Items.Clear();
            lst_qtd.Items.Clear();
            lst_ID.Items.Clear();

            MySqlConnection objcon = new MySqlConnection("server=localhost;port=3306;User Id=root;database=bd_livraria; password=proview7");
            objcon.Open();

            MySqlCommand objcmd = new MySqlCommand("select ID,titulo, autor, valor, qtd from tb_livros", objcon);
            objcmd.Parameters.Clear();
            

            MySqlDataReader dr;
            dr = objcmd.ExecuteReader();
            

            if (dr.HasRows)
            {
                while(dr.Read())
                    {
                        lst_ID.Items.Add(dr[0].ToString());
                        lst_titulo.Items.Add(dr[1].ToString());
                        lst_autor.Items.Add(dr[2].ToString());
                        lst_valor.Items.Add(dr[3].ToString());
                        lst_qtd.Items.Add(dr[4].ToString());
                                                  
                }
            }
            objcon.Close();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            carregarlista();
        }

        private void lst_qtd_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lst_ID_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox l = sender as ListBox;

            if (l.SelectedIndex != -1)
            {
                lst_ID.SelectedIndex = l.SelectedIndex;
                lst_titulo.SelectedIndex = l.SelectedIndex;
                lst_autor.SelectedIndex = l.SelectedIndex;
                lst_valor.SelectedIndex = l.SelectedIndex;
                lst_qtd.SelectedIndex = l.SelectedIndex;


            }
        }
    }
}
