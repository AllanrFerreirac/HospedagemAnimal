using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospedagemDeAnimal
{
    public class Hospedagem
    {
        public int Id { get; set; }
        public int id_animal { get; set; }
        public DateTime checkin { get; set; }
        public DateTime checkout { get; set; }
        public string status { get; set; }

        public void Inserir(object animal, DateTime checkin, DateTime checkout)
        {
            if (checkin < checkout)
            {
                var id_animal = animal.ToString();
                string status = "reserva";
                SqlConnection con = ClassConecta.ObterConexao();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "INSERT INTO hospedagem(id_animal,checkin,checkout,status) VALUES ('" + Convert.ToInt32(id_animal) + "',Convert(DateTime,'" + checkin + "',103),Convert(DateTime,'" + checkout + "',103),'" + status + "')";
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                ClassConecta.FecharConexao();
            }
            else
            {
                MessageBox.Show("A data final deve ser menor que a inicial", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        public void Localiza(int id)
        {
            SqlConnection con = ClassConecta.ObterConexao();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "SELECT * FROM hospedagem WHERE Id='" + id + "'";
            cmd.CommandType = CommandType.Text;
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                id_animal = (int)dr["id_animal"];
                checkin = Convert.ToDateTime(dr["checkin"]);
                checkout = Convert.ToDateTime(dr["checkout"]);
                status = dr["status"].ToString();
            }
        }

        public void LocalizaTodos()
        {
            SqlConnection con = ClassConecta.ObterConexao();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "SELECT * FROM hospedagem";
            cmd.CommandType = CommandType.Text;
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                id_animal = (int)dr["id_animal"];
                checkin = Convert.ToDateTime(dr["checkin"]);
                checkout = Convert.ToDateTime(dr["checkout"]);
                status = dr["status"].ToString();
            }
        }

        public void Atualizar(string id, object animal, DateTime checkin, DateTime checkout)
        {
            if (checkin < checkout)
            {
                var id_animal = animal.ToString();
                SqlConnection con = ClassConecta.ObterConexao();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "UPDATE hospedagem SET id_animal='" + Convert.ToInt32(id_animal) + "',checkin=Convert(DateTime,'" + checkin + "',103), checkout=Convert(DateTime,'" + checkout + "',103) WHERE Id = '" + Convert.ToInt32(id) + "'";
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                ClassConecta.FecharConexao();
            }
            else
            {
                MessageBox.Show("A data final deve ser menor que a inicial", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void Excluir(string id)
        {
            SqlConnection con = ClassConecta.ObterConexao();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "DELETE FROM hospedagem WHERE Id = '" + Convert.ToInt32(id) + "'";
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            ClassConecta.FecharConexao();
        }

        public void Confirmar(string id)
        {
            SqlConnection con = ClassConecta.ObterConexao();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "UPDATE hospedagem SET status = 'confirmado' WHERE Id = '" + Convert.ToInt32(id) + "'";
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            ClassConecta.FecharConexao();
        }

        public void Checkin(string id)
        {
            SqlConnection con = ClassConecta.ObterConexao();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "UPDATE hospedagem SET status = 'hospedado' WHERE Id = '" + Convert.ToInt32(id) + "'";
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            ClassConecta.FecharConexao();
        }

        public void Checkout(string id)
        {
            SqlConnection con = ClassConecta.ObterConexao();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "UPDATE hospedagem SET status = 'finalizado' WHERE Id = '" + Convert.ToInt32(id) + "'";
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            ClassConecta.FecharConexao();
        }
    }
}
