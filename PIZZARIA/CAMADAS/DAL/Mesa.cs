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
                    mesa.qtdLugares = Convert.ToInt32(dados["qtdLugares"]);
                    mesa.numero = Convert.ToInt32(dados["numero"]);
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

        public void Insert(MODEL.Mesa mesa)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Insert into Mesa values(@status, @qtdLugares, @numero);";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@status", mesa.status);
            cmd.Parameters.AddWithValue("@qtdLugares", mesa.qtdLugares);
            cmd.Parameters.AddWithValue("@numero", mesa.numero);
            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Não foi possível realizar Inserção do valor!");
            }
            finally
            {
                conexao.Close();
            }
        }

        public void Update(MODEL.Mesa mesa)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "UPDATE Mesa SET qtdLugares=@qtd, numero=@numero WHERE idMesa=@id";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id", mesa.id);
            cmd.Parameters.AddWithValue("@qtd", mesa.qtdLugares);
            cmd.Parameters.AddWithValue("@numero", mesa.numero);
            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Não foi possível alterar o valor!");
            }
            finally
            {
                conexao.Close();
            }
        }
        
        public void Delete(int id)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Delete from Mesa where idMesa=@idMesa";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@idMesa", id);
            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch 
            {
                Console.WriteLine("Não foi possível remover mesa");
            }
            finally
            {
                conexao.Close();
            }
        }
    }
}
