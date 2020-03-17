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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btn_busca_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection objcon = new MySqlConnection("server=localhost;port=3306;User Id=root;database=bd_livraria; password=proview7");
                objcon.Open();
                MySqlCommand objcmd = new MySqlCommand("select ID, titulo, autor, valor, qtd from tb_livros where ID = ?", objcon);
                objcmd.Parameters.Clear();
                objcmd.Parameters.Add("@ID", MySqlDbType.Int32).Value = txt_id.Text;          

                objcmd.CommandType = CommandType.Text;

                //recebe o conteudo que vem do banco!
                MySqlDataReader dr;                
                dr = objcmd.ExecuteReader();

                DataTable dt = new DataTable();
                dt.Load(dr);
                DataRow linhas = null;
                if (dt.Rows.Count>0)
                {
                    linhas = dt.Rows[0];
                    txt_titulo.Text = linhas[1].ToString();
                    txt_autor.Text = linhas[2].ToString();
                    txt_valor.Text = linhas[3].ToString();
                    txt_qtd.Text = linhas[4].ToString();
                }
                else
                {
                    MessageBox.Show("ID Inexistente no Banco de Dados");
                }
                       

                          
                       
                objcon.Close();
            }
            catch(Exception erro)
            {

              MessageBox.Show("Erro ao pesquisar registro" + erro);                              
            }


        }

        private void btn_inserir_Click(object sender, EventArgs e)
        {
           
            if (txt_id.Text != "" & txt_titulo.Text != "" & txt_autor.Text != "" & txt_valor.Text != "" & txt_qtd.Text != "")
            {

                MySqlConnection objcon = new MySqlConnection("server=localhost;port=3306;User Id=root;database=bd_livraria; password=proview7");
                objcon.Open();

                ///comando SQL para inserir dados na tabela                
                MySqlCommand objcmd = new MySqlCommand("insert into tb_livros (ID, titulo, autor, valor, qtd) values (?,?,?,?,?)", objcon);
                objcmd.Parameters.Clear();
                objcmd.Parameters.Add("@ID", MySqlDbType.Int32, 5).Value = txt_id.Text;
                objcmd.Parameters.Add("@titulo", MySqlDbType.VarChar, 110).Value = txt_titulo.Text;
                objcmd.Parameters.Add("@autor", MySqlDbType.VarChar, 50).Value = txt_autor.Text;
                objcmd.Parameters.Add("@valor", MySqlDbType.Decimal, 5).Value = txt_valor.Text;
                objcmd.Parameters.Add("@qtd", MySqlDbType.Int32, 5).Value = txt_qtd.Text;
                

                ///comando para executar query
                objcmd.ExecuteNonQuery();
                MessageBox.Show("Salvo com Sucesso");
                objcon.Close();

                txt_id.Text = "";
                txt_titulo.Text = "";
                txt_autor.Text = "";
                txt_valor.Text = "";
                txt_qtd.Text = "";
            }
            
            else
            {
                MessageBox.Show("Não Salvou");
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_deleta_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection objcon = new MySqlConnection("server=localhost;port=3306;User Id=root;database=bd_livraria; password=proview7");
                objcon.Open();
                MySqlCommand objcmd = new MySqlCommand("delete from tb_livros where ID = ?", objcon);
                objcmd.Parameters.Clear();
                objcmd.Parameters.Add("@ID", MySqlDbType.Int32).Value = txt_id.Text;

                objcmd.CommandType = CommandType.Text;
                objcmd.ExecuteNonQuery();
                MessageBox.Show("Registro removido com sucesso");
                objcon.Close();

                txt_id.Text = "";
                txt_titulo.Text = "";
                txt_autor.Text = "";
                txt_valor.Text = "";
                txt_qtd.Text = "";
            }
            catch (Exception erro)
            {
                MessageBox.Show("Não foi possivel deletar:" + erro);
            }
        }

        private void btn_altera_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection objcon = new MySqlConnection("server=localhost;port=3306;User Id=root;database=bd_livraria; password=proview7");
                objcon.Open();
                MySqlCommand objcmd = new MySqlCommand("update tb_livros set titulo =?, autor =?, valor =?, qtd =? where ID = ?", objcon);
                objcmd.Parameters.Clear();
                objcmd.Parameters.Add("@titulo", MySqlDbType.VarChar, 110).Value = txt_titulo.Text;
                objcmd.Parameters.Add("@autor", MySqlDbType.VarChar, 50).Value = txt_autor.Text;
                objcmd.Parameters.Add("@valor", MySqlDbType.Decimal, 5).Value = txt_valor.Text;
                objcmd.Parameters.Add("@qtd", MySqlDbType.Int32, 5).Value = txt_qtd.Text;
                objcmd.Parameters.Add("@ID", MySqlDbType.Int32, 5).Value = txt_id.Text;

                //executa comando
                objcmd.CommandType = CommandType.Text;
                objcmd.ExecuteNonQuery();
                MessageBox.Show("Alterado com sucesso");

                objcon.Close();

                txt_id.Text = "";
                txt_titulo.Text = "";
                txt_autor.Text = "";
                txt_valor.Text = "";
                txt_qtd.Text = "";


            }
            catch(Exception erro)
            {
                MessageBox.Show("Não foi possivel alterar:" + erro);
            }
        }

        private void bnt_limpa_Click(object sender, EventArgs e)
        {
            try
            {
                txt_id.Text = "";
                txt_titulo.Text = "";
                txt_autor.Text = "";
                txt_valor.Text = "";
                txt_qtd.Text = "";
            }
            catch (Exception erro)
            {
                MessageBox.Show("Não Limpou:" + erro);
            }
        }

        private void btn_lista_Click(object sender, EventArgs e)
        {

            Form4 formu4 = new Form4();
            formu4.ShowDialog();


        }
    }
}      
        


