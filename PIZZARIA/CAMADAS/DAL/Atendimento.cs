using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIZZARIA.CAMADAS.DAL
{
    public class Atendimento
    {
        private string strCon = Conexao.getConexao();

        public List<MODEL.Atendimento> Select()
        {
            List<MODEL.Atendimento> lstAtend = new List<MODEL.Atendimento>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "SELECT * FROM Atendimento WHERE finalizado=0";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            try
            {
                conexao.Open();
                SqlDataReader dados = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (dados.Read())
                {
                    MODEL.Atendimento atend = new MODEL.Atendimento();
                    atend.id = Convert.ToInt32(dados["idAtendimento"].ToString());
                    atend.h_pagamento = Convert.ToDateTime(dados["h_pagamento"].ToString());
                    atend.vlr_total = Convert.ToSingle(dados["vlr_total"].ToString());
                    atend.vlr_pago = Convert.ToSingle(dados["vlr_pago"].ToString());
                    atend.troco = Convert.ToSingle(dados["troco"].ToString());
                    atend.idCliente = Convert.ToInt32(dados["cliente_idCliente"].ToString());
                    lstAtend.Add(atend);
                }
            }
            catch
            {
                Console.WriteLine("Erro ao listar registros da tabela Atendimento!");
            }

            return lstAtend;
        }

        public void Inserir(MODEL.Atendimento atend)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "INSERT INTO Atendimento VALUES (' ', 0, 0, 0, @idCliente)";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@idCliente", atend.idCliente);
            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Erro ao inserir registro na tabela Atendimento!");
            }
            finally
            {
                conexao.Close();
            }
        }

        public void Update(MODEL.Atendimento atend)
        {
            List<MODEL.Atendimento> lstAtend = new List<MODEL.Atendimento>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "UPDATE Atendimento SET h_pagamento=@h_pg, vlr_total=@total, vlr_pago=@pg, troco=@troco, finalizado=@finalizado WHERE idAtendimento=@id";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id", atend.id);
            cmd.Parameters.AddWithValue("@h_pg", atend.h_pagamento);
            cmd.Parameters.AddWithValue("@total", atend.vlr_total);
            cmd.Parameters.AddWithValue("@pg", atend.vlr_pago);
            cmd.Parameters.AddWithValue("@troco", atend.troco);
            cmd.Parameters.AddWithValue("@finalizado", atend.finalizado);
            

        }

        public float Total(int id, float total)
        {
            List<MODEL.Atendimento> lstAtend = new List<MODEL.Atendimento>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "SELECT sum(preco*quantidade) FROM Pedido INNER JOIN Produto ON produto_idProduto = idProduto INNER JOIN Classificacao ON Classificacao_idClassificacao = idClassificacao WHERE atend_idAtend=@id;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id", id);

            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
                total = Convert.ToSingle(cmd.ExecuteScalar());
            }
            catch
            {
                Console.WriteLine("Erro ao listar registros da tabela Atendimento!");
            }
            finally
            {
                conexao.Close();
            }
            return total;
        }
    }
}
