using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIZZARIA.CAMADAS.DAL
{
    public class Classificacao
    {
        private string strCon = Conexao.getConexao();

        public List<MODEL.Classificacao> Select()
        {
            List<MODEL.Classificacao> lstClass = new List<MODEL.Classificacao>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "SELECT * FROM Classificacao";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            try
            {
                conexao.Open();
                SqlDataReader dados = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while(dados.Read())
                {
                    CAMADAS.MODEL.Classificacao cla = new CAMADAS.MODEL.Classificacao();
                    cla.id = Convert.ToInt32(dados["idClassificacao"].ToString());
                    cla.nome = dados["nome"].ToString();
                    lstClass.Add(cla);
                }
            }
            catch
            {
                Console.WriteLine("Erro ao listar registros da tabela Classificação");
            }
            return lstClass;
        }

        public List<MODEL.Classificacao> SelectCres()
        {
            List<MODEL.Classificacao> lstClass = new List<MODEL.Classificacao>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "SELECT * FROM Classificacao ORDER BY nome ASC";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            try
            {
                conexao.Open();
                SqlDataReader dados = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (dados.Read())
                {
                    CAMADAS.MODEL.Classificacao cla = new CAMADAS.MODEL.Classificacao();
                    cla.id = Convert.ToInt32(dados["idClassificacao"].ToString());
                    cla.nome = dados["nome"].ToString();
                    lstClass.Add(cla);
                }
            }
            catch
            {
                Console.WriteLine("Erro ao listar registros da tabela Classificação");
            }
            return lstClass;
        }
    }
}
