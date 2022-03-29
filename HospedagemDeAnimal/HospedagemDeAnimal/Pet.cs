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
    public class Pet
    {
        public int Id { get; set; }
        public string cpf_tutor { get; set; }
        public string nome { get; set; }
        public string sexo { get; set; }
        public string breed { get; set; } //raça
        public string especie { get; set; }
        public DateTime dt_nascimento { get; set; }

        public void Inserir(string cpf_tutor, string nome, string sexo, string breed, string especie, DateTime dt_nascimento)
        {
            SqlConnection con = ClassConecta.ObterConexao();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "INSERT INTO animal(cpf_tutor,nome,sexo,breed,especie,dt_nascimento) VALUES ('" + cpf_tutor + "','" + nome + "','" + sexo + "','" + breed + "','" + especie + "',Convert(DateTime,'" + dt_nascimento + "',103))";
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            ClassConecta.FecharConexao();
        }

        public void Localiza(int id)
        {
            SqlConnection con = ClassConecta.ObterConexao();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "SELECT * FROM animal WHERE Id='" + id + "'";
            cmd.CommandType = CommandType.Text;
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cpf_tutor = dr["cpf_tutor"].ToString();
                nome = dr["nome"].ToString();
                sexo = dr["sexo"].ToString();
                breed = dr["breed"].ToString();
                especie = dr["especie"].ToString();
                dt_nascimento = Convert.ToDateTime(dr["dt_nascimento"]);
            }
        }

        public void Atualizar(string id, string cpf_tutor, string nome, string sexo, string breed, string especie, DateTime dt_nascimento)
        {
            SqlConnection con = ClassConecta.ObterConexao();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "UPDATE animal SET cpf_tutor='" + cpf_tutor + "',nome='" + nome + "', sexo='" + sexo + "', breed='" + breed + "', especie='" + especie + "', dt_nascimento=Convert(DateTime,'" + dt_nascimento + "',103) WHERE Id = '" + Convert.ToInt32(id) + "'";
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            ClassConecta.FecharConexao();
        }

        public void Excluir(string id)
        {
            SqlConnection con = ClassConecta.ObterConexao();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "DELETE FROM animal WHERE Id = '" + Convert.ToInt32(id) + "'";
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            ClassConecta.FecharConexao();
        }
    }
}
