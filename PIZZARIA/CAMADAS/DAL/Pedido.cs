using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIZZARIA.CAMADAS.DAL
{
    public class Pedido
    {
        private string strCon = Conexao.getConexao();

        public List<MODEL.Pedido> Select()
        {
            List<MODEL.Pedido> lstPedido = new List<MODEL.Pedido>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "SELECT * FROM Pedido INNER JOIN Produto ON produto_idProduto=idProduto INNER JOIN Classificacao ON Classificacao_idClassificacao=idClassificacao";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            try
            {
                conexao.Open();
                SqlDataReader dados = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (dados.Read())
                {
                    MODEL.Pedido ped = new MODEL.Pedido();
                    ped.id = Convert.ToInt32(dados["id"].ToString());
                    ped.observacao = dados["observacao"].ToString();
                    ped.idAtend = Convert.ToInt32(dados["atend_idAtend"].ToString());
                    ped.idProduto = Convert.ToInt32(dados["produto_idProduto"].ToString());
                    ped.produto = dados["descricao"].ToString();
                    ped.idClass = Convert.ToInt32(dados["idClassificacao"]);
                    ped.classificacao = dados["nome"].ToString();
                    ped.quantidade = Convert.ToInt32(dados["quantidade"].ToString());
                    lstPedido.Add(ped);
                }
            }
            catch
            {
                Console.WriteLine("Erro ao listar registros da tabela de Pedido");
            }

            return lstPedido;
        }

        public List<MODEL.Pedido> SelectByFkID(int fk)
        {
            List<MODEL.Pedido> lstPedido = new List<MODEL.Pedido>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "SELECT * FROM Pedido INNER JOIN Produto ON produto_idProduto=idProduto INNER JOIN Classificacao ON Classificacao_idClassificacao=idClassificacao WHERE atend_idAtend=@fk";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@fk", fk);
            try
            {
                conexao.Open();
                SqlDataReader dados = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (dados.Read())
                {
                    MODEL.Pedido ped = new MODEL.Pedido();
                    ped.id = Convert.ToInt32(dados["id"].ToString());
                    ped.observacao = dados["observacao"].ToString();
                    ped.idAtend = Convert.ToInt32(dados["atend_idAtend"].ToString());
                    ped.idProduto = Convert.ToInt32(dados["produto_idProduto"].ToString());
                    ped.produto = dados["descricao"].ToString();
                    ped.idClass = Convert.ToInt32(dados["idClassificacao"]);
                    ped.classificacao = dados["nome"].ToString();
                    ped.quantidade = Convert.ToInt32(dados["quantidade"].ToString());
                    lstPedido.Add(ped);
                }
            }
            catch
            {
                Console.WriteLine("Erro ao listar registros da tabela de Pedido");
            }

            return lstPedido;
        }

        public void Inserir(MODEL.Pedido ped)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "INSERT INTO Pedido VALUES (@obs, @idAtend, @idProd, @qtd)";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@obs", ped.observacao);
            cmd.Parameters.AddWithValue("@idAtend", ped.idAtend);
            cmd.Parameters.AddWithValue("@idProd", ped.idProduto);
            cmd.Parameters.AddWithValue("@qtd", ped.quantidade);
            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Erro ao inserir regristro na tabela Pedido");
            }
            finally
            {
                conexao.Close();
            }
        }

        public void Update(MODEL.Pedido ped)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "UPDATE Pedido SET observacao=@obs, produto_idProduto=@idProd, quantidade=@qtd WHERE id=@id";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id", ped.id);
            cmd.Parameters.AddWithValue("@obs", ped.observacao);
            cmd.Parameters.AddWithValue("@idProd", ped.idProduto);
            cmd.Parameters.AddWithValue("@qtd", ped.quantidade);
            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Erro ao atualizar o registro solicitado!");
            }
            finally
            {
                conexao.Close();
            }
        }

        public void Delete(int id)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "DELETE FROM Pedido WHERE id=@id";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id", id);
            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Erro ao deletar regristro solicitado!");
            }
            finally
            {
                conexao.Close();
            }
        }
    }
}
