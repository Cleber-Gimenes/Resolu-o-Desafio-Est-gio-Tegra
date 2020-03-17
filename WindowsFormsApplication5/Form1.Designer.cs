namespace WindowsFormsApplication5
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.bnt_livros = new System.Windows.Forms.Button();
            this.bnt_produtos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Millimeter, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(57, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 81);
            this.label1.TabIndex = 0;
            this.label1.Text = "Livraria C";
            // 
            // bnt_livros
            // 
            this.bnt_livros.Location = new System.Drawing.Point(37, 159);
            this.bnt_livros.Name = "bnt_livros";
            this.bnt_livros.Size = new System.Drawing.Size(125, 47);
            this.bnt_livros.TabIndex = 1;
            this.bnt_livros.Text = "Venda de Livros";
            this.bnt_livros.UseVisualStyleBackColor = true;
            this.bnt_livros.Click += new System.EventHandler(this.bnt_livros_Click);
            // 
            // bnt_produtos
            // 
            this.bnt_produtos.Location = new System.Drawing.Point(252, 159);
            this.bnt_produtos.Name = "bnt_produtos";
            this.bnt_produtos.Size = new System.Drawing.Size(125, 47);
            this.bnt_produtos.TabIndex = 2;
            this.bnt_produtos.Text = "Configurar Livros";
            this.bnt_produtos.UseVisualStyleBackColor = true;
            this.bnt_produtos.Click += new System.EventHandler(this.bnt_produtos_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 325);
            this.Controls.Add(this.bnt_produtos);
            this.Controls.Add(this.bnt_livros);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Livraria C";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bnt_livros;
        private System.Windows.Forms.Button bnt_produtos;
    }
}

