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
                string cpf = txtCPF.Text.Trim();
                Usuario usuario = new Usuario();
                usuario.Procurar(cpf);
                txtNome.Text = usuario.nome.Trim();
                txtCPF.Text = usuario.cpf.Trim();
                txtCelular.Text = usuario.celular.ToString().Trim();
                txtCEP.Text = usuario.cep.ToString().Trim();
                txtEndereco.Text = usuario.endereco.Trim();
                txtCidade.Text = usuario.cidade.Trim();
                txtEmail.Text = usuario.email.Trim();
                if (usuario.processo.Trim() == "admin")
                {
                    ckbAdmin.Checked = true;
                }
                else
                {
                    ckbAdmin.Checked = false;
                }
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

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                string cpf = txtCPF.Text.Trim();
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
                var cargo = usuario.processo == "admin" ? ckbAdmin.Checked : false;
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

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                int cep = Convert.ToInt32(txtCEP.Text.Trim());
                Usuario usuario = new Usuario();
                usuario.AtualizarAdmin(txtNome.Text, txtCPF.Text, txtCelular.Text, cep, txtEndereco.Text, txtCidade.Text, txtEmail.Text, ckbAdmin.Checked);
                MessageBox.Show("Usuário salvo com sucesso!", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                List<Usuario> usu = usuario.listacliente();
                dgvUsuario.DataSource = usu;
                txtNome.Text = "";
                txtCPF.Text = "";
                txtCelular.Text = "";
                txtCEP.Text = "";
                txtEndereco.Text = "";
                txtCidade.Text = "";
                txtEmail.Text = "";
                ClassConecta.FecharConexao();
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void dgvUsuario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dgvUsuario.Rows[e.RowIndex];
            txtNome.Text = row.Cells[1].Value.ToString().Trim();
            txtCPF.Text = row.Cells[2].Value.ToString().Trim();
            txtCelular.Text = row.Cells[3].Value.ToString().Trim();
            txtCEP.Text = row.Cells[4].Value.ToString().Trim();
            txtEndereco.Text = row.Cells[5].Value.ToString().Trim();
            txtCidade.Text = row.Cells[6].Value.ToString().Trim();
            txtEmail.Text = row.Cells[7].Value.ToString().Trim();

            var processo = row.Cells[9].Value.ToString().Trim();
            if (processo == "admin")
            {
                ckbAdmin.Checked = true;
            }
            else
            {
                ckbAdmin.Checked = false;
            }
        }

        private void FormAdminCliente_Load(object sender, EventArgs e)
        {
            Usuario cli = new Usuario();
            List<Usuario> usuario = cli.listacliente();
            dgvUsuario.DataSource = usuario;
        }

    }
}
