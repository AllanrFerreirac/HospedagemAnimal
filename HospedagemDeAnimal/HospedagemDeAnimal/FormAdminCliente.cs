using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Net;
using System.IO;

namespace HospedagemDeAnimal
{
    public partial class FormAdminCliente : Form
    {
        public FormAdminCliente()
        {
            InitializeComponent();
        }

        private void btnProcurar_Click(object sender, EventArgs e)
        {
            try
            {
                int cpf = Convert.ToInt32(txtCPF.Text.Trim());
                Usuario usuario = new Usuario();
                usuario.Procurar(cpf);
                txtNome.Text = usuario.nome;
                txtCPF.Text = usuario.cpf.ToString();
                txtCelular.Text = usuario.celular.ToString();
                txtCEP.Text = usuario.cep.ToString();
                txtEndereco.Text =usuario.endereco;
                txtCidade.Text = usuario.cidade;
                txtEmail.Text = usuario.email;
                var cargo = usuario.processo == "admin" ? ckbAdmin.Checked : false;
                //ckbAdmin = cargo;
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

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

                            //Complemento
                            if (cont == 3)
                            {
                                string[] valor = substring.Split(":".ToCharArray());
                                txtComplemento.Text = valor[1];
                            }

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

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                int cpf = Convert.ToInt32(txtCPF.Text.Trim());
                Usuario usuario = new Usuario();
                usuario.Exclui(cpf);
                MessageBox.Show("Usuário excluído com sucesso!", "Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Information);
                List<Usuario> usu = usuario.listacliente();
                dgvUsuario.DataSource = usu;
                txtNome.Text = "";
                txtCPF.Text = "";
                txtCelular.Text = "";
                txtCEP.Text = "";
                txtEndereco.Text = "";
                txtCidade.Text = "";
                txtEmail.Text = "";
                ckbAdmin.Text = "";
                ClassConecta.FecharConexao();
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
