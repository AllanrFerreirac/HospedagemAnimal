using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace HospedagemDeAnimal
{
    public class Usuario
    {
        public int Id { get; set; }
        public string nome { get; set; }
        public string cpf { get; set; }
        public int celular { get; set; }
        public int cep { get; set; }
        public string endereco { get; set; }
        public string cidade { get; set; }
        public string email { get; set; }
        public string senha { get; set; }
        public string processo { get; set; }
        
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
                c.cpf = dr["cpf"].ToString();
                c.celular = (int)dr["celular"];
                c.cep = (int)dr["cep"];
                c.endereco = dr["endereco"].ToString();
                c.cidade = dr["cidade"].ToString();
                c.email = dr["email"].ToString();
                c.processo = dr["processo"].ToString();
                li.Add(c);
            }
            return li;
        }

        public async Task<bool> Inserir(string nome, string cpf, int celular, int cep, string endereco, string cidade, string email, string senha)
        {
            SqlConnection con = ClassConecta.ObterConexao();
            SqlCommand cmd = con.CreateCommand();
            var processo = "user";
            var busca = await BuscarPorCPF(cpf);
            if (busca)
            {
                cmd.CommandText = "INSERT INTO usuario(nome,cpf,celular,cep,endereco,cidade,email,senha,processo) VALUES ('" + nome + "','" + cpf + "','" + celular + "','" + cep + "','" + endereco + "','" + cidade + "','" + email + "','" + senha + "','" + processo + "')";
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cadastro realizado com sucesso!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClassConecta.FecharConexao();
                return true;
            }
            else
            {
                ClassConecta.FecharConexao();
                return false;
            }

        }

        public void Procurar(string cpf)
        {
            SqlConnection con = ClassConecta.ObterConexao();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "SELECT * FROM usuario WHERE cpf='" + cpf + "'";
            cmd.CommandType = CommandType.Text;
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                nome = dr["nome"].ToString();
                //cpf = dr["cpf"].ToString();
                celular = (int)dr["celular"];
                cep = (int)dr["cep"];
                endereco = dr["endereco"].ToString();
                cidade = dr["cidade"].ToString();
                email = dr["email"].ToString();
                processo = dr["processo"].ToString();
            }
        }

        public async Task<bool> BuscarPorCPF(string cpf)
        {
            SqlConnection con = ClassConecta.ObterConexao();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "SELECT * FROM usuario WHERE cpf='" + cpf + "'";
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Já existe um usuário cadastrado com esse CPF", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else
            {
                return true;
            }
        }

        public void Exclui(string cpf)
        {
            SqlConnection con = ClassConecta.ObterConexao();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "DELETE FROM usuario WHERE cpf='" + cpf + "'";
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            ClassConecta.FecharConexao();
        }

        public void Atualizar(string nome,int celular, int cep, string endereco, string cidade, string email, string senha)
        {
            SqlConnection con = ClassConecta.ObterConexao();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "UPDATE usuario SET nome='" + nome + "',celular='" + celular + "',cep='" + cep + "',endereco='" + endereco + "',cidade='" + cidade + "',email='" + email + "',senha='" + senha + "' WHERE cpf = '" + FormLogin.usuarioconectado + "'";
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            ClassConecta.FecharConexao();
        }

        public void AtualizarAdmin(string nome, string cpf, int celular, int cep, string endereco, string cidade, string email, string processo)
        {
            SqlConnection con = ClassConecta.ObterConexao();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "UPDATE usuario SET nome='" + nome + "',cpf='" + cpf + "',celular='" + celular + "',cep='" + cep + "',endereco='" + endereco + "',cidade='" + cidade + "',email='" + email + "',processo='" + processo + "' WHERE cpf = '" + cpf + "'";
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            ClassConecta.FecharConexao();
        }
    }
}