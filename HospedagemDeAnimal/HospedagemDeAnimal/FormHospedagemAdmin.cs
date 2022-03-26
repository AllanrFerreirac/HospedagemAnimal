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
                hsp.Checkin(txtID.Text);
                MessageBox.Show("Check-in feito com sucesso!", "Inicio hospedagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtID.Text = "";
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
                hsp.Checkout(txtID.Text);
                MessageBox.Show("Check-out feito com sucesso!", "Fim hospedagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtID.Text = "";
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
            SqlCommand cmd = new SqlCommand("SELECT * FROM hospedagem", con);
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            int linhas = dt.Rows.Count;
            if (dt.Rows.Count > 0)
            {
                dgvPet.Columns.Add("ID", "ID");
                dgvPet.Columns.Add("Animal", "Nome");
                dgvPet.Columns.Add("Data Início", "Data Início");
                dgvPet.Columns.Add("Data Final", "Data Final");
                dgvPet.Columns.Add("Status", "Status");
                for (int i = 0; i < linhas; i++)
                {
                    DataGridViewRow item = new DataGridViewRow();
                    item.CreateCells(dgvPet);
                    item.Cells[0].Value = dt.Rows[i]["id"].ToString();
                    item.Cells[1].Value = dt.Rows[i]["animal"].ToString();
                    item.Cells[2].Value = dt.Rows[i]["checkin"].ToString();
                    item.Cells[3].Value = dt.Rows[i]["checkou"].ToString();
                    item.Cells[4].Value = dt.Rows[i]["status"].ToString();
                    dgvPet.Rows.Add(item);
                }
            }
            //else
            //{
            //    MessageBox.Show("Nenhuma hospedagem encontrada.", "Oops!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    con.Close();
            //}
        }

        private void FormHospedagemAdmin_Load(object sender, EventArgs e)
        {
            listaHospedagem();
        }
    }
}
