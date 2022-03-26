using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Data.SqlClient;

namespace HospedagemDeAnimal
{
    public partial class FormLogin : Form
    {
        public static string usuarioconectado;
        public static string cargo;
        public FormLogin()
        {
            InitializeComponent();
            FormSplash splash = new FormSplash();
            splash.Show();
            Thread.Sleep(4000);
            splash.Close();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            txtCPF.Focus();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = ClassConecta.ObterConexao();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "SELECT * FROM usuario WHERE cpf=@cpf AND senha=@senha";
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@cpf", SqlDbType.NChar).Value = txtCPF.Text.Trim();
                cmd.Parameters.AddWithValue("@senha", SqlDbType.NChar).Value = txtSenha.Text.Trim();
                SqlDataReader usuario = cmd.ExecuteReader();
                if (usuario.HasRows)
                {
                    usuarioconectado = txtCPF.Text;
                    //cargo = usuario["processo"].ToString();
                    this.Hide();
                    FormPrincipal hos = new FormPrincipal();
                    hos.Show();
                    ClassConecta.FecharConexao();
                }
                else
                {
                    MessageBox.Show("CPF ou senha inválido! Por favor, tente novamente!", "Erro de Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCPF.Text = "";
                    txtSenha.Text = "";
                    txtCPF.Focus();
                    ClassConecta.FecharConexao();
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            FormCadastroCliente cad = new FormCadastroCliente();
            cad.Show();
        }
    }
}
