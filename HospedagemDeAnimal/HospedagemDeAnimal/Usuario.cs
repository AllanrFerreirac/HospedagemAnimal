using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace HospedagemDeAnimal
{
    internal class Usuario
    {
        public int Id { get; set; }
        public string nome { get; set; }
        public int cpf { get; set; }
        public int celular { get; set; }
        public int cep { get; set; }
        public string endereco { get; set; }
        public string cidade { get; set; }
        public string email { get; set; }
        public string senha { get; set; }

        public List<Usuario> listacliente()
        {
            List<Usuario> li = new List<Usuario>();
            SqlConnection con = ClassConecta.ObterConexao();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "SELECT * FROM usuario";
            cmd.CommandType = CommandType.Text;
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Usuario c = new Usuario();
                c.Id = (int)dr["Id"];
                c.nome = dr["nome"].ToString();
                c.cpf = (int)dr["cpf"];
                c.celular = (int)dr["celular"];
                c.cep = (int)dr["cep"];
                c.endereco = dr["endereco"].ToString();
                c.cidade = dr["cidade"].ToString();
                c.email = dr["email"].ToString();
                c.senha = "******";
                li.Add(c);
            }
            return li;
        }
        public void Inserir(string nome, int cpf, int celular, int cep, string endereco, string cidade, string email, string senha)
        {
            SqlConnection con = ClassConecta.ObterConexao();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "INSERT INTO usuario(nome,cpf,celular,cep,endereco,cidade,email,senha) VALUES ('" + nome + "','" + cpf + "','" + celular + "','" + cep + "','" + endereco + "','" + cidade + "','" + email + "','" + senha + "')";
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            ClassConecta.FecharConexao();
        }

    }
}
