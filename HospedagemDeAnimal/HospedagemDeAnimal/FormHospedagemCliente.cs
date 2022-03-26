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

        SqlConnection con = new SqlConnection(ClassConecta.stringconexao);

        public void MinhasHospedagens()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM hospedagem WHERE cpf_tutor = @cpf_tutor", con);
            /*SELECT h.id AS [IdHospedagem], a.nome AS [Animal], h.checkin as [Checkin], h.checkout as [Checkout], h.status as [Status]
            FROM hospedagem AS h
            INNER JOIN animal AS a ON h.id_animal = a.id
            INNER JOIN usuario AS u ON a.cpf_tutor = u.cpf 
            WHERE u.cpf = 123456*/

            cmd.Parameters.AddWithValue("@cpf_tutor", FormLogin.usuarioconectado);
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            int linhas = dt.Rows.Count;
            if (dt.Rows.Count > 0)
            {
                dgvPet.Columns.Add("ID", "ID");
                dgvPet.Columns.Add("Nome", "Nome");
                dgvPet.Columns.Add("Sexo", "Sexo");
                dgvPet.Columns.Add("Raça", "Raça");
                dgvPet.Columns.Add("Espécie", "Espécie");
                for (int i = 0; i < linhas; i++)
                {
                    DataGridViewRow item = new DataGridViewRow();
                    item.CreateCells(dgvPet);
                    item.Cells[0].Value = dt.Rows[i]["id"].ToString();
                    item.Cells[1].Value = dt.Rows[i]["nome"].ToString();
                    item.Cells[2].Value = dt.Rows[i]["sexo"].ToString();
                    item.Cells[3].Value = dt.Rows[i]["breed"].ToString();
                    item.Cells[4].Value = dt.Rows[i]["especie"].ToString();
                    dgvPet.Rows.Add(item);
                }
            }
            else
            {
                MessageBox.Show("Nenhum animal encontrado!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Close();
            }
        }

        public void CarregaCbxAnimal()
        {
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
                dtpDtFim.Value = Convert.ToDateTime(hsp.checkout);
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
                hsp.Inserir(cbxAnimal.SelectedIndex, dtpDtInicio.Value, dtpDtFim.Value);
                string animal = cbxAnimal.ValueMember;
                this.dtpDtInicio.Value = DateTime.Now.Date;
                this.dtpDtFim.Value = DateTime.Now.Date.AddDays(2);
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
                hsp.Atualizar(txtID.Text, cbxAnimal.SelectedIndex /*cbxAnimal.ValueMember*/, dtpDtInicio.Value, dtpDtFim.Value);
                MessageBox.Show("Hospedagem atualizada com sucesso!", "Atualizar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.dtpDtInicio.Value = DateTime.Now.Date;
                this.dtpDtFim.Value = DateTime.Now.Date.AddDays(2);
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
                this.dtpDtFim.Value = DateTime.Now.Date.AddDays(2);
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
                this.dtpDtFim.Value = DateTime.Now.Date.AddDays(2);
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
