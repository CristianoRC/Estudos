using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImagemDB
{
    public partial class Frm_Principal : Form
    {
        public Frm_Principal()
        {
            InitializeComponent();
        }

        private void Btm_Procurar_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();

            of.RestoreDirectory = true;
            of.Filter = "Imagens|*.bmp;*.jpg;*.jpeg;*.png;*.tif;*.tiff" +
                        "BMP|*.bmp|GIF|*.gif|JPG|*.jpg;*.jpeg|PNG|*.png|TIFF|*.tif;*.tiff|";

            DialogResult resultado = of.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                picPessoa.ImageLocation = of.FileName;
            }

        }

        private void Txt_CEP_Leave(object sender, EventArgs e)
        {
            //Fazer verificação e preenchimento dos Txt sobre o CEP.
        }

        private void Btm_Salvar_Click(object sender, EventArgs e)
        {

        }

        private void Btm_Carregar_Click(object sender, EventArgs e)
        {

        }
    }
}
