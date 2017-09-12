using System;
using System.Windows.Forms;

namespace ExemploDotCEP
{
    public partial class Frm_Principal : Form
    {
        public Frm_Principal()
        {
            InitializeComponent();
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            try
            {
                var enderecoCep = DotCEP.Consultas.ObterEnderecoCompleto(txt_cep.Text);

                preencherLabesl(enderecoCep);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void preencherLabesl(DotCEP.Endereco endereco)
        {
            lbl_bairro.Text = $@"Bairro: {endereco.bairro}";
            lbl_CEP.Text = $@"CEP: {DotCEP.Formatacao.FormatarCEP(endereco.cep)}";
            lbl_cidade.Text = $@"Cidade: {endereco.localidade}";
            lbl_Estado.Text = $@"Estado: {DotCEP.Localidades.Estado.ObterNomeDoEstado(endereco.uf)}";
            lbl_logradouro.Text = $@"Logradouro: {endereco.logradouro}";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"https://github.com/CristianoRC/DotCEP/");
        }
    }
}