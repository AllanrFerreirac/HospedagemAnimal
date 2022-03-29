using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospedagemDeAnimal
{
    public partial class FormMeusDados : Form
    {
        public FormMeusDados()
        {
            InitializeComponent();
        }

        private void btnAtt_Click(object sender, EventArgs e)
        {
            try
            {
                Usuario user = new Usuario();
                user.Atualizar(txtNome.Text, Convert.ToInt32(txtCelular.Text), Convert.ToInt32(txtCEP.Text), txtEndereco.Text, txtCidade.Text, txtEmail.Text, txtSenha.Text);
                MessageBox.Show("Cadastro atualizado com sucesso!", "Atualizar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClassConecta.FecharConexao();
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Text = "";
            txtCPF.Text = "";
            txtCelular.Text = "";
            txtEmail.Text = "";
            txtCEP.Text = "";
            txtEndereco.Text = "";
            txtCidade.Text = "";
            txtSenha.Text = "";
        }
    }
}
