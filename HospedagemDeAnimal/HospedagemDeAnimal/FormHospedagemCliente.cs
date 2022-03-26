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
    public partial class FormHospedagemCliente : Form
    {
        public FormHospedagemCliente()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Aluno\source\repos\HospedagemPet-main\HospedagemAnimal-main\HospedagemDeAnimal\HospedagemDeAnimal\DatabaseHospedagem.mdf;Integrated Security=True");

        public void CarregaCbxAnimal()
        {
            var cpfTutor = FormLogin.usuarioconectado;
            string cli = "SELECT * FROM animal WHERE cpf_tutor ='" + FormLogin.usuarioconectado + "' ORDER BY nome";
            SqlCommand cmd = new SqlCommand(cli, con);
            con.Open();
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cli, con);
            DataSet ds = new DataSet();
            da.Fill(ds, "animal");
            cbxAnimal.ValueMember = "cpf_tutor";
            cbxAnimal.DisplayMember = "nome";
            cbxAnimal.DataSource = ds.Tables["animal"];
            con.Close();
        }

        private void btnLocalizar_Click_1(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(txtID.Text.Trim());
                Hospedagem hsp = new Hospedagem();
                hsp.Localiza(id);
                cbxAnimal.SelectedItem = hsp.id_animal.ToString().Trim();
                dtpDtInicio.Value = Convert.ToDateTime(hsp.checkin);
                dtpDtFim.Value = Convert.ToDateTime(hsp.checkout).AddDays(1);
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void btnCadastro_Click_1(object sender, EventArgs e)
        {
            try
            {
                Hospedagem hsp = new Hospedagem();
                hsp.Inserir(cbxAnimal.ValueMember, dtpDtInicio.Value, dtpDtFim.Value);
                MessageBox.Show("Hospedagem reservada com sucesso!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                string animal = cbxAnimal.ValueMember;
                this.dtpDtInicio.Value = DateTime.Now.Date;
                this.dtpDtFim.Value = DateTime.Now.Date.AddDays(1);
                ClassConecta.FecharConexao();
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void btnAttPet_Click_1(object sender, EventArgs e)
        {
            try
            {
                Hospedagem hsp = new Hospedagem();
                hsp.Atualizar(txtID.Text, cbxAnimal.ValueMember, dtpDtInicio.Value, dtpDtFim.Value);
                MessageBox.Show("Hospedagem atualizada com sucesso!", "Atualizar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.dtpDtInicio.Value = DateTime.Now.Date;
                this.dtpDtFim.Value = DateTime.Now.Date.AddDays(1);
                ClassConecta.FecharConexao();
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void btnConfirmar_Click_1(object sender, EventArgs e)
        {
            try
            {
                Hospedagem hsp = new Hospedagem();
                hsp.Confirmar(txtID.Text);
                MessageBox.Show("Hospedagem confirmada com sucesso!", "Atualizar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.dtpDtInicio.Value = DateTime.Now.Date;
                this.dtpDtFim.Value = DateTime.Now.Date.AddDays(1);
                ClassConecta.FecharConexao();
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void btnExcluirPet_Click_1(object sender, EventArgs e)
        {
            try
            {
                string id = txtID.Text.Trim();
                Pet pet = new Pet();
                pet.Excluir(id);
                MessageBox.Show("Hospedagem excluída com sucesso!", "Deletar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.dtpDtInicio.Value = DateTime.Now.Date;
                this.dtpDtFim.Value = DateTime.Now.Date.AddDays(1);
                ClassConecta.FecharConexao();
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            FormPrincipal form = new FormPrincipal();
            form.Show();
        }

        private void FormHospedagemCliente_Load_1(object sender, EventArgs e)
        {
            CarregaCbxAnimal();
        }

        private void dgvPet_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dgvPet.Rows[e.RowIndex];
            cbxAnimal.Text = row.Cells[1].Value.ToString();
            dtpDtInicio.Text = row.Cells[2].Value.ToString();
            dtpDtFim.Text = row.Cells[3].Value.ToString();
        }
    }
}
