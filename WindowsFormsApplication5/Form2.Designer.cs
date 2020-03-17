namespace WindowsFormsApplication5
{
    partial class btn_Finaliza
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
            this.lst_titulo = new System.Windows.Forms.ListBox();
            this.lst_autor = new System.Windows.Forms.ListBox();
            this.lst_valor = new System.Windows.Forms.ListBox();
            this.txt_qtd = new System.Windows.Forms.TextBox();
            this.btn_adiciona = new System.Windows.Forms.Button();
            this.bnt_limpa = new System.Windows.Forms.Button();
            this.lst_qtd = new System.Windows.Forms.ListBox();
            this.lst_carrinho = new System.Windows.Forms.ListBox();
            this.btn_escolha = new System.Windows.Forms.Button();
            this.lst_valorf = new System.Windows.Forms.ListBox();
            this.lst_qtdcompra = new System.Windows.Forms.ListBox();
            this.lst_valorfim = new System.Windows.Forms.ListBox();
            this.lbl_valor = new System.Windows.Forms.Label();
            this.lbl_qtd2 = new System.Windows.Forms.Label();
            this.lbl_titulo2 = new System.Windows.Forms.Label();
            this.lbl_valorlivro = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.bnt_todoslivros = new System.Windows.Forms.Button();
            this.bnt_procuraautor = new System.Windows.Forms.Button();
            this.txt_pesquisaautor = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lst_titulo
            // 
            this.lst_titulo.FormattingEnabled = true;
            this.lst_titulo.Location = new System.Drawing.Point(2, 135);
            this.lst_titulo.Name = "lst_titulo";
            this.lst_titulo.Size = new System.Drawing.Size(583, 290);
            this.lst_titulo.TabIndex = 0;
            this.lst_titulo.SelectedIndexChanged += new System.EventHandler(this.lst_qtd_SelectedIndexChanged_1);
            // 
            // lst_autor
            // 
            this.lst_autor.FormattingEnabled = true;
            this.lst_autor.Location = new System.Drawing.Point(579, 135);
            this.lst_autor.Name = "lst_autor";
            this.lst_autor.Size = new System.Drawing.Size(233, 290);
            this.lst_autor.TabIndex = 1;
            this.lst_autor.SelectedIndexChanged += new System.EventHandler(this.lst_qtd_SelectedIndexChanged_1);
            // 
            // lst_valor
            // 
            this.lst_valor.FormattingEnabled = true;
            this.lst_valor.Location = new System.Drawing.Point(799, 135);
            this.lst_valor.Name = "lst_valor";
            this.lst_valor.Size = new System.Drawing.Size(89, 290);
            this.lst_valor.TabIndex = 2;
            this.lst_valor.SelectedIndexChanged += new System.EventHandler(this.lst_qtd_SelectedIndexChanged_1);
            // 
            // txt_qtd
            // 
            this.txt_qtd.Location = new System.Drawing.Point(1520, 66);
            this.txt_qtd.Name = "txt_qtd";
            this.txt_qtd.Size = new System.Drawing.Size(78, 20);
            this.txt_qtd.TabIndex = 6;
            // 
            // btn_adiciona
            // 
            this.btn_adiciona.Location = new System.Drawing.Point(1170, 113);
            this.btn_adiciona.Name = "btn_adiciona";
            this.btn_adiciona.Size = new System.Drawing.Size(124, 51);
            this.btn_adiciona.TabIndex = 7;
            this.btn_adiciona.Text = "Adicionar ao Carrinho";
            this.btn_adiciona.UseVisualStyleBackColor = true;
            this.btn_adiciona.Click += new System.EventHandler(this.btn_adiciona_Click);
            // 
            // bnt_limpa
            // 
            this.bnt_limpa.Location = new System.Drawing.Point(1430, 113);
            this.bnt_limpa.Name = "bnt_limpa";
            this.bnt_limpa.Size = new System.Drawing.Size(124, 51);
            this.bnt_limpa.TabIndex = 12;
            this.bnt_limpa.Text = "Limpar os Campos";
            this.bnt_limpa.UseVisualStyleBackColor = true;
            this.bnt_limpa.Click += new System.EventHandler(this.bnt_limpa_Click);
            // 
            // lst_qtd
            // 
            this.lst_qtd.FormattingEnabled = true;
            this.lst_qtd.Location = new System.Drawing.Point(884, 135);
            this.lst_qtd.Name = "lst_qtd";
            this.lst_qtd.Size = new System.Drawing.Size(89, 290);
            this.lst_qtd.TabIndex = 9;
            this.lst_qtd.SelectedIndexChanged += new System.EventHandler(this.lst_qtd_SelectedIndexChanged_1);
            // 
            // lst_carrinho
            // 
            this.lst_carrinho.FormattingEnabled = true;
            this.lst_carrinho.Location = new System.Drawing.Point(2, 553);
            this.lst_carrinho.Name = "lst_carrinho";
            this.lst_carrinho.Size = new System.Drawing.Size(583, 264);
            this.lst_carrinho.TabIndex = 10;
            this.lst_carrinho.SelectedIndexChanged += new System.EventHandler(this.lst_valorfim_SelectedIndexChanged);
            // 
            // btn_escolha
            // 
            this.btn_escolha.Location = new System.Drawing.Point(989, 276);
            this.btn_escolha.Name = "btn_escolha";
            this.btn_escolha.Size = new System.Drawing.Size(124, 51);
            this.btn_escolha.TabIndex = 12;
            this.btn_escolha.Text = "Escolher a Quantidade";
            this.btn_escolha.UseVisualStyleBackColor = true;
            this.btn_escolha.Click += new System.EventHandler(this.btn_escolha_Click);
            // 
            // lst_valorf
            // 
            this.lst_valorf.FormattingEnabled = true;
            this.lst_valorf.Location = new System.Drawing.Point(579, 553);
            this.lst_valorf.Name = "lst_valorf";
            this.lst_valorf.Size = new System.Drawing.Size(89, 264);
            this.lst_valorf.TabIndex = 13;
            this.lst_valorf.SelectedIndexChanged += new System.EventHandler(this.lst_valorfim_SelectedIndexChanged);
            // 
            // lst_qtdcompra
            // 
            this.lst_qtdcompra.FormattingEnabled = true;
            this.lst_qtdcompra.Location = new System.Drawing.Point(661, 553);
            this.lst_qtdcompra.Name = "lst_qtdcompra";
            this.lst_qtdcompra.Size = new System.Drawing.Size(80, 264);
            this.lst_qtdcompra.TabIndex = 14;
            this.lst_qtdcompra.SelectedIndexChanged += new System.EventHandler(this.lst_valorfim_SelectedIndexChanged);
            // 
            // lst_valorfim
            // 
            this.lst_valorfim.FormattingEnabled = true;
            this.lst_valorfim.Location = new System.Drawing.Point(738, 553);
            this.lst_valorfim.Name = "lst_valorfim";
            this.lst_valorfim.Size = new System.Drawing.Size(89, 264);
            this.lst_valorfim.TabIndex = 15;
            this.lst_valorfim.SelectedIndexChanged += new System.EventHandler(this.lst_valorfim_SelectedIndexChanged);
            // 
            // lbl_valor
            // 
            this.lbl_valor.BackColor = System.Drawing.Color.White;
            this.lbl_valor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_valor.Location = new System.Drawing.Point(1129, 681);
            this.lbl_valor.Name = "lbl_valor";
            this.lbl_valor.Size = new System.Drawing.Size(124, 38);
            this.lbl_valor.TabIndex = 18;
            this.lbl_valor.Text = "Valor Final das Compras";
            this.lbl_valor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_qtd2
            // 
            this.lbl_qtd2.BackColor = System.Drawing.Color.White;
            this.lbl_qtd2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_qtd2.Location = new System.Drawing.Point(1413, 68);
            this.lbl_qtd2.Name = "lbl_qtd2";
            this.lbl_qtd2.Size = new System.Drawing.Size(66, 18);
            this.lbl_qtd2.TabIndex = 19;
            this.lbl_qtd2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_titulo2
            // 
            this.lbl_titulo2.BackColor = System.Drawing.Color.White;
            this.lbl_titulo2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_titulo2.Location = new System.Drawing.Point(1113, 68);
            this.lbl_titulo2.Name = "lbl_titulo2";
            this.lbl_titulo2.Size = new System.Drawing.Size(222, 18);
            this.lbl_titulo2.TabIndex = 20;
            this.lbl_titulo2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_valorlivro
            // 
            this.lbl_valorlivro.BackColor = System.Drawing.Color.White;
            this.lbl_valorlivro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_valorlivro.Location = new System.Drawing.Point(1341, 68);
            this.lbl_valorlivro.Name = "lbl_valorlivro";
            this.lbl_valorlivro.Size = new System.Drawing.Size(66, 18);
            this.lbl_valorlivro.TabIndex = 21;
            this.lbl_valorlivro.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(1100, 681);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 38);
            this.label1.TabIndex = 22;
            this.label1.Text = "R$";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(442, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(253, 35);
            this.label2.TabIndex = 23;
            this.label2.Text = "Livros Disponíveis";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(332, 455);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(253, 35);
            this.label3.TabIndex = 24;
            this.label3.Text = "Carrinho de Compras";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1060, 603);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(253, 35);
            this.label4.TabIndex = 25;
            this.label4.Text = "Valor Final das Compras";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(829, 633);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 51);
            this.button1.TabIndex = 26;
            this.button1.Text = "Excluir do Carrinho";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1283, 675);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(124, 51);
            this.button2.TabIndex = 27;
            this.button2.Text = "Finalizar Compra";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1517, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 35);
            this.label5.TabIndex = 28;
            this.label5.Text = "Digite a quantidade desejada para compra";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(814, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 35);
            this.label6.TabIndex = 29;
            this.label6.Text = "Valor R$";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(890, 97);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 35);
            this.label7.TabIndex = 30;
            this.label7.Text = "Quantidade em Estoque";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 97);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(204, 35);
            this.label8.TabIndex = 31;
            this.label8.Text = "Selecione o livro desejado !";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(585, 519);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 13);
            this.label9.TabIndex = 32;
            this.label9.Text = "Valor Unitário";
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(670, 519);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 31);
            this.label10.TabIndex = 33;
            this.label10.Text = "Quantidade da Compra";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(754, 519);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 13);
            this.label11.TabIndex = 34;
            this.label11.Text = "Valor Total";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(156, 519);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 13);
            this.label12.TabIndex = 35;
            this.label12.Text = "Título";
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(1413, 28);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(98, 35);
            this.label13.TabIndex = 36;
            this.label13.Text = "Quantidade em Estoque";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(1348, 28);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(48, 35);
            this.label14.TabIndex = 37;
            this.label14.Text = "Valor R$";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(1200, 39);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(35, 13);
            this.label15.TabIndex = 38;
            this.label15.Text = "Título";
            // 
            // bnt_todoslivros
            // 
            this.bnt_todoslivros.Location = new System.Drawing.Point(29, 12);
            this.bnt_todoslivros.Name = "bnt_todoslivros";
            this.bnt_todoslivros.Size = new System.Drawing.Size(93, 37);
            this.bnt_todoslivros.TabIndex = 39;
            this.bnt_todoslivros.Text = "Exibir Todos os Livros";
            this.bnt_todoslivros.UseVisualStyleBackColor = true;
            this.bnt_todoslivros.Click += new System.EventHandler(this.bnt_todoslivros_Click);
            // 
            // bnt_procuraautor
            // 
            this.bnt_procuraautor.Location = new System.Drawing.Point(235, 12);
            this.bnt_procuraautor.Name = "bnt_procuraautor";
            this.bnt_procuraautor.Size = new System.Drawing.Size(93, 37);
            this.bnt_procuraautor.TabIndex = 39;
            this.bnt_procuraautor.Text = "Pesquisar por Autor";
            this.bnt_procuraautor.UseVisualStyleBackColor = true;
            this.bnt_procuraautor.Click += new System.EventHandler(this.bnt_procuraautor_Click);
            // 
            // txt_pesquisaautor
            // 
            this.txt_pesquisaautor.Location = new System.Drawing.Point(334, 21);
            this.txt_pesquisaautor.Name = "txt_pesquisaautor";
            this.txt_pesquisaautor.Size = new System.Drawing.Size(251, 20);
            this.txt_pesquisaautor.TabIndex = 41;
            // 
            // btn_Finaliza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1639, 829);
            this.Controls.Add(this.txt_pesquisaautor);
            this.Controls.Add(this.bnt_procuraautor);
            this.Controls.Add(this.bnt_todoslivros);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_valorlivro);
            this.Controls.Add(this.lbl_titulo2);
            this.Controls.Add(this.lbl_qtd2);
            this.Controls.Add(this.lbl_valor);
            this.Controls.Add(this.lst_valorfim);
            this.Controls.Add(this.lst_qtdcompra);
            this.Controls.Add(this.lst_valorf);
            this.Controls.Add(this.btn_escolha);
            this.Controls.Add(this.lst_carrinho);
            this.Controls.Add(this.lst_qtd);
            this.Controls.Add(this.bnt_limpa);
            this.Controls.Add(this.btn_adiciona);
            this.Controls.Add(this.txt_qtd);
            this.Controls.Add(this.lst_valor);
            this.Controls.Add(this.lst_autor);
            this.Controls.Add(this.lst_titulo);
            this.Name = "btn_Finaliza";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vendas";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lst_titulo;
        private System.Windows.Forms.ListBox lst_autor;
        private System.Windows.Forms.ListBox lst_valor;
        private System.Windows.Forms.TextBox txt_qtd;
        private System.Windows.Forms.Button btn_adiciona;
        private System.Windows.Forms.Button bnt_limpa;
        private System.Windows.Forms.ListBox lst_qtd;
        private System.Windows.Forms.ListBox lst_carrinho;
        private System.Windows.Forms.Button btn_escolha;
        private System.Windows.Forms.ListBox lst_valorf;
        private System.Windows.Forms.ListBox lst_qtdcompra;
        private System.Windows.Forms.ListBox lst_valorfim;
        private System.Windows.Forms.Label lbl_valor;
        private System.Windows.Forms.Label lbl_qtd2;
        private System.Windows.Forms.Label lbl_titulo2;
        private System.Windows.Forms.Label lbl_valorlivro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button bnt_todoslivros;
        private System.Windows.Forms.Button bnt_procuraautor;
        private System.Windows.Forms.TextBox txt_pesquisaautor;
    }
}