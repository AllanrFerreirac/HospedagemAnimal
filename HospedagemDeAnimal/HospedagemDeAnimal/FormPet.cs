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
    public partial class FormPet : Form
    {
        SqlConnection con = new SqlConnection(ClassConecta.stringconexao);

        public FormPet()
        {
            InitializeComponent();
        }

        public void MeusPets()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM animal WHERE cpf_tutor = @cpf_tutor", con);
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
        }

        private void btnLocalizar_Click_1(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(txtID.Text.Trim());
                Pet pet = new Pet();
                pet.Localiza(id);
                dgvPet.Rows.Clear();
                dgvPet.Columns.Clear();
                dgvPet.Refresh();
                MeusPets();
                txtNome.Text = pet.nome.Trim();
                txtSexo.Text = pet.sexo.Trim();
                txtBreed.Text = pet.breed.Trim();
                txtEspecie.Text = pet.especie.Trim();
                dtpDt_N.Value = Convert.ToDateTime(pet.dt_nascimento);
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void btnCadastroPet_Click_1(object sender, EventArgs e)
        {
            try
            {
                var user = FormLogin.usuarioconectado;
                Pet pet = new Pet();
                pet.Inserir(user, txtNome.Text, txtSexo.Text, txtBreed.Text, txtEspecie.Text, dtpDt_N.Value);
                MessageBox.Show("Animal cadastrado com sucesso!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvPet.Rows.Clear();
                dgvPet.Columns.Clear();
                dgvPet.Refresh();
                MeusPets();
                txtNome.Text = "";
                txtSexo.Text = "";
                txtBreed.Text = "";
                txtEspecie.Text = "";
                this.dtpDt_N.Value = DateTime.Now.Date;
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
                var user = FormLogin.usuarioconectado;
                Pet pet = new Pet();
                pet.Atualizar(txtID.Text, user, txtNome.Text, txtSexo.Text, txtBreed.Text, txtEspecie.Text, dtpDt_N.Value);
                MessageBox.Show("Animal atualizado com sucesso!", "Atualizar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvPet.Rows.Clear();
                dgvPet.Columns.Clear();
                dgvPet.Refresh();
                MeusPets();
                txtNome.Text = "";
                txtSexo.Text = "";
                txtBreed.Text = "";
                txtEspecie.Text = "";
                this.dtpDt_N.Value = DateTime.Now.Date;
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
                MessageBox.Show("Animal excluído com sucesso!", "Deletar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvPet.Rows.Clear();
                dgvPet.Columns.Clear();
                dgvPet.Refresh();
                MeusPets();
                txtNome.Text = "";
                txtSexo.Text = "";
                txtBreed.Text = "";
                txtEspecie.Text = "";
                this.dtpDt_N.Value = DateTime.Now.Date;
                ClassConecta.FecharConexao();
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void FormPet_Load(object sender, EventArgs e)
        {
            dgvPet.Rows.Clear();
            dgvPet.Columns.Clear();
            dgvPet.Refresh();
            MeusPets();
        }

        private void btnBuscarPets_Click_1(object sender, EventArgs e)
        {

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            FormPrincipal form = new FormPrincipal();
            form.Show();
        }

        private void dgvPet_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dgvPet.Rows[e.RowIndex];
            txtID.Text = row.Cells[0].Value.ToString();
            txtNome.Text = row.Cells[1].Value.ToString();
            txtSexo.Text = row.Cells[2].Value.ToString();
            txtBreed.Text = row.Cells[3].Value.ToString();
            txtEspecie.Text = row.Cells[4].Value.ToString();
        }
    }
}
