using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIZZARIA.CAMADAS.DAL
{
    public class Cliente
    {
        private string strCon = Conexao.getConexao();

        public List<MODEL.Cliente> Select()
        {
            List<MODEL.Cliente> lstCli = new List<MODEL.Cliente>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "SELECT idCliente, CPF, nome_cli, telefone, dt_nascimento, endereco, numero, complemento, bairro, CEP, idCidade, nome_cid, UF FROM Cliente INNER JOIN Cidade ON Cidade.idCidade = Cidade_idCidade INNER JOIN Estado ON Cidade.idEstado = Estado.idEstado";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            try
            {
                conexao.Open();
                SqlDataReader dados = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while(dados.Read())
                {
                    MODEL.Cliente cliente = new MODEL.Cliente();
                    cliente.id = Convert.ToInt32(dados["idCliente"].ToString());
                    cliente.cpf = dados["CPF"].ToString();
                    cliente.nome = dados["nome_cli"].ToString();
                    cliente.telefone = dados["telefone"].ToString();
                    cliente.dt_nasc = Convert.ToDateTime(dados["dt_nascimento"].ToString());
                    cliente.endereco = dados["endereco"].ToString();
                    cliente.numero = Convert.ToInt32(dados["numero"].ToString());
                    cliente.complemento = dados["complemento"].ToString();
                    cliente.bairro = dados["bairro"].ToString();
                    cliente.cep = Convert.ToInt32(dados["CEP"].ToString());
                    cliente.idCidade = Convert.ToInt32(dados["idCidade"].ToString());
                    cliente.cidade = dados["nome_cid"].ToString();
                    cliente.uf = dados["UF"].ToString();
                    lstCli.Add(cliente);
                }
            }
            catch
            {
                Console.WriteLine("Erro ao listar dados da Classe Cliente!");
            }
            return lstCli;
        }

        public void Inserir(MODEL.Cliente cliente)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "INSERT INTO Cliente VALUES (@CPF, @telefone, @nome_cli, @dt_nascimento, @endereco, @numero, @complemento, @bairro, @CEP, @Cidade_idCidade)";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@CPF", cliente.cpf);
            cmd.Parameters.AddWithValue("@telefone", cliente.telefone);
            cmd.Parameters.AddWithValue("@nome_cli", cliente.nome);
            cmd.Parameters.AddWithValue("@dt_nascimento", cliente.dt_nasc);
            cmd.Parameters.AddWithValue("@endereco", cliente.endereco);
            cmd.Parameters.AddWithValue("@numero", cliente.numero);
            cmd.Parameters.AddWithValue("@complemento", cliente.complemento);
            cmd.Parameters.AddWithValue("@bairro", cliente.bairro);
            cmd.Parameters.AddWithValue("@CEP", cliente.cep);
            cmd.Parameters.AddWithValue("@Cidade_idCidade", cliente.idCidade);
            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Erro ao inserir o registro na tabela Cliente!");
            }
            finally
            {
                conexao.Close();
            }
        }

        public void Update(MODEL.Cliente cliente)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "UPDATE Cliente SET CPF=@CPF, telefone=@telefone, nome_cli=@nome_cli, dt_nascimento=@dt_nascimento, endereco=@endereco, numero=@numero, complemento=@complemento, bairro=@bairro, CEP=@CEP, Cidade_idCidade=@Cidade_idCidade WHERE idCliente=@idCliente";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@idCliente", cliente.id);
            cmd.Parameters.AddWithValue("@CPF", cliente.cpf);
            cmd.Parameters.AddWithValue("@telefone", cliente.telefone);
            cmd.Parameters.AddWithValue("@nome_cli", cliente.nome);
            cmd.Parameters.AddWithValue("@dt_nascimento", cliente.dt_nasc);
            cmd.Parameters.AddWithValue("@endereco", cliente.endereco);
            cmd.Parameters.AddWithValue("@numero", cliente.numero);
            cmd.Parameters.AddWithValue("@complemento", cliente.complemento);
            cmd.Parameters.AddWithValue("@bairro", cliente.bairro);
            cmd.Parameters.AddWithValue("@CEP", cliente.cep);
            cmd.Parameters.AddWithValue("@Cidade_idCidade", cliente.idCidade);
            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Erro ao atualizar registro na tabela Cliente!");

            }
            finally
            {
                conexao.Close();
            }
        }

        public void Delete(int id)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "DELETE FROM Cliente WHERE idCliente=@idCliente";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@idCliente", id);
            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Erro ao excluir o regristro solicitado!");
            }
            finally
            {
                conexao.Close();
            }

        }
    }
}
