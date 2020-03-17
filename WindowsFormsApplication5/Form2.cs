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
    public partial class btn_Finaliza : Form
    {
        double quantid, total, qtda, valorf, somatoria, resultado;        

        public btn_Finaliza()
        {
            InitializeComponent();           
        }
       

        private void carregarlista()
        {
            lst_autor.Items.Clear();
            lst_titulo.Items.Clear();
            lst_valor.Items.Clear();
            lst_qtd.Items.Clear();

            MySqlConnection objcon = new MySqlConnection("server=localhost;port=3306;User Id=root;database=bd_livraria; password=proview7");
            objcon.Open();

            MySqlCommand objcmd = new MySqlCommand("select titulo, autor, valor, qtd from tb_livros", objcon);
            objcmd.Parameters.Clear();


            MySqlDataReader dr;
            dr = objcmd.ExecuteReader();


            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    lst_titulo.Items.Add(dr[0].ToString());
                    lst_autor.Items.Add(dr[1].ToString());
                    lst_valor.Items.Add(dr[2].ToString());
                    lst_qtd.Items.Add(dr[3].ToString());
                }
            }
            objcon.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            carregarlista();
        }

        private void lst_qtd_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox l = sender as ListBox;

            if (l.SelectedIndex != -1)
            {
                lst_titulo.SelectedIndex = l.SelectedIndex;
                lst_autor.SelectedIndex = l.SelectedIndex;
                lst_valor.SelectedIndex = l.SelectedIndex;
                lst_qtd.SelectedIndex = l.SelectedIndex;


            }
        }

        private void lst_titulo_DoubleClick(object sender, EventArgs e)
        {              
        }

        private void bnt_limpa_Click(object sender, EventArgs e)
        {
            lbl_titulo2.Text = "";
            lbl_qtd2.Text = "";
            txt_qtd.Clear();
            lbl_valorlivro.Text = "";

        }

        private void lst_qtd_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            ListBox l = sender as ListBox;

            if (l.SelectedIndex != -1)
            {
                lst_titulo.SelectedIndex = l.SelectedIndex;
                lst_autor.SelectedIndex = l.SelectedIndex;
                lst_valor.SelectedIndex = l.SelectedIndex;
                lst_qtd.SelectedIndex = l.SelectedIndex;          

            }
        }

        private void lst_qtd2_SelectedIndexChanged_1(object sender, EventArgs e)
        {
       
        }

        private void btn_escolha_Click(object sender, EventArgs e)
        {
          
            lbl_qtd2.Text = lst_qtd.SelectedItem.ToString();   //essa linha a mais
            lbl_titulo2.Text = lst_titulo.SelectedItem.ToString(); //essa
            lbl_valorlivro.Text = lst_valor.SelectedItem.ToString(); //essa
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lst_carrinho.Items.Remove(lst_carrinho.SelectedItem);
            lst_valorf.Items.Remove(lst_valorf.SelectedItem);
            lst_qtdcompra.Items.Remove(lst_qtdcompra.SelectedItem);
            lst_valorfim.Items.Remove(lst_valorfim.SelectedItem);

            somatoria = 0;

            for (int i = 0; i < lst_valorfim.Items.Count; i++)
            {
                somatoria = somatoria + Convert.ToDouble(lst_valorfim.Items[i]);
            }

            lbl_valor.Text = Convert.ToString(somatoria);

        }

        private void bnt_procuraautor_Click(object sender, EventArgs e)
        {
            try
            {
                lst_autor.Items.Clear();
                lst_titulo.Items.Clear();
                lst_valor.Items.Clear();
                lst_qtd.Items.Clear();

                MySqlConnection objcon = new MySqlConnection("server=localhost;port=3306;User Id=root;database=bd_livraria; password=proview7");
                objcon.Open();

                MySqlCommand objcmd = new MySqlCommand("select titulo, autor, valor, qtd from tb_livros where autor = ?", objcon);
                objcmd.Parameters.Clear();
                objcmd.Parameters.Add("@autor", MySqlDbType.VarChar,50).Value = txt_pesquisaautor.Text;

                objcmd.CommandType = CommandType.Text;

                MySqlDataReader dr;
                dr = objcmd.ExecuteReader();


                DataTable dt = new DataTable();
                dt.Load(dr);
                DataRow linhas = null;
                if (dt.Rows.Count > 0)
                {
                    linhas = dt.Rows[0];
                    lst_titulo.Items.Add(linhas[0].ToString());
                    lst_autor.Items.Add(linhas[1].ToString());
                    lst_valor.Items.Add(linhas[2].ToString());
                    lst_qtd.Items.Add(linhas[3].ToString());
                }
                else
                {
                    MessageBox.Show("Autor inexistente no Banco de Dados");
                }
            }
            catch(Exception erro)
            {
                MessageBox.Show("Não deu certo a busca" + erro);
            }
         }  

        private void bnt_todoslivros_Click(object sender, EventArgs e)
        {
            carregarlista();
        }

        private void button2_Click(object sender, EventArgs e)
        {
          
              MessageBox.Show("Compra Finalizada com sucesso");
                        

              lst_carrinho.Items.Clear();
              lst_valorf.Items.Clear();
              lst_qtdcompra.Items.Clear();
              lst_valorfim.Items.Clear();
              lbl_valor.Text = "";

        }

        private void lst_valorfim_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox li = sender as ListBox;

            if (li.SelectedIndex != -1)
            {
                lst_carrinho.SelectedIndex = li.SelectedIndex;
                lst_valorf.SelectedIndex = li.SelectedIndex;
                lst_qtdcompra.SelectedIndex = li.SelectedIndex;
                lst_valorfim.SelectedIndex = li.SelectedIndex;
            }
        }

        private void lst_qtd2_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void btn_adiciona_Click(object sender, EventArgs e)
        {
            try
            {


                if (lst_carrinho.Items.Contains(lbl_titulo2.Text))                                          
                {
                    MessageBox.Show("item ja existe no carrinho de compra");
                }

                else
                {
                    quantid = double.Parse(txt_qtd.Text);
                    qtda = Convert.ToDouble(lbl_qtd2.Text);                                      
                    valorf = Convert.ToDouble(lbl_valorlivro.Text);
                    resultado = qtda - quantid;                  

                    if (quantid <=qtda && quantid !=0)
                      {

                          total = quantid * valorf;

                        lst_carrinho.Items.Add(lbl_titulo2.Text);
                        lst_valorf.Items.Add(lbl_valorlivro.Text);
                        lst_qtdcompra.Items.Add(txt_qtd.Text);
                        lst_valorfim.Items.Add(total.ToString());

                        lbl_titulo2.Text = "";
                        lbl_qtd2.Text = "";
                        txt_qtd.Clear();
                        lbl_valorlivro.Text = "";

                      } 
                    else
                    {
                        MessageBox.Show("quantidade maior que em estoque ou 0");
                    }
                }

                  somatoria = 0;

                  for (int i = 0; i < lst_valorfim.Items.Count; i++)
                  {

                    somatoria = somatoria + Convert.ToDouble(lst_valorfim.Items[i]);              
                  }

                  lbl_valor.Text = Convert.ToString(somatoria);
            }

            catch (Exception erro)
            {
                MessageBox.Show("Verifique quantidade em estoque" + erro);
            }
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
