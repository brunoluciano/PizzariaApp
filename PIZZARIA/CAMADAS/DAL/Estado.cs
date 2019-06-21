using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIZZARIA.CAMADAS.DAL
{
    public class Estado
    {
        private string strCon = Conexao.getConexao();

        public List<MODEL.Estado> Select()
        {
            List<MODEL.Estado> lstEstado = new List<MODEL.Estado>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "SELECT * FROM Estado";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            try
            {
                conexao.Open();
                SqlDataReader dados = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (dados.Read())
                {
                    MODEL.Estado estado = new MODEL.Estado();
                    estado.id = Convert.ToInt32(dados["idEstado"].ToString());
                    estado.uf = dados["UF"].ToString();
                    estado.nome = dados["nome_est"].ToString();
                    lstEstado.Add(estado);
                }
            }
            catch
            {
                Console.WriteLine("Falha na consulta da classe Estado!");
            }
            finally
            {
                //conexao.Close(); Está usanco o CommandBehavior.CloseConnection
            }

            return lstEstado;
        }
    }
}
