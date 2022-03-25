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
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Aluno\source\repos\HospedagemPet\HospedagemPet\DbHospedagemPet.mdf;Integrated Security=True");

        public FormPet()
        {
            InitializeComponent();
        }

        private void btnLocalizar_Click_1(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(txtID.Text.Trim());
                Pet pet = new Pet();
                pet.Localiza(id);
                txtIdTutor.Text = pet.cpf_tutor.ToString().Trim();
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
                Pet pet = new Pet();
                pet.Inserir(txtIdTutor.Text, txtNome.Text, txtSexo.Text, txtBreed.Text, txtEspecie.Text, dtpDt_N.Value);
                MessageBox.Show("Animal cadastrado com sucesso!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                string cpf = txtIdTutor.Text;
                txtIdTutor.Text = "";
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
                Pet pet = new Pet();
                pet.Atualizar(txtID.Text, txtIdTutor.Text, txtNome.Text, txtSexo.Text, txtBreed.Text, txtEspecie.Text, dtpDt_N.Value);
                MessageBox.Show("Animal atualizado com sucesso!", "Atualizar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                string cpf = txtIdTutor.Text;
                txtIdTutor.Text = "";
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
                MessageBox.Show("Cliente excluído com sucesso!", "Deletar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtIdTutor.Text = "";
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

        private void btnBuscarPets_Click_1(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM animal WHERE cpf_tutor = @cpf_tutor", con);
            cmd.Parameters.AddWithValue("@cpf_tutor", txtBuscarPets.Text);
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

        private void btnVoltar_Click(object sender, EventArgs e)
        {

        }
    }
}
