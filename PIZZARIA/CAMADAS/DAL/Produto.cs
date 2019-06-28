using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIZZARIA.CAMADAS.DAL
{
    public class Produto
    {
        private string strCon = Conexao.getConexao();

        public List<MODEL.Produto> Select()
        {
            List<MODEL.Produto> lstProd = new List<MODEL.Produto>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "SELECT Produto.idProduto, Classificacao.nome, Produto.descricao, Produto.preco, Classificacao.idClassificacao FROM Produto INNER JOIN Classificacao ON Produto.Classificacao_idClassificacao = Classificacao.idClassificacao";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            try
            {
                conexao.Open();
                SqlDataReader dados = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (dados.Read())
                {
                    MODEL.Produto prod = new MODEL.Produto();
                    prod.id = Convert.ToInt32(dados["idProduto"].ToString());
                    prod.classificacao = dados["nome"].ToString();
                    prod.descricao = dados["descricao"].ToString();
                    prod.preco = Convert.ToSingle(dados["preco"].ToString());
                    prod.idClassificacao = Convert.ToInt32(dados["idClassificacao"]);
                    lstProd.Add(prod);
                }
            }
            catch
            {
                Console.WriteLine("Erro ao listar os registros da tabela Produto!");
            }

            return lstProd;
        }

        public List<MODEL.Produto> SelectByFkID(int fk)
        {
            List<MODEL.Produto> lstProd = new List<MODEL.Produto>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "SELECT Produto.idProduto, Classificacao.nome, Produto.descricao, Produto.preco, Classificacao.idClassificacao FROM Produto INNER JOIN Classificacao ON Produto.Classificacao_idClassificacao = Classificacao.idClassificacao WHERE Produto.Classificacao_idClassificacao=@fk";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@fk", fk);
            try
            {
                conexao.Open();
                SqlDataReader dados = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (dados.Read())
                {
                    MODEL.Produto prod = new MODEL.Produto();
                    prod.id = Convert.ToInt32(dados["idProduto"].ToString());
                    prod.classificacao = dados["nome"].ToString();
                    prod.descricao = dados["descricao"].ToString();
                    prod.preco = Convert.ToSingle(dados["preco"].ToString());
                    prod.idClassificacao = Convert.ToInt32(dados["idClassificacao"]);
                    lstProd.Add(prod);
                }
            }
            catch
            {
                Console.WriteLine("Erro ao listar os registros da tabela Produto!");
            }

            return lstProd;
        }

        public void Insert(MODEL.Produto prod)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "INSERT INTO Produto VALUES (@preco, @descricao, @Classificacao_idClassificacao)";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@preco", prod.preco);
            cmd.Parameters.AddWithValue("@descricao", prod.descricao);
            cmd.Parameters.AddWithValue("@Classificacao_idClassificacao", prod.idClassificacao);
            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Erro ao inserir registro na tabela Produto!");
            }
            finally
            {
                conexao.Close();
            }
        }

        public void Update(MODEL.Produto prod)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "UPDATE Produto SET descricao=@descricao, preco=@preco, Classificacao_idClassificacao=@Classificacao_idClassificacao WHERE idProduto=@idProduto";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@idProduto", prod.id);
            cmd.Parameters.AddWithValue("@descricao", prod.descricao);
            cmd.Parameters.AddWithValue("@preco", prod.preco);
            cmd.Parameters.AddWithValue("@Classificacao_idClassificacao", prod.idClassificacao);
            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Erro ao atualizar regristro na tabela Produto");
            }
            finally
            {
                conexao.Close();
            }
        }

        public void Delete(int id)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "DELETE FROM Produto WHERE idProduto=@idProduto";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@idProduto", id);
            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Erro ao remover registro solicitado!");
            }
            finally
            {
                conexao.Close();
            }
        }
    }
}
