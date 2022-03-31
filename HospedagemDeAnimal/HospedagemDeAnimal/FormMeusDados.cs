using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
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
                user.Atualizar(txtNome.Text, txtCelular.Text, Convert.ToInt32(txtCEP.Text), txtEndereco.Text, txtCidade.Text, txtEmail.Text, txtSenha.Text);
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

        private void FormMeusDados_Load(object sender, EventArgs e)
        {
            txtCPF.Enabled = false;
            SqlConnection con = ClassConecta.ObterConexao();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "SELECT * FROM usuario WHERE cpf = '" + FormLogin.usuarioconectado + "'";
            cmd.CommandType = CommandType.Text;
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Usuario user = new Usuario();
                txtNome.Text = dr["nome"].ToString().Trim();
                txtCPF.Text = FormLogin.usuarioconectado;
                txtCelular.Text = dr["celular"].ToString().Trim();
                txtEmail.Text = dr["email"].ToString().Trim();
                txtCEP.Text = dr["cep"].ToString().Trim();
                txtEndereco.Text = dr["endereco"].ToString().Trim();
                txtCidade.Text = dr["cidade"].ToString().Trim();
            }
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://viacep.com.br/ws/" + txtCEP.Text + "/json");
            request.AllowAutoRedirect = false;
            HttpWebResponse ChecaServidor = (HttpWebResponse)request.GetResponse();
            if (ChecaServidor.StatusCode != HttpStatusCode.OK)
            {
                MessageBox.Show("Servidor Indisponível!");
                return; //Sai da rotina e para e codificação
            }
            using (Stream webStream = ChecaServidor.GetResponseStream())
            {
                if (webStream != null)
                {
                    using (StreamReader responseReader = new StreamReader(webStream))
                    {
                        string response = responseReader.ReadToEnd();
                        response = Regex.Replace(response, "[{},]", string.Empty);
                        response = response.Replace("\"", "");

                        String[] substrings = response.Split('\n');

                        int cont = 0;
                        foreach (var substring in substrings)
                        {
                            if (cont == 1)
                            {
                                string[] valor = substring.Split(":".ToCharArray());
                                if (valor[0] == "  erro")
                                {
                                    MessageBox.Show("CEP não encontrado!");
                                    txtCEP.Focus();
                                    return;
                                }
                            }

                            //Endereço
                            if (cont == 2)
                            {
                                string[] valor = substring.Split(":".ToCharArray());
                                txtEndereco.Text = valor[1];
                            }

                            ////Complemento
                            //if (cont == 3)
                            //{
                            //    string[] valor = substring.Split(":".ToCharArray());
                            //    txtComplemento.Text = valor[1];
                            //}

                            //Bairro
                            //if (cont == 4)
                            // {
                            // string[] valor = substring.Split(":".ToCharArray());
                            // lblBairro.Text = valor[1];
                            // }

                            //Cidade
                            if (cont == 5)
                            {
                                string[] valor = substring.Split(":".ToCharArray());
                                txtCidade.Text = valor[1];
                            }
                            cont++;
                        }
                    }
                }
            }
        }
    }
}
