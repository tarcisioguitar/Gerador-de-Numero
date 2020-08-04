namespace gerador_de_numero
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.cbQuantidadeJogos = new System.Windows.Forms.ComboBox();
            this.cbQuantidadeNumeros = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGerar = new System.Windows.Forms.Button();
            this.jogo1 = new System.Windows.Forms.Label();
            this.jogo2 = new System.Windows.Forms.Label();
            this.jogo3 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Número de Jogos:";
            // 
            // cbQuantidadeJogos
            // 
            this.cbQuantidadeJogos.FormattingEnabled = true;
            this.cbQuantidadeJogos.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cbQuantidadeJogos.Location = new System.Drawing.Point(42, 64);
            this.cbQuantidadeJogos.Name = "cbQuantidadeJogos";
            this.cbQuantidadeJogos.Size = new System.Drawing.Size(90, 21);
            this.cbQuantidadeJogos.TabIndex = 1;
            // 
            // cbQuantidadeNumeros
            // 
            this.cbQuantidadeNumeros.FormattingEnabled = true;
            this.cbQuantidadeNumeros.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15"});
            this.cbQuantidadeNumeros.Location = new System.Drawing.Point(183, 64);
            this.cbQuantidadeNumeros.Name = "cbQuantidadeNumeros";
            this.cbQuantidadeNumeros.Size = new System.Drawing.Size(121, 21);
            this.cbQuantidadeNumeros.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(181, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Quantidade de números:";
            // 
            // btnGerar
            // 
            this.btnGerar.Location = new System.Drawing.Point(42, 116);
            this.btnGerar.Name = "btnGerar";
            this.btnGerar.Size = new System.Drawing.Size(75, 23);
            this.btnGerar.TabIndex = 4;
            this.btnGerar.Text = "Gerar";
            this.btnGerar.UseVisualStyleBackColor = true;
            this.btnGerar.Click += new System.EventHandler(this.btnGerar_Click);
            // 
            // jogo1
            // 
            this.jogo1.AutoSize = true;
            this.jogo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.jogo1.Location = new System.Drawing.Point(36, 189);
            this.jogo1.Name = "jogo1";
            this.jogo1.Size = new System.Drawing.Size(64, 25);
            this.jogo1.TabIndex = 5;
            this.jogo1.Text = "label3";
            // 
            // jogo2
            // 
            this.jogo2.AutoSize = true;
            this.jogo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.jogo2.Location = new System.Drawing.Point(36, 268);
            this.jogo2.Name = "jogo2";
            this.jogo2.Size = new System.Drawing.Size(64, 25);
            this.jogo2.TabIndex = 6;
            this.jogo2.Text = "label4";
            // 
            // jogo3
            // 
            this.jogo3.AutoSize = true;
            this.jogo3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.jogo3.Location = new System.Drawing.Point(36, 346);
            this.jogo3.Name = "jogo3";
            this.jogo3.Size = new System.Drawing.Size(64, 25);
            this.jogo3.TabIndex = 7;
            this.jogo3.Text = "label5";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(183, 115);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(121, 23);
            this.progressBar1.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.jogo3);
            this.Controls.Add(this.jogo2);
            this.Controls.Add(this.jogo1);
            this.Controls.Add(this.btnGerar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbQuantidadeNumeros);
            this.Controls.Add(this.cbQuantidadeJogos);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbQuantidadeJogos;
        private System.Windows.Forms.ComboBox cbQuantidadeNumeros;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGerar;
        private System.Windows.Forms.Label jogo1;
        private System.Windows.Forms.Label jogo2;
        private System.Windows.Forms.Label jogo3;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

