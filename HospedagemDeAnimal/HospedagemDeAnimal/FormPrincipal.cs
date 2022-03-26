using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospedagemDeAnimal
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(ClassConecta.stringconexao);

        private void meusPetsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPet form = new FormPet();
            form.Show();
        }

        private void meusDadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCadastroCliente form = new FormCadastroCliente();
            form.Show();
        }

        private void hospedarMeuPetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string cli = "SELECT * FROM animal WHERE cpf_tutor ='" + FormLogin.usuarioconectado + "'";
            SqlCommand cmd = new SqlCommand(cli, con);
            con.Open();
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                FormHospedagemCliente form = new FormHospedagemCliente();
                form.Show();
            }
            else
            {
                MessageBox.Show("É necessário ter ao menos um pet cadastrado para acessar suas hospedagens :(", "Oops!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            var user = FormLogin.usuarioconectado;
        }

        private void hospedagensToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FormLogin.cargo == "admin")
            {
                FormHospedagemAdmin form = new FormHospedagemAdmin();
                form.Show();
            }
            else
            {
                MessageBox.Show("Você não tem autorização para acessar essa página.", "Oops!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FormLogin.cargo == "admin")
            {
                FormAdminCliente form = new FormAdminCliente();
                form.Show();
            }
            else
            {
                MessageBox.Show("Você não tem autorização para acessar essa página.", "Oops!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
