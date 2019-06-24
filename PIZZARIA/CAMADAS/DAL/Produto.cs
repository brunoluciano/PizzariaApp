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
                while(dados.Read())
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

    }
}
