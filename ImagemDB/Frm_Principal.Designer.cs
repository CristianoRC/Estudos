namespace ImagemDB
{
    partial class Frm_Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Principal));
            this.panelImagem = new System.Windows.Forms.Panel();
            this.picPessoa = new System.Windows.Forms.PictureBox();
            this.Btm_Procurar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Txt_Nome = new System.Windows.Forms.TextBox();
            this.Txt_Estado = new System.Windows.Forms.TextBox();
            this.Txt_Municipio = new System.Windows.Forms.TextBox();
            this.Txt_CPF = new System.Windows.Forms.MaskedTextBox();
            this.Txt_CEP = new System.Windows.Forms.MaskedTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Btm_Salvar = new System.Windows.Forms.ToolStripMenuItem();
            this.Btm_Carregar = new System.Windows.Forms.ToolStripMenuItem();
            this.panelImagem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPessoa)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelImagem
            // 
            this.panelImagem.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panelImagem.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelImagem.Controls.Add(this.Btm_Procurar);
            this.panelImagem.Controls.Add(this.picPessoa);
            this.panelImagem.Location = new System.Drawing.Point(404, 1);
            this.panelImagem.Name = "panelImagem";
            this.panelImagem.Size = new System.Drawing.Size(260, 325);
            this.panelImagem.TabIndex = 10;
            // 
            // picPessoa
            // 
            this.picPessoa.Image = ((System.Drawing.Image)(resources.GetObject("picPessoa.Image")));
            this.picPessoa.Location = new System.Drawing.Point(11, 9);
            this.picPessoa.Name = "picPessoa";
            this.picPessoa.Size = new System.Drawing.Size(235, 229);
            this.picPessoa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPessoa.TabIndex = 0;
            this.picPessoa.TabStop = false;
            // 
            // Btm_Procurar
            // 
            this.Btm_Procurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btm_Procurar.Location = new System.Drawing.Point(9, 276);
            this.Btm_Procurar.Name = "Btm_Procurar";
            this.Btm_Procurar.Size = new System.Drawing.Size(235, 32);
            this.Btm_Procurar.TabIndex = 0;
            this.Btm_Procurar.Text = "Procurar Imagem";
            this.Btm_Procurar.UseVisualStyleBackColor = true;
            this.Btm_Procurar.Click += new System.EventHandler(this.Btm_Procurar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "CEP";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Estado";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 290);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Município";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "CPF";
            // 
            // Txt_Nome
            // 
            this.Txt_Nome.Location = new System.Drawing.Point(72, 50);
            this.Txt_Nome.Name = "Txt_Nome";
            this.Txt_Nome.Size = new System.Drawing.Size(319, 20);
            this.Txt_Nome.TabIndex = 1;
            // 
            // Txt_Estado
            // 
            this.Txt_Estado.Location = new System.Drawing.Point(72, 227);
            this.Txt_Estado.Name = "Txt_Estado";
            this.Txt_Estado.Size = new System.Drawing.Size(319, 20);
            this.Txt_Estado.TabIndex = 7;
            // 
            // Txt_Municipio
            // 
            this.Txt_Municipio.Location = new System.Drawing.Point(72, 286);
            this.Txt_Municipio.Name = "Txt_Municipio";
            this.Txt_Municipio.Size = new System.Drawing.Size(319, 20);
            this.Txt_Municipio.TabIndex = 9;
            // 
            // Txt_CPF
            // 
            this.Txt_CPF.Location = new System.Drawing.Point(72, 109);
            this.Txt_CPF.Mask = "000.000.000-00";
            this.Txt_CPF.Name = "Txt_CPF";
            this.Txt_CPF.Size = new System.Drawing.Size(319, 20);
            this.Txt_CPF.TabIndex = 3;
            this.Txt_CPF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Txt_CEP
            // 
            this.Txt_CEP.Location = new System.Drawing.Point(72, 168);
            this.Txt_CEP.Mask = "00.000-000";
            this.Txt_CEP.Name = "Txt_CEP";
            this.Txt_CEP.Size = new System.Drawing.Size(319, 20);
            this.Txt_CEP.TabIndex = 5;
            this.Txt_CEP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Txt_CEP.Leave += new System.EventHandler(this.Txt_CEP_Leave);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Btm_Salvar,
            this.Btm_Carregar});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(662, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Btm_Salvar
            // 
            this.Btm_Salvar.Name = "Btm_Salvar";
            this.Btm_Salvar.Size = new System.Drawing.Size(93, 20);
            this.Btm_Salvar.Text = "Salvar Usuario";
            this.Btm_Salvar.Click += new System.EventHandler(this.Btm_Salvar_Click);
            // 
            // Btm_Carregar
            // 
            this.Btm_Carregar.Name = "Btm_Carregar";
            this.Btm_Carregar.Size = new System.Drawing.Size(107, 20);
            this.Btm_Carregar.Text = "Carregar Usuario";
            this.Btm_Carregar.Click += new System.EventHandler(this.Btm_Carregar_Click);
            // 
            // Frm_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(662, 326);
            this.Controls.Add(this.Txt_CEP);
            this.Controls.Add(this.Txt_CPF);
            this.Controls.Add(this.Txt_Municipio);
            this.Controls.Add(this.Txt_Estado);
            this.Controls.Add(this.Txt_Nome);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelImagem);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Imagens no Banco De Dados";
            this.panelImagem.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picPessoa)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelImagem;
        private System.Windows.Forms.PictureBox picPessoa;
        private System.Windows.Forms.Button Btm_Procurar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Txt_Nome;
        private System.Windows.Forms.TextBox Txt_Estado;
        private System.Windows.Forms.TextBox Txt_Municipio;
        private System.Windows.Forms.MaskedTextBox Txt_CPF;
        private System.Windows.Forms.MaskedTextBox Txt_CEP;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Btm_Salvar;
        private System.Windows.Forms.ToolStripMenuItem Btm_Carregar;
    }
}

