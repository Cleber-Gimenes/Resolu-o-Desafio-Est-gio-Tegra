namespace WindowsFormsApplication5
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_titulo = new System.Windows.Forms.TextBox();
            this.txt_autor = new System.Windows.Forms.TextBox();
            this.txt_valor = new System.Windows.Forms.TextBox();
            this.txt_qtd = new System.Windows.Forms.TextBox();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.lbl_autor = new System.Windows.Forms.Label();
            this.lbl_estoque = new System.Windows.Forms.Label();
            this.lbl_valor = new System.Windows.Forms.Label();
            this.btn_busca = new System.Windows.Forms.Button();
            this.btn_inserir = new System.Windows.Forms.Button();
            this.btn_deleta = new System.Windows.Forms.Button();
            this.btn_altera = new System.Windows.Forms.Button();
            this.lbl_texto = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.lbl_ID = new System.Windows.Forms.Label();
            this.bnt_limpa = new System.Windows.Forms.Button();
            this.btn_lista = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_titulo
            // 
            this.txt_titulo.Location = new System.Drawing.Point(24, 122);
            this.txt_titulo.Name = "txt_titulo";
            this.txt_titulo.Size = new System.Drawing.Size(349, 20);
            this.txt_titulo.TabIndex = 0;
            // 
            // txt_autor
            // 
            this.txt_autor.Location = new System.Drawing.Point(24, 158);
            this.txt_autor.Name = "txt_autor";
            this.txt_autor.Size = new System.Drawing.Size(349, 20);
            this.txt_autor.TabIndex = 1;
            // 
            // txt_valor
            // 
            this.txt_valor.Location = new System.Drawing.Point(24, 199);
            this.txt_valor.Name = "txt_valor";
            this.txt_valor.Size = new System.Drawing.Size(105, 20);
            this.txt_valor.TabIndex = 2;
            // 
            // txt_qtd
            // 
            this.txt_qtd.Location = new System.Drawing.Point(24, 235);
            this.txt_qtd.Name = "txt_qtd";
            this.txt_qtd.Size = new System.Drawing.Size(105, 20);
            this.txt_qtd.TabIndex = 3;
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Location = new System.Drawing.Point(385, 125);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(76, 13);
            this.lbl_titulo.TabIndex = 4;
            this.lbl_titulo.Text = "Título do Livro";
            // 
            // lbl_autor
            // 
            this.lbl_autor.AutoSize = true;
            this.lbl_autor.Location = new System.Drawing.Point(385, 161);
            this.lbl_autor.Name = "lbl_autor";
            this.lbl_autor.Size = new System.Drawing.Size(90, 13);
            this.lbl_autor.TabIndex = 5;
            this.lbl_autor.Text = "Autor(es) do Livro";
            // 
            // lbl_estoque
            // 
            this.lbl_estoque.AutoSize = true;
            this.lbl_estoque.Location = new System.Drawing.Point(186, 238);
            this.lbl_estoque.Name = "lbl_estoque";
            this.lbl_estoque.Size = new System.Drawing.Size(121, 13);
            this.lbl_estoque.TabIndex = 6;
            this.lbl_estoque.Text = "Quantidade em Estoque";
            // 
            // lbl_valor
            // 
            this.lbl_valor.AutoSize = true;
            this.lbl_valor.Location = new System.Drawing.Point(186, 206);
            this.lbl_valor.Name = "lbl_valor";
            this.lbl_valor.Size = new System.Drawing.Size(72, 13);
            this.lbl_valor.TabIndex = 7;
            this.lbl_valor.Text = "Valor do Livro";
            // 
            // btn_busca
            // 
            this.btn_busca.Location = new System.Drawing.Point(144, 75);
            this.btn_busca.Name = "btn_busca";
            this.btn_busca.Size = new System.Drawing.Size(75, 23);
            this.btn_busca.TabIndex = 8;
            this.btn_busca.Text = "Busca";
            this.btn_busca.UseVisualStyleBackColor = true;
            this.btn_busca.Click += new System.EventHandler(this.btn_busca_Click);
            // 
            // btn_inserir
            // 
            this.btn_inserir.Location = new System.Drawing.Point(54, 291);
            this.btn_inserir.Name = "btn_inserir";
            this.btn_inserir.Size = new System.Drawing.Size(75, 23);
            this.btn_inserir.TabIndex = 9;
            this.btn_inserir.Text = "Inserir";
            this.btn_inserir.UseVisualStyleBackColor = true;
            this.btn_inserir.Click += new System.EventHandler(this.btn_inserir_Click);
            // 
            // btn_deleta
            // 
            this.btn_deleta.Location = new System.Drawing.Point(250, 291);
            this.btn_deleta.Name = "btn_deleta";
            this.btn_deleta.Size = new System.Drawing.Size(75, 23);
            this.btn_deleta.TabIndex = 10;
            this.btn_deleta.Text = "Deletar";
            this.btn_deleta.UseVisualStyleBackColor = true;
            this.btn_deleta.Click += new System.EventHandler(this.btn_deleta_Click);
            // 
            // btn_altera
            // 
            this.btn_altera.Location = new System.Drawing.Point(445, 291);
            this.btn_altera.Name = "btn_altera";
            this.btn_altera.Size = new System.Drawing.Size(75, 23);
            this.btn_altera.TabIndex = 11;
            this.btn_altera.Text = "Alterar";
            this.btn_altera.UseVisualStyleBackColor = true;
            this.btn_altera.Click += new System.EventHandler(this.btn_altera_Click);
            // 
            // lbl_texto
            // 
            this.lbl_texto.AutoSize = true;
            this.lbl_texto.Font = new System.Drawing.Font("Comic Sans MS", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_texto.Location = new System.Drawing.Point(115, 25);
            this.lbl_texto.Name = "lbl_texto";
            this.lbl_texto.Size = new System.Drawing.Size(317, 28);
            this.lbl_texto.TabIndex = 12;
            this.lbl_texto.Text = "Adiciona, Altera e Insere Livros ";
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(24, 77);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(58, 20);
            this.txt_id.TabIndex = 13;
            // 
            // lbl_ID
            // 
            this.lbl_ID.AutoSize = true;
            this.lbl_ID.Location = new System.Drawing.Point(93, 83);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(18, 13);
            this.lbl_ID.TabIndex = 14;
            this.lbl_ID.Text = "ID";
            // 
            // bnt_limpa
            // 
            this.bnt_limpa.Location = new System.Drawing.Point(379, 73);
            this.bnt_limpa.Name = "bnt_limpa";
            this.bnt_limpa.Size = new System.Drawing.Size(115, 23);
            this.bnt_limpa.TabIndex = 15;
            this.bnt_limpa.Text = "Limpar os campos";
            this.bnt_limpa.UseVisualStyleBackColor = true;
            this.bnt_limpa.Click += new System.EventHandler(this.bnt_limpa_Click);
            // 
            // btn_lista
            // 
            this.btn_lista.Location = new System.Drawing.Point(198, 340);
            this.btn_lista.Name = "btn_lista";
            this.btn_lista.Size = new System.Drawing.Size(176, 23);
            this.btn_lista.TabIndex = 16;
            this.btn_lista.Text = "Lista de Livros Salvos";
            this.btn_lista.UseVisualStyleBackColor = true;
            this.btn_lista.Click += new System.EventHandler(this.btn_lista_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 410);
            this.Controls.Add(this.btn_lista);
            this.Controls.Add(this.bnt_limpa);
            this.Controls.Add(this.lbl_ID);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.lbl_texto);
            this.Controls.Add(this.btn_altera);
            this.Controls.Add(this.btn_deleta);
            this.Controls.Add(this.btn_inserir);
            this.Controls.Add(this.btn_busca);
            this.Controls.Add(this.lbl_valor);
            this.Controls.Add(this.lbl_estoque);
            this.Controls.Add(this.lbl_autor);
            this.Controls.Add(this.lbl_titulo);
            this.Controls.Add(this.txt_qtd);
            this.Controls.Add(this.txt_valor);
            this.Controls.Add(this.txt_autor);
            this.Controls.Add(this.txt_titulo);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciamento";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_titulo;
        private System.Windows.Forms.TextBox txt_autor;
        private System.Windows.Forms.TextBox txt_valor;
        private System.Windows.Forms.TextBox txt_qtd;
        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Label lbl_autor;
        private System.Windows.Forms.Label lbl_estoque;
        private System.Windows.Forms.Label lbl_valor;
        private System.Windows.Forms.Button btn_busca;
        private System.Windows.Forms.Button btn_inserir;
        private System.Windows.Forms.Button btn_deleta;
        private System.Windows.Forms.Button btn_altera;
        private System.Windows.Forms.Label lbl_texto;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label lbl_ID;
        private System.Windows.Forms.Button bnt_limpa;
        private System.Windows.Forms.Button btn_lista;
    }
}