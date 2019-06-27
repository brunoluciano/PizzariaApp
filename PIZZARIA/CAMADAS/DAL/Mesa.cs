using System;
using System.Collections.Generic;
using System.Data.SqlClient;
//using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIZZARIA.CAMADAS.DAL
{
    public class Mesa
    {
        private string strCon = Conexao.getConexao();

        public List<MODEL.Mesa> Select()
        {
            List<MODEL.Mesa> lstMesa = new List<MODEL.Mesa>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Select * from Mesa";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            try
            {
                conexao.Open();
                //SqlDataReader dados = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                SqlDataReader dados = cmd.ExecuteReader();
                while (dados.Read())
                {
                    MODEL.Mesa mesa = new MODEL.Mesa();
                    mesa.id = Convert.ToInt32(dados["idMesa"].ToString());
                    mesa.status = Convert.ToBoolean(dados["status"].ToString());
                    mesa.descricao = dados["qtdLugares"].ToString();
                    lstMesa.Add(mesa);
                }
            }
            catch
            {
                Console.WriteLine("Não foi possível realizar consulta de Mesas");
            }
            finally
            {
                conexao.Close();
            }


            return lstMesa;
        }
    }
}
