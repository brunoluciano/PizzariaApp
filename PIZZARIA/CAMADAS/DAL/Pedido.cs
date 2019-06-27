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
            string sql = "SELECT * FROM Pedido";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            try
            {
                conexao.Open();
                SqlDataReader dados = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (dados.Read())
                {
                    MODEL.Pedido ped = new MODEL.Pedido();
                    ped.observacao = dados["observacao"].ToString();
                    ped.idMesa = Convert.ToInt32(dados["mesa_idMesa"].ToString());
                    ped.idAtend = Convert.ToInt32(dados["atend_idAtend"].ToString());
                    ped.idProduto = Convert.ToInt32(dados["produto_idProduto"].ToString());
                    lstPedido.Add(ped);
                }
            }
            catch
            {
                Console.WriteLine("Erro ao listar registros da tabela de Pedido");
            }

            return lstPedido;
        }
    }
}
