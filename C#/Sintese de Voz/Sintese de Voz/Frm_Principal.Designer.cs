namespace Sintese_de_Voz
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
            this.txt_Frase = new System.Windows.Forms.RichTextBox();
            this.btn_Falar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_Frase
            // 
            this.txt_Frase.Location = new System.Drawing.Point(13, 13);
            this.txt_Frase.Name = "txt_Frase";
            this.txt_Frase.Size = new System.Drawing.Size(533, 297);
            this.txt_Frase.TabIndex = 0;
            this.txt_Frase.Text = "";
            // 
            // btn_Falar
            // 
            this.btn_Falar.BackColor = System.Drawing.Color.Transparent;
            this.btn_Falar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.btn_Falar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Falar.Location = new System.Drawing.Point(13, 316);
            this.btn_Falar.Name = "btn_Falar";
            this.btn_Falar.Size = new System.Drawing.Size(533, 44);
            this.btn_Falar.TabIndex = 1;
            this.btn_Falar.Text = "Falar";
            this.btn_Falar.UseVisualStyleBackColor = false;
            this.btn_Falar.Click += new System.EventHandler(this.btn_Falar_Click);
            // 
            // Frm_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(558, 372);
            this.Controls.Add(this.btn_Falar);
            this.Controls.Add(this.txt_Frase);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Principal";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sintetisador";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox txt_Frase;
        private System.Windows.Forms.Button btn_Falar;
    }
}

