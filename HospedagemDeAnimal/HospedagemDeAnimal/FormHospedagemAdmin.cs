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
using HospedagemDeAnimal;
using System.Data.SqlClient;

namespace HospedagemDeAnimal
{
    public partial class FormHospedagemAdmin : Form
    {
        public FormHospedagemAdmin()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(ClassConecta.stringconexao);

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            try
            {
                Hospedagem hsp = new Hospedagem();
                hsp.Checkout(txtID.Text);
                MessageBox.Show("Checkout feito com sucesso!", "Fim hospedagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtID.Text = "";
                dgvPet.Rows.Clear();
                dgvPet.Columns.Clear();
                dgvPet.Refresh();
                listaHospedagem();
                ClassConecta.FecharConexao();
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void btnCheckin_Click(object sender, EventArgs e)
        {
            try
            {
                Hospedagem hsp = new Hospedagem();
                hsp.Checkin(txtID.Text);
                MessageBox.Show("Checkin feito com sucesso!", "Inicio hospedagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtID.Text = "";
                dgvPet.Rows.Clear();
                dgvPet.Columns.Clear();
                dgvPet.Refresh();
                listaHospedagem();
                ClassConecta.FecharConexao();
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(txtID.Text.Trim());
                Hospedagem hsp = new Hospedagem();
                hsp.Localiza(id);
                txtID.Text = hsp.Id.ToString();
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        public void listaHospedagem()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
            SqlCommand cmd = new SqlCommand("HospedagemAdmin", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            int linhas = dt.Rows.Count;
            if (dt.Rows.Count > 0)
            {
                dgvPet.Columns.Add("Id", "Id");
                dgvPet.Columns.Add("Animal", "Animal");
                dgvPet.Columns.Add("Cpf", "Cpf");
                dgvPet.Columns.Add("Tutor", "Tutor");
                dgvPet.Columns.Add("Checkin", "Checkin");
                dgvPet.Columns.Add("Checkout", "Checkout");
                dgvPet.Columns.Add("Status", "Status");
                for (int i = 0; i < linhas; i++)
                {
                    DataGridViewRow item = new DataGridViewRow();
                    item.CreateCells(dgvPet);
                    item.Cells[0].Value = dt.Rows[i]["Id"].ToString();
                    item.Cells[1].Value = dt.Rows[i]["Animal"].ToString();
                    item.Cells[2].Value = dt.Rows[i]["Cpf"].ToString();
                    item.Cells[3].Value = dt.Rows[i]["Tutor"].ToString();
                    item.Cells[4].Value = dt.Rows[i]["Checkin"].ToString();
                    item.Cells[5].Value = dt.Rows[i]["Checkout"].ToString();
                    item.Cells[6].Value = dt.Rows[i]["Status"].ToString();
                    dgvPet.Rows.Add(item);
                }
            }
            con.Close();
        }

        private void FormHospedagemAdmin_Load(object sender, EventArgs e)
        {
            dgvPet.Rows.Clear();
            dgvPet.Columns.Clear();
            dgvPet.Refresh();
            listaHospedagem();
        }

        private void dgvPet_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dgvPet.Rows[e.RowIndex];
            txtID.Text = row.Cells[0].Value.ToString().Trim();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
