using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.Threading;

namespace MetroUIexemplo
{
    public partial class Frm_Principal : MetroForm
    {
        private List<DotCEP.Endereco> enderecos = new List<DotCEP.Endereco>();

        public Frm_Principal()
        {
            InitializeComponent();
            metroGrid1.DataSource = enderecos;
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            var result = DotCEP.Consultas.ObterEnderecoCompleto(txt_cep.Text);
            enderecos.Add(result);

            metroGrid1.DataSource = null;
            metroGrid1.DataSource = enderecos;
        }
    }
}
