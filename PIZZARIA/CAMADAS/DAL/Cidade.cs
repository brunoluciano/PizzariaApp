using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIZZARIA.CAMADAS.DAL
{
    public class Cidade
    {
        private string strCon = Conexao.getConexao();

        public List<MODEL.Cidade> Select()
        {
            List<MODEL.Cidade> lstCidade = new List<MODEL.Cidade>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "SELECT Cidade.idCidade, Cidade.nome_cid, Cidade.idEstado, Estado.UF FROM Cidade, Estado WHERE Cidade.idEstado = Estado.idEstado";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            try
            {
                conexao.Open();
                SqlDataReader dados = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while(dados.Read())
                {
                    MODEL.Cidade cidade = new MODEL.Cidade();
                    cidade.id = Convert.ToInt32(dados["idCidade"].ToString());
                    cidade.nome = dados["nome_cid"].ToString();
                    cidade.idEstado = Convert.ToInt32(dados["idEstado"].ToString());
                    cidade.uf = dados["UF"].ToString();
                    lstCidade.Add(cidade);
                }
            }
            catch
            {
                Console.WriteLine("Falha na consulta da classe Cidade!");
            }

            return lstCidade;
        }

        public List<MODEL.Cidade> SelectCres()
        {
            List<MODEL.Cidade> lstCidade = new List<MODEL.Cidade>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "SELECT Cidade.idCidade, Cidade.nome_cid, Cidade.idEstado, Estado.UF FROM Cidade, Estado WHERE Cidade.idEstado = Estado.idEstado ORDER BY nome_cid ASC";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            try
            {
                conexao.Open();
                SqlDataReader dados = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (dados.Read())
                {
                    MODEL.Cidade cidade = new MODEL.Cidade();
                    cidade.id = Convert.ToInt32(dados["idCidade"].ToString());
                    cidade.nome = dados["nome_cid"].ToString();
                    cidade.idEstado = Convert.ToInt32(dados["idEstado"].ToString());
                    cidade.uf = dados["UF"].ToString();
                    lstCidade.Add(cidade);
                }
            }
            catch
            {
                Console.WriteLine("Falha na consulta da classe Cidade!");
            }

            return lstCidade;
        }

        public void Insert(MODEL.Cidade cidade)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "INSERT INTO Cidade VALUES (@nome_cid, @idEstado)";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("nome_cid", cidade.nome);
            cmd.Parameters.AddWithValue("idEstado", cidade.idEstado);
            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Erro ao inserir registro na tabela Cidade!");

            }
            finally
            {
                conexao.Close();
            }
        }

        public void Update(MODEL.Cidade cidade)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "UPDATE Cidade SET nome_cid=@nome_cid, idEstado=@idEstado WHERE idCidade=@idCidade";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("idCidade", cidade.id);
            cmd.Parameters.AddWithValue("nome_cid", cidade.nome);
            cmd.Parameters.AddWithValue("idEstado", cidade.idEstado);
            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Erro ao atualizar registro na tabela Cidade!");

            }
            finally
            {
                conexao.Close();
            }
        }  

        public void Delete(int id)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "DELETE FROM Cidade WHERE idCidade=@idCidade";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@idCidade", id);
            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Erro ao excluir o registro solicitado!");
            }
            finally
            {
                conexao.Close();
            }
        }
    }
}
