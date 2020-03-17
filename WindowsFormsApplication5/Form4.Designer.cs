namespace WindowsFormsApplication5
{
    partial class Form4
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
            this.lst_qtd = new System.Windows.Forms.ListBox();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.lbl_autor = new System.Windows.Forms.Label();
            this.lbl_valor = new System.Windows.Forms.Label();
            this.lbl_qtd = new System.Windows.Forms.Label();
            this.lst_ID = new System.Windows.Forms.ListBox();
            this.lbl_ID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lst_titulo
            // 
            this.lst_titulo.FormattingEnabled = true;
            this.lst_titulo.Location = new System.Drawing.Point(81, 54);
            this.lst_titulo.Name = "lst_titulo";
            this.lst_titulo.Size = new System.Drawing.Size(519, 446);
            this.lst_titulo.TabIndex = 0;
            this.lst_titulo.SelectedIndexChanged += new System.EventHandler(this.lst_ID_SelectedIndexChanged);
            // 
            // lst_autor
            // 
            this.lst_autor.FormattingEnabled = true;
            this.lst_autor.Location = new System.Drawing.Point(606, 54);
            this.lst_autor.Name = "lst_autor";
            this.lst_autor.Size = new System.Drawing.Size(204, 446);
            this.lst_autor.TabIndex = 1;
            this.lst_autor.SelectedIndexChanged += new System.EventHandler(this.lst_ID_SelectedIndexChanged);
            // 
            // lst_valor
            // 
            this.lst_valor.FormattingEnabled = true;
            this.lst_valor.Location = new System.Drawing.Point(816, 54);
            this.lst_valor.Name = "lst_valor";
            this.lst_valor.Size = new System.Drawing.Size(75, 446);
            this.lst_valor.TabIndex = 2;
            this.lst_valor.SelectedIndexChanged += new System.EventHandler(this.lst_ID_SelectedIndexChanged);
            // 
            // lst_qtd
            // 
            this.lst_qtd.FormattingEnabled = true;
            this.lst_qtd.Location = new System.Drawing.Point(897, 54);
            this.lst_qtd.Name = "lst_qtd";
            this.lst_qtd.Size = new System.Drawing.Size(75, 446);
            this.lst_qtd.TabIndex = 3;
            this.lst_qtd.SelectedIndexChanged += new System.EventHandler(this.lst_ID_SelectedIndexChanged);
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Location = new System.Drawing.Point(297, 23);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(40, 13);
            this.lbl_titulo.TabIndex = 4;
            this.lbl_titulo.Text = "Títulos";
            // 
            // lbl_autor
            // 
            this.lbl_autor.AutoSize = true;
            this.lbl_autor.Location = new System.Drawing.Point(685, 23);
            this.lbl_autor.Name = "lbl_autor";
            this.lbl_autor.Size = new System.Drawing.Size(49, 13);
            this.lbl_autor.TabIndex = 5;
            this.lbl_autor.Text = "Autor(es)";
            // 
            // lbl_valor
            // 
            this.lbl_valor.AutoSize = true;
            this.lbl_valor.Location = new System.Drawing.Point(835, 23);
            this.lbl_valor.Name = "lbl_valor";
            this.lbl_valor.Size = new System.Drawing.Size(31, 13);
            this.lbl_valor.TabIndex = 6;
            this.lbl_valor.Text = "Valor";
            // 
            // lbl_qtd
            // 
            this.lbl_qtd.AutoSize = true;
            this.lbl_qtd.Location = new System.Drawing.Point(894, 23);
            this.lbl_qtd.Name = "lbl_qtd";
            this.lbl_qtd.Size = new System.Drawing.Size(121, 13);
            this.lbl_qtd.TabIndex = 7;
            this.lbl_qtd.Text = "Quantidade em Estoque";
            this.lbl_qtd.Click += new System.EventHandler(this.label4_Click);
            // 
            // lst_ID
            // 
            this.lst_ID.FormattingEnabled = true;
            this.lst_ID.Location = new System.Drawing.Point(25, 54);
            this.lst_ID.Name = "lst_ID";
            this.lst_ID.Size = new System.Drawing.Size(50, 446);
            this.lst_ID.TabIndex = 8;
            this.lst_ID.SelectedIndexChanged += new System.EventHandler(this.lst_ID_SelectedIndexChanged);
            // 
            // lbl_ID
            // 
            this.lbl_ID.AutoSize = true;
            this.lbl_ID.Location = new System.Drawing.Point(35, 23);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(18, 13);
            this.lbl_ID.TabIndex = 9;
            this.lbl_ID.Text = "ID";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 566);
            this.Controls.Add(this.lbl_ID);
            this.Controls.Add(this.lst_ID);
            this.Controls.Add(this.lbl_qtd);
            this.Controls.Add(this.lbl_valor);
            this.Controls.Add(this.lbl_autor);
            this.Controls.Add(this.lbl_titulo);
            this.Controls.Add(this.lst_qtd);
            this.Controls.Add(this.lst_valor);
            this.Controls.Add(this.lst_autor);
            this.Controls.Add(this.lst_titulo);
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lst_titulo;
        private System.Windows.Forms.ListBox lst_autor;
        private System.Windows.Forms.ListBox lst_valor;
        private System.Windows.Forms.ListBox lst_qtd;
        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Label lbl_autor;
        private System.Windows.Forms.Label lbl_valor;
        private System.Windows.Forms.Label lbl_qtd;
        private System.Windows.Forms.ListBox lst_ID;
        private System.Windows.Forms.Label lbl_ID;
    }
}